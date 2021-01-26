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
#include <stdbool.h>

typedef struct {
	char ficha[20];
	char cartas[50];
	char nombre[20];
	int socket;
}Tconectado;

typedef struct{
	int num;
	char nombrepartida[20];
	Tconectado conectados[100];
}TListaConectados;

typedef struct{
	int num;
	TListaConectados partidas[100];
}TListaPartidas;

TListaConectados lista;
TListaConectados jugadoresInvitados;
TListaConectados jugadorespartida;
TListaPartidas listapartidas;
pthread_mutex_t mutex=PTHREAD_MUTEX_INITIALIZER;
int invitadosGrupo = 0;
bool empiezaLaPartida = false;
char fichas[50];
int turnogeneral;
int cartaasesino;
int cartaarma;
int cartahab;



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
// Añadir una partida nueva a la lista de partidas
int nuevaPartida(char nombre[20],int socket,TListaConectados*lista)
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
	int turno = 0;
	
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
			char consulta[200];
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
			char consulta[200];
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
			char consulta[200];
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
		//Invitar Amigos
		//Recibe 8/jugador1/jugador2/jugadorN
		//Rellena la lista de jugadores invitados y mandamos invitaciones a los jugadores que hemos escogido.
		else if (codigo==8)
		{
			char consulta[100];
			char player[20];
			p=strtok(NULL, "/");
			strcpy(player, p);
			p=strtok(NULL, "/");
			while(p != NULL) 
			{
				UsuarioConectado(p, EncontrarSocket(p,&lista), &jugadoresInvitados);
				p=strtok(NULL, "/");
			}
			int j=0;
			while(j<jugadoresInvitados.num)
			{
				sprintf(consulta, "4/%s/%s te ha invitado a jugar ¿Aceptas?", player, player);
				write(jugadoresInvitados.conectados[i].socket, consulta, strlen(consulta));
				j=j+1;
			}
			UsuarioConectado(player, EncontrarSocket(player,&lista), &jugadorespartida);
		}
		//Preparar el grupo de la partida
		else if(codigo == 9)
		{
			char consulta[100];
			char invitador[20];
			char invitado[20];
			char confirmacion[20];
			p=strtok(NULL, "/");
			strcpy(invitador, p);
			p=strtok(NULL, "/");
			strcpy(invitado, p);
			p=strtok(NULL, "/");
			strcpy(confirmacion, p);
			if((strcmp(confirmacion,"yes")==0))
			{
				UsuarioConectado(invitado, EncontrarSocket(invitado,&lista), &jugadorespartida);
				sprintf(consulta,"5/");
				int i=0;
				while(i<jugadorespartida.num)
				{
					strcat(consulta,jugadorespartida.conectados[i].nombre);
					strcat(consulta,"/");
					i=i+1;
				}
				printf("Respuesta:%s",consulta);
				int j=0;
				while(j<jugadorespartida.num)
				{
					write(jugadorespartida.conectados[j].socket, consulta, strlen(consulta));
					j=j+1;
				}
			}
			else
			{
				sprintf(consulta, "6/%s", invitado);
				write(EncontrarSocket(invitador,&lista), consulta, strlen(consulta));
			}
			
		}
		else if(codigo == 10)
		{
			char consulta[100];
			int turno;
			char bloqueos[50];
			p=strtok(NULL, "/");
			turno=atoi(p);
			p=strtok(NULL, "/");
			strcpy(bloqueos, p);
			if(turno<jugadorespartida.num)
			{
				sprintf(consulta,"9/%d/%s/padding",turno,bloqueos);
				write(jugadorespartida.conectados[turno].socket, consulta, strlen(consulta));
			}
			//Preparar las fichas y las cartas de cada jugador
			else
			{
				turnogeneral=jugadorespartida.num;
				strcpy(fichas,bloqueos);
				printf("%s",fichas);
				int cartas[21];
				printf("Empieza la partida");
				char consulta[100];
				cartas[0] = rand()%(6+1);
				cartas[1] = rand()%(12+7);
				cartas[2] = rand()%(21+13);
				cartaasesino=cartas[0];
				cartaarma=cartas[1];
				cartahab=cartas[2];
				int j=0;
				
				for(int i=3;i<21;i++)
				{
					int num = rand()%(21+1);
					if(i>0)
					{  
						for(int j=0; j < i; j++) 
						{
							if(num==cartas[j])
							{
								num = rand()%(21+1);
								j=-1;                         
							}
						}
					}
					cartas[i]=num;
				}
				if(jugadorespartida.num == 2)
				{
					for (int j=3; j<12; j++)
						{
							char tmp[50];
							sprintf(tmp,"%d",cartas[j]);
							char separador[10];
							sprintf(separador,",");
							strcat(jugadorespartida.conectados[0].cartas,tmp);
							strcat(jugadorespartida.conectados[0].cartas,separador);
						}
					for (int j=12; j<21; j++)
						{
							char tmp[50];
							sprintf(tmp,"%d",cartas[j]);
							char separador[10];
							sprintf(separador,",");
							strcat(jugadorespartida.conectados[1].cartas,tmp);
							strcat(jugadorespartida.conectados[1].cartas,separador);
						}
				}
				else if(jugadorespartida.num == 3)
				{
					for (int j=3; j<9; j++)
						{
						char tmp[50];
						sprintf(tmp,"%d",cartas[j]);
						char separador[10];
						sprintf(separador,",");
						strcat(jugadorespartida.conectados[0].cartas,tmp);
						strcat(jugadorespartida.conectados[0].cartas,separador);
						}
					for (int j=9; j<15; j++)
						{
						char tmp[50];
						sprintf(tmp,"%d",cartas[j]);
						char separador[10];
						sprintf(separador,",");
						strcat(jugadorespartida.conectados[1].cartas,tmp);
						strcat(jugadorespartida.conectados[1].cartas,separador);
						}
					for (int j=15; j<21; j++)
						{
						char tmp[50];
						sprintf(tmp,"%d",cartas[j]);
						char separador[10];
						sprintf(separador,",");
						strcat(jugadorespartida.conectados[2].cartas,tmp);
						strcat(jugadorespartida.conectados[2].cartas,separador);
						}
					
				}
				else if(jugadorespartida.num == 4)
				{
						for (int j=3; j<7; j++)
						{
							
							char tmp[50];
							sprintf(tmp,"%d",cartas[j]);
							char separador[10];
							sprintf(separador,",");
							strcat(jugadorespartida.conectados[0].cartas,tmp);
							strcat(jugadorespartida.conectados[0].cartas,separador);
						}
						for (int j=7; j<11; j++)
						{
							
							char tmp[50];
							sprintf(tmp,"%d",cartas[j]);
							char separador[10];
							sprintf(separador,",");
							strcat(jugadorespartida.conectados[1].cartas,tmp);
							strcat(jugadorespartida.conectados[1].cartas,separador);
						}
						for (int j=11; j<16; j++)
						{
							
							char tmp[50];
							sprintf(tmp,"%d",cartas[j]);
							char separador[10];
							sprintf(separador,",");
							strcat(jugadorespartida.conectados[2].cartas,tmp);
							strcat(jugadorespartida.conectados[2].cartas,separador);
						}
						for (int j=16; j<21; j++)
						{
							
							char tmp[50];
							sprintf(tmp,"%d",cartas[j]);
							char separador[10];
							sprintf(separador,",");
							strcat(jugadorespartida.conectados[3].cartas,tmp);
							strcat(jugadorespartida.conectados[3].cartas,separador);
						}
				}	
				else if(jugadorespartida.num == 5)
				{
						for (int j=3; j<6; j++)
						{
							char tmp[50];
							sprintf(tmp,"%d",cartas[j]);
							char separador[10];
							sprintf(separador,",");
							strcat(jugadorespartida.conectados[0].cartas,tmp);
							strcat(jugadorespartida.conectados[0].cartas,separador);
						}
						for (int j=6; j<9; j++)
						{
							char tmp[50];
							sprintf(tmp,"%d",cartas[j]);
							char separador[10];
							sprintf(separador,",");
							strcat(jugadorespartida.conectados[1].cartas,tmp);
							strcat(jugadorespartida.conectados[1].cartas,separador);
						}
						for (int j=9; j<13; j++)
						{
							char tmp[50];
							sprintf(tmp,"%d",cartas[j]);
							char separador[10];
							sprintf(separador,",");
							strcat(jugadorespartida.conectados[2].cartas,tmp);
							strcat(jugadorespartida.conectados[2].cartas,separador);
						}
						for (int j=13; j<17; j++)
						{
							char tmp[50];
							sprintf(tmp,"%d",cartas[j]);
							char separador[10];
							sprintf(separador,",");
							strcat(jugadorespartida.conectados[3].cartas,tmp);
							strcat(jugadorespartida.conectados[3].cartas,separador);
						}
						for (int j=17; j<21; j++)
						{
							char tmp[50];
							sprintf(tmp,"%d",cartas[j]);
							char separador[10];
							sprintf(separador,",");
							strcat(jugadorespartida.conectados[4].cartas,tmp);
							strcat(jugadorespartida.conectados[4].cartas,separador);
						}
				}	
				else
				{
						for (int j=3; j<6; j++)
						{
							char tmp[50];
							sprintf(tmp,"%d",cartas[j]);
							char separador[10];
							sprintf(separador,",");
							strcat(jugadorespartida.conectados[0].cartas,tmp);
							strcat(jugadorespartida.conectados[0].cartas,separador);
						}
						for (int j=6; j<9; j++)
						{
							char tmp[50];
							sprintf(tmp,"%d",cartas[j]);
							char separador[10];
							sprintf(separador,",");
							strcat(jugadorespartida.conectados[1].cartas,tmp);
							strcat(jugadorespartida.conectados[1].cartas,separador);
						}
						for (int j=9; j<12; j++)
						{
							char tmp[50];
							sprintf(tmp,"%d",cartas[j]);
							char separador[10];
							sprintf(separador,",");
							strcat(jugadorespartida.conectados[2].cartas,tmp);
							strcat(jugadorespartida.conectados[2].cartas,separador);
						}
						for (int j=12; j<15; j++)
						{
							char tmp[50];
							sprintf(tmp,"%d",cartas[j]);
							char separador[10];
							sprintf(separador,",");
							strcat(jugadorespartida.conectados[3].cartas,tmp);
							strcat(jugadorespartida.conectados[3].cartas,separador);
						}
						for (int j=15; j<18; j++)
						{							
							char tmp[50];
							sprintf(tmp,"%d",cartas[j]);
							char separador[10];
							sprintf(separador,",");
							strcat(jugadorespartida.conectados[4].cartas,tmp);
							strcat(jugadorespartida.conectados[4].cartas,separador);
						}
						for (int j=18; j<21; j++)
						{
							char tmp[50];
							sprintf(tmp,"%d",cartas[j]);
							char separador[10];
							sprintf(separador,",");
							strcat(jugadorespartida.conectados[5].cartas,tmp);
							strcat(jugadorespartida.conectados[5].cartas,separador);
						}
				}
				char *q=strtok (fichas, ",");
				strcpy(jugadorespartida.conectados[0].ficha,q);
				printf("ficha0:%s\n", jugadorespartida.conectados[0].ficha);
				for(int i = 1; i<jugadorespartida.num; i++)
				{
					q = strtok(NULL, ",");
					strcpy(jugadorespartida.conectados[i].ficha,q);
					printf("ficha:%s\n", jugadorespartida.conectados[i].ficha);
				}
				int l=0;
				while(l<jugadorespartida.num)
				{
					sprintf(consulta, "8/%s/%s", jugadorespartida.conectados[l].ficha,jugadorespartida.conectados[l].cartas);
					write(jugadorespartida.conectados[l].socket, consulta, strlen(consulta));
					l=l+1;
				}
			}
			
		}
		//Comparar respuesta de otro jugador
		else if (codigo ==11)
		{	
			int r=0;
			p=strtok(NULL,"/");
			char asesino[20];
			char arma[20];
			char habitacion[20];
			int preguntador=atoi(p);
			p=strtok(NULL,"/");
			int respondedor=atoi(p);
			p=strtok(NULL,"/");
			strcpy(asesino,p);
			p=strtok(NULL,"/");
			strcpy(arma,p);
			p=strtok(NULL,"/");
			strcpy(habitacion,p);
			int asesinoencontrado=0;
			int armaencontrada=0;
			int habitacionencontrada=0;
			while((r<(18/jugadorespartida.num))&&(asesinoencontrado==0))
			{
				char tmp[50];
				sprintf(tmp,"%d",jugadorespartida.conectados[respondedor].cartas[r]);
				if(strcmp(tmp,asesino)==0)
					asesinoencontrado=1;
				else
				   r=r+1;
			}
			if(asesinoencontrado==1)
				sprintf(asesino,"%d",jugadorespartida.conectados[respondedor].cartas[r]);
			r=0;
			while((r<(18/jugadorespartida.num))&&(armaencontrada==0))
			{
				char tmp[50];
				sprintf(tmp,"%d",jugadorespartida.conectados[respondedor].cartas[r]);
				if(strcmp(tmp,arma)==0)
					armaencontrada=1;
				else
					r=r+1;
			}
			if(armaencontrada==1)
				sprintf(arma,"%d",jugadorespartida.conectados[respondedor].cartas[r]);
			r=0;
			while((r<(18/jugadorespartida.num))&&(habitacionencontrada==0))
			{
				char tmp[50];
				sprintf(tmp,"%d",jugadorespartida.conectados[respondedor].cartas[r]);
				if(strcmp(tmp,habitacion)==0)
					habitacionencontrada=1;
				else
					r=r+1;
			}
			if(habitacionencontrada==1)
				sprintf(habitacion,"%d",jugadorespartida.conectados[respondedor].cartas[r]);
			char consulta[500];
			sprintf(consulta,"10/%s,%s,%s",asesino,arma,habitacion);
			printf("%s",consulta);
			write(jugadorespartida.conectados[preguntador].socket, consulta, strlen(consulta));
		}
		// Chat 
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
		else if(codigo==13)
		{
			char consulta[500];
			p=strtok(NULL,"/");
			int preguntador=atoi(p);
			p=strtok(NULL,"/");
			int respondedor=atoi(p);
			p=strtok(NULL,"/");
			char pregunta[50];
			strcpy(pregunta,p);
			sprintf(consulta,"10/%s/padding",pregunta);
			write(jugadorespartida.conectados[respondedor].socket,consulta,strlen(consulta));
		}
		//Actualizar + cambiar turno
		else if (codigo ==14)
		{
			char movimientos[100];
			char consulta[500];
			p=strtok(NULL,"/");
			int turnoactual = atoi(p);
			p=strtok(NULL,"/");
			strcpy(movimientos,p);
			turno = (turno + 1)%jugadorespartida.num;
			//sprintf(consulta,"11/%d/%s",turnoactual,movimientos);
			/*for(int i=0;i<jugadorespartida.num;i++)
			{
				printf("Hola hasta la 923");
				write(jugadorespartida.conectados[i].socket, consulta, strlen(consulta));
			}
			if((turnoactual-1)==jugadorespartida.num)
				  turnoactual=0;
			else
				turnoactual=turnoactual+1;*/

			sprintf(consulta,"12/%d/%s",turno,movimientos);
			printf("Consulta: %s\n Socket: %d\n", consulta, jugadorespartida.conectados[turno].socket);
			write(jugadorespartida.conectados[0].socket, consulta, strlen(consulta));
			printf("Consulta: %s\n Socket: %d\n", consulta, jugadorespartida.conectados[0].socket);
			write(jugadorespartida.conectados[1].socket, consulta, strlen(consulta));
			printf("Consulta: %s\n Socket: %d\n", consulta, jugadorespartida.conectados[1].socket);
		}
		else if(codigo==15)
		{
			int r=0;
			p=strtok(NULL,"/");
			int preguntador=atoi(p);
			p=strtok(NULL,"/");
			int respondedor=atoi(p);
			p=strtok(NULL,"/");
			int asesino=atoi(p);
			p=strtok(NULL,"/");
			int arma=atoi(p);
			p=strtok(NULL,"/");
			int habitacion=atoi(p);
			if((asesino==cartaasesino)&&(arma==cartaarma)&&(habitacion==cartahab))
			{
				char consulta[500];
				sprintf(consulta,"16/%d/ganador",preguntador);
				while(r<jugadorespartida.num)
				{
					write(jugadorespartida.conectados[r].socket, consulta, strlen(consulta));
					r=r+1;
				}
			}
			else
			{
				char consulta[500];
				sprintf(consulta,"16/%d/perdedor",preguntador);
					write(jugadorespartida.conectados[preguntador].socket, consulta, strlen(consulta));
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
	serv_adr.sin_port = htons(50010);
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
