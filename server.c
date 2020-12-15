#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <fcntl.h>
#include <netinet/in.h>
#include <stdio.h>
#include <mysql.h>
#include <pthread.h>
#include <my_global.h>

typedef struct {
	char nombre[20];
	int socket;
}Tconectado;

typedef struct{
	int num;
	Tconectado conectados[100];
}TListaConectados;

TListaConectados lista;
TListaConectados jugadorespartida;
pthread_mutex_t mutex=PTHREAD_MUTEX_INITIALIZER;

// Enviar invitación a los jugadores de la partida
void CrearPartida(TListaConectados*lista,char respuesta[512],char jugador1[100],char jugador2[100],char jugador3[100],char jugador4[100],char jugador5[100],char jugador6[100])
{
	int socket1=EncontrarSocket(jugador1,&lista);
	int socket2=EncontrarSocket(jugador2,&lista);
	int socket3=EncontrarSocket(jugador3,&lista);
	int socket4=EncontrarSocket(jugador4,&lista);
	int socket5=EncontrarSocket(jugador5,&lista);
	int socket6=EncontrarSocket(jugador6,&lista);
	sprintf(respuesta,"4/%s te ha invitado a jugar", jugador1);
	UsuarioConectado(jugador1,socket1,&jugadorespartida);
	UsuarioConectado(jugador2,socket2,&jugadorespartida);
	UsuarioConectado(jugador3,socket3,&jugadorespartida);
	UsuarioConectado(jugador4,socket4,&jugadorespartida);
	UsuarioConectado(jugador5,socket5,&jugadorespartida);
	UsuarioConectado(jugador6,socket6,&jugadorespartida);
	write(socket1,respuesta,strlen(respuesta));
	write(socket2,respuesta,strlen(respuesta));
	write(socket3,respuesta,strlen(respuesta));
	write(socket4,respuesta,strlen(respuesta));
	write(socket5,respuesta,strlen(respuesta));
	write(socket6,respuesta,strlen(respuesta));
	
}

// Añadir un usuario a la lista de conectados
int UsuarioConectado(char nombre[20],int socket,TListaConectados*lista)
{
	int i=0;
	int encontrado=0;
	while((i<(lista->num)&&(encontrado==0)))
	{
		if(strcmp(lista->conectados[i].nombre,nombre)==0)
			encontrado=1;
		else
			i=i+1;
	}
	if(encontrado==0)
	{
		if((lista->num)>=100)
			return -1;
		else
		{
			strcpy(lista->conectados[lista->num].nombre,nombre);
			lista->conectados[lista->num].socket=socket;
			lista->num=(lista->num)+1;
			printf("Added user with socket %d\n", socket);
			return 0;
		}
	}	   
}
// Eliminar un usuario de la lista de conectados.
int UsuarioDesonectado(char nombre[20],int socket,TListaConectados*lista)
{
	int i=0;
	int encontrado=0;
	while((i<(lista->num)&&(encontrado==0)))
	{
		if(strcmp(lista->conectados[i].nombre,nombre)==0)
			encontrado=1;
		else
			i=i+1;
	}
	if(encontrado==1)
	{	
		while((i<((lista->num)-1)))
		{
			strcpy(lista->conectados[i].nombre,lista->conectados[i+1].nombre);
			printf("%s",lista->conectados[i].nombre);
			lista->conectados[i].socket = lista->conectados[i+1].socket;
			i = i + 1;
		}
		strcpy (lista->conectados[(lista->num)-1].nombre,"");
		lista->conectados[(lista->num)-1].socket = 0;
		return 0;
	}
	else
	   return -1; 
}
// Devuelve un vector con el nombre de los conectados.
int VerEstadoUsuarios(char nombreconectados[100],TListaConectados*lista)
{
	sprintf(nombreconectados, "%d,", lista->num); 
	int i;
	for (i=0;i<(lista->num);i++) 
	{
		printf("%s",lista->conectados[i].nombre);
		sprintf(nombreconectados,"%s%s,",nombreconectados,lista->conectados[i].nombre);
	}
	printf("Conectados: %s\n", nombreconectados);
}
// Devuelve el socket de un usuario concreto
int EncontrarSocket(char nombre[20],TListaConectados*lista)
{
	int encontrado=0;
	int i=0;
	while((i<(lista->num))&&(encontrado == 0))
	{
		if((strcmp(lista->conectados[i].nombre,nombre)==0))
			encontrado=1;
		else 
			i=i+1;
	}
	if(encontrado)
	{
		return lista->conectados[i].socket;
	}
	else
	   return -1;
}
// Atender peticiones
void *AtenderCliente (void *socket)
{
	int sock_conn;
	int *s;
	s = (int *) socket;
	sock_conn = *s;
	char peticion[512];
	char respuesta[512];
	int ret;
	int err;
	char misConectados [300];
	
	printf("Valor del socket iniciado%d \n",sock_conn);
	int i=0;
	MYSQL *conn;
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	conn = mysql_init(NULL);
	if (conn==NULL) 
	{
		printf ("Error al crear la conexion: %u %s\n", mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	conn = mysql_real_connect (conn, "shiva2.upc.es","root", "mysql", "m3cluedo",0, NULL, 0);
	if (conn==NULL) 
	{
		printf ("Error al inicializar la conexion: %u %s\n", 
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	int terminar = 0;
	while(terminar != 1)
	{	
		ret=read(sock_conn,peticion, sizeof(peticion));
		printf("Recibido\n");
		peticion[ret]='\0';
		//Escribimos el nombre en la consola
		printf ("Peticion: %s\n",peticion);
		//Vamos a ver que quieren
		char *p=strtok (peticion, "/");
		int codigo = atoi(p);
		printf("Codigo: %d\n",codigo);
		//Acabar 
		if (codigo==0)
		{
			terminar = 1; 
			mysql_close(conn);
		}
		//Dime tus amigos
		else if (codigo == 1)
		{
			p=strtok(NULL,"/");
			char friends[512];
			char consulta[80];
			int err;
			strcpy (consulta,"SELECT FRIENDS FROM PLAYER WHERE PLAYER.ID = '"); 
			strcat (consulta, p);
			strcat (consulta,"'");
			printf("%s\n",consulta);
 
			err = mysql_query (conn, consulta); 
			printf("Error = %d\n", err);
			if (err!=0) 
			{
				printf ("Error al consultar datos de la base %u %s\n",
						mysql_errno(conn), mysql_error(conn));
				exit (1);
			}

			resultado = mysql_store_result (conn); 
			row = mysql_fetch_row (resultado);
			if (row == NULL)
			{
				printf ("No se han obtenido datos en la consulta\n");
			}
			else 
				sprintf(respuesta,"%s,",row[0]);	
			printf("respuesta: %s\n", respuesta);
			write (sock_conn,respuesta,strlen(respuesta));
		}
		//
		else if (codigo ==2)
		{
			p=strtok(NULL,"/");
			char player[60];
			int ganadas = 0;
			int jugadas = 0;
			float porcentaje = 0;
			char consulta[80];
			int err;
			
			strcpy(player,p);
			strcpy (consulta,"SELECT PARTICIPATION.GAME FROM PARTICIPATION WHERE PARTICIPATION.POSITION = 1 AND PARTICIPATION.PLAYER ='"); 
			strcat (consulta, player);
			strcat (consulta,"'");
			// hacemos la consulta 
			err=mysql_query (conn, consulta); 
			if (err!=0) 
			{
				printf ("Error al consultar datos de la base %u %s\n",
						mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			//recogemos el resultado de la consulta 
			
			resultado = mysql_store_result (conn); 
			row = mysql_fetch_row (resultado);
			if (row == NULL)
				printf ("No se han obtenido datos en la consulta\n");
			else
			{
				
				while (row!= NULL)
				{
					ganadas++;
					row=mysql_fetch_row(resultado);
				}
			}
			strcpy (consulta,"SELECT PARTICIPATION.GAME FROM PARTICIPATION WHERE PARTICIPATION.PLAYER ='"); 
			strcat (consulta, player);
			strcat (consulta,"'");
			// hacemos la consulta 
			err=mysql_query (conn, consulta); 
			if (err!=0) 
			{
				printf ("Error al consultar datos de la base %u %s\n",
						mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			//recogemos el resultado de la consulta 
			resultado = mysql_store_result (conn); 
			row = mysql_fetch_row (resultado);
			if (row == NULL)
				printf ("No se han obtenido datos en la consulta\n");
			else
			{
				
				while (row!= NULL)
				{
					jugadas++;
					row=mysql_fetch_row(resultado);
				}
			}
			porcentaje=(ganadas*100.0)/jugadas;
			printf("%s ha ganado el %f por ciento de las partidas. Ha ganado %d partidas de las %d que ha jugado\n", player, porcentaje, ganadas, jugadas);
			sprintf(respuesta,"%f",porcentaje);
			write (sock_conn,respuesta,strlen(respuesta));
		}
		else if (codigo ==3)
		{
			
			p=strtok(NULL,"/");
			char player[60];
			int ganadas = 0;
			char consulta[80];
			int err;
			
			printf("%s\n", p);
			strcpy(player,p);
			strcpy (consulta,"SELECT PARTICIPATION.GAME FROM PARTICIPATION WHERE PARTICIPATION.POSITION = 1 AND PARTICIPATION.PLAYER ='"); 
			strcat (consulta, player);
			strcat (consulta,"'");
			// hacemos la consulta 
			err = mysql_query (conn, consulta); 
			if (err!=0) 
			{
				printf ("Error al consultar datos de la base %u %s\n",
						mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			//recogemos el resultado de la consulta 
			resultado = mysql_store_result (conn); 
			row = mysql_fetch_row (resultado);
			if (row == NULL)
				printf ("No se han obtenido datos en la consulta\n");
			else
			{
				while (row!= NULL)
				{
					ganadas++;
					row=mysql_fetch_row(resultado);
				}
			}
			printf("%s ha ganado %d partidas\n", player, ganadas);
			sprintf(respuesta,"%d",ganadas);
			write (sock_conn,respuesta,strlen(respuesta));
		}
		
		else if (codigo == 4)
		{
			p=strtok(NULL,"/");
			int err;
			char player[60];
			int jugadas = 0;
			char consulta[80];
			
			printf("%s\n", p);
			strcpy(player,p);
			strcpy (consulta,"SELECT PARTICIPATION.GAME FROM PARTICIPATION WHERE PARTICIPATION.PLAYER ='"); 
			strcat (consulta, player);
			strcat (consulta,"'");

			err=mysql_query (conn, consulta); 
			if (err!=0) 
			{
				printf ("Error al consultar datos de la base %u %s\n",
						mysql_errno(conn), mysql_error(conn));
				exit (1);
			}

			resultado = mysql_store_result (conn); 
			row = mysql_fetch_row (resultado);
			if (row == NULL)
				printf ("No se han obtenido datos en la consulta\n");
			else
			{
				while (row!= NULL)
				{
					jugadas++;
					row=mysql_fetch_row(resultado);
				}
			}
			printf("%s ha jugado %d partidas\n", player, jugadas);
			sprintf(respuesta,"%d",jugadas);
			write (sock_conn,respuesta,strlen(respuesta));
		}
		
		//Conectar
		else if (codigo == 6)
		{
			p=strtok(NULL,"/");
			char user[100];
			char password[100];
			char consulta[80];
			int err;
			
			strcpy(user,p);
			p=strtok(NULL,"/");
			strcpy(password,p);
			strcpy (consulta,"INSERT INTO PLAYER VALUES('"); 
			strcat (consulta, user);
			strcat (consulta,"','");
			strcat (consulta, password);
			strcat (consulta,"','-/-/-');");
			err = mysql_query (conn, consulta); 
			if (err!=0) 
			{
				printf ("Error al consultar datos de la base %u %s\n", mysql_errno(conn), mysql_error(conn));
				sprintf(respuesta,"1 \n");
				exit (1);
			}
			else 
				sprintf(respuesta,"0 \n");
			int num = atoi(respuesta);
			printf("Numero:%d\n", num);
			if(num==1)
			{
				printf("Datos incorrectos \n");
			}
			else
			{
				printf("Cuenta creada correctamente \n");
			}
			strcpy (consulta,"SELECT COUNT(ID) FROM PLAYER WHERE ID = '"); 
			strcat (consulta, user);
			strcat (consulta,"' AND PASS = '");
			strcat (consulta, password);
			strcat (consulta,"';");
			printf("%s", consulta);
			err = mysql_query (conn, consulta); 
			if (err!=0) 
			{
				printf ("Error al consultar datos de la base %u %s\n", mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			resultado = mysql_store_result (conn); 
			row = mysql_fetch_row (resultado);
			if (row == NULL)
				printf ("No se han obtenido datos en la consulta\n");
			else
			{
				while (row!= NULL)
				{
					sprintf(respuesta, "%s \n",row[0]);
					row=mysql_fetch_row(resultado);
				}
				int num= atoi(respuesta);
				printf("%d", num);
				if (num==1)
				{			
					pthread_mutex_lock(&mutex);
					UsuarioConectado(user,sock_conn,&lista);
					pthread_mutex_unlock(&mutex);
					char conectados[512];
					pthread_mutex_lock(&mutex);
					VerEstadoUsuarios(conectados,&lista);
					pthread_mutex_unlock(&mutex);
					sprintf(respuesta,"3/%s",conectados);
					printf("Respuesta: %s\n", respuesta);
					int r=0;
					while(r<lista.num)
					{
						write (lista.conectados[r].socket,respuesta,strlen(respuesta));
						r=r+1;
					}
				}
				else
				{
					sprintf(respuesta,"2/2");
				}
				write (sock_conn,respuesta,strlen(respuesta));
			}

		}
		// Actualizar lista Conectados
		else if (codigo == 7)
		{
			p=strtok(NULL,"/");
			char conectados[512];
			pthread_mutex_lock(&mutex);
			VerEstadoUsuarios(conectados,&lista);
			pthread_mutex_unlock(&mutex);
			sprintf(respuesta,"3/%s",conectados);
			int r=0;
			while(r<lista.num)
			{
				write (lista.conectados[r].socket,respuesta,strlen(respuesta));
				r=r+1;
			} 
		}
		
		else if (codigo==8)
		{
			char consulta[100];
			char player[20];
			p=strtok(NULL, "/");
			strcpy(player, p);
			p=strtok(NULL, "/");
			int j=1;
			while (p != NULL)
			{
				sprintf(consulta, "4/%s/%s", player, p);
				printf("Consulta: %s\n", consulta);
				write(EncontrarSocket(p, &lista), consulta, strlen(consulta));
				p=strtok(NULL, "/");
				j++;
			}
				
		}
		
		else if(codigo == 9)
		{
			char consulta[100];
			char invitador[20];
			char invitado[20];
			p=strtok(NULL, "/");
			strcpy(invitador, p);
			p=strtok(NULL, "/");
			strcpy(invitado, p);
			sprintf(consulta, "5/%s, %s ha aceptado tu invitacion\n", invitador, invitado);
			write(EncontrarSocket(invitador, &lista), consulta, strlen(consulta));
		}
		
		else if(codigo == 10)
		{
			char consulta[100];
			char invitador[20];
			char invitado[20];
			p=strtok(NULL, "/");
			strcpy(invitador, p);
			p=strtok(NULL, "/");
			strcpy(invitado, p);
			sprintf(consulta, "6/%s, %s ha rechazado tu invitacion\n", invitador, invitado);
			write(EncontrarSocket(invitador, &lista), consulta, strlen(consulta));
		}
		
		// Iniciar partida
		else if (codigo == 11)
		{
			char jugador1[20];
			char jugador2[20];
			char jugador3[20];
			char jugador4[20];
			char jugador5[20];
			char jugador6[20];
			p=strtok(NULL,",");
			strcpy(jugador1,p);
			printf("1\n");
			p=strtok(NULL,",");
			strcpy(jugador2,p);
			printf("2\n");
			p=strtok(NULL,",");
			strcpy(jugador3,p);
			printf("3\n");
			p=strtok(NULL,",");
			strcpy(jugador4,p);
			printf("4\n");
			p=strtok(NULL,",");
			strcpy(jugador5,p);
			printf("5\n");
			p=strtok(NULL,",");
			strcpy(jugador6,p);
			printf("6\n");
			CrearPartida(&lista,respuesta,jugador1,jugador2,jugador3,jugador4,jugador5,jugador6);
			printf("Lista creada %s\n", respuesta);
			write (sock_conn,respuesta,strlen(respuesta));
		}
		
		else if (codigo == 12)
		{
			p=strtok(NULL,"/");
			char chat[400];
			char consulta[100];
			char nombrejugador[100];
			strcpy(nombrejugador,p);
			p=strtok(NULL,"/");
			strcpy(chat,p);
			sprintf(consulta, "7/%s/%s\n", nombrejugador, chat);
			printf("Consulta: %s\n", consulta);
			int i=0;
			while(i<lista.num)
			{
				write(lista.conectados[i].socket, consulta, strlen(consulta));
				i=i+1;
			}
		}
	}
		close(sock_conn);
}
int main(int argc, char *argv[])
{	
		int sock_conn, sock_listen;
		struct sockaddr_in serv_adr;

		if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
			printf("Error creant socket\n");
		memset(&serv_adr, 0, sizeof(serv_adr));
		serv_adr.sin_family = AF_INET;
		serv_adr.sin_addr.s_addr = htonl(INADDR_ANY); 
		serv_adr.sin_port = htons(50011);
		if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
			printf("Error al bind\n");
		if (listen(sock_listen, 10) < 0)
			printf("Error en el listen\n");
		int i=0;
		int r;
		int sockets[100];
		pthread_t thread[100];
		for(;;)
		{
			printf("Preparado para recibir la peticion\n");
			sock_conn = accept(sock_listen, NULL, NULL);
			printf("He recibido la conexion \n");	
			
			
			sockets[i] = sock_conn;		
			pthread_create (&thread[i], NULL, AtenderCliente,&sockets[i]);
			i++;
		}
}


