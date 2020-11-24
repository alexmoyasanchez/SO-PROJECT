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

typedef struct{
	char nombre[20];
	int socket;
}Conectado;

typedef struct {
	Conectado conectados[100];
	int num;
}ListaConectados;

pthread_mutex_t mutex = PTHREAD_MUTEX_INITIALIZER;

int i;

int Pon (ListaConectados *lista, char nombre[20], int socket){
	//Anade conectados a la lista
	if(lista ->num ==100)
		return -1;
	else{
		strcpy(lista->conectados[lista->num].nombre, nombre);
		lista->conectados[lista->num].socket = socket;
		lista->num ++;
		return 0;
	}
}


void DameConectados (ListaConectados *lista, char conectados[300]){
	//Pone en un vector los nombres de conectados separados por una bcoma
	//Primero pone el número de conectados. Ej: 3,Maria,Juan,Pedro
	sprintf (conectados, "%d", lista->num);
	int i;
	for (i=0; i<lista->num; i++)
		sprintf (conectados, "%s,%s", conectados, lista->conectados[i].nombre);
}

int DamePosicion (ListaConectados *lista, char nombre[20]){
	//Devuelve la posicion del nombre introducido que esta en la lista
	int i=0;
	int encontrado=0;
	while ((i<lista->num)&&!encontrado){
		if (strcmp(lista->conectados[i].nombre,nombre)==0)
			encontrado =1;
		else
			i=i+1;
	}
	if (encontrado)
		return i;
	else
		return -1;
}

int Elimina (ListaConectados *lista, char nombre[20]){
	//Elimina en nombre de la lista de conectados
	int pos = DamePosicion (lista, nombre);
	if (pos==-1)
		return -1;
	else {
		int i;
		for (i= pos; i<lista->num-1; i++)
		{
			lista-> conectados [i] = lista->conectados[i+1];
			//strcpy(lista->conectados[i].nombre = lista->conectados[i+1].nombre, nombre);
			//lista->conectados[i].socket =lista->conectados[i+1].socket;
		}
		lista ->num--;
		return 0;
	}
}

ListaConectados miLista;
int cont=0;
int sockets[100];


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
	int terminar = 0;
	while(terminar != 1){	
		
		ret=read(sock_conn,peticion, sizeof(peticion));
		printf("Recibido\n");
		peticion[ret]='\0';
		printf ("Peticion: %s\n",peticion);
		char *p=strtok (peticion, "/");
		int codigo = atoi (p);
		if (codigo != 0)
			p=strtok(NULL,"/");
		if ((codigo ==1)||(codigo==2)||(codigo==3)||(codigo ==4)||(codigo==6)||(codigo==7)||(codigo==8))
		{
			pthread_mutex_lock( &mutex ); //No me interrumpas ahora
			DameConectados (&miLista, misConectados);
			pthread_mutex_unlock( &mutex); //ya puedes interrumpirme
			 //notificar a todos los clientes conectados
			char notificacion[200];
			sprintf (notificacion, "9/%s",misConectados);
			printf("i: %d\n", i);
			int j;
			for (j=0; j< i; j++)
				write (sockets[j],notificacion, strlen(notificacion));
			
		}
		printf("Codigo: %d \n",codigo);
		if (codigo == 5)
		{
			MYSQL_RES *resultado;
			MYSQL_ROW row;
			MYSQL *conn;
			conn = mysql_init(NULL);
			if (conn==NULL) 
			{
				printf ("Error al crear la conexion: %u %s\n", mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			conn = mysql_real_connect (conn, "localhost","root", "mysql", "cluedo",0, NULL, 0);
			if (conn==NULL) 
			{
				printf ("Error al inicializar la conexion: %u %s\n", 
						mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			char user[100];
			char password[100];
			char consulta[80];
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
				printf ("Error al consultar datos de la base %u %s\n",
						mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			mysql_close(conn);
		}
		else if (codigo == 1)
		{
			MYSQL *conn;
			MYSQL_RES *resultado;
			MYSQL_ROW row;
			char friends[512];
			char consulta[80];
			int err;
			conn = mysql_init(NULL);
			if (conn==NULL) 
			{
				printf ("Error al crear la conexion: %u %s\n", mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			conn = mysql_real_connect (conn, "localhost","root", "mysql", "cluedo",0, NULL, 0);
			if (conn==NULL) 
			{
				printf ("Error al inicializar la conexion: %u %s\n", 
						mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			strcpy (consulta,"SELECT FRIENDS FROM PLAYER WHERE PLAYER.ID = '"); 
			strcat (consulta, p);
			strcat (consulta,"'");
			printf("%s\n",consulta);
			err=mysql_query (conn, consulta); 
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
				sprintf(respuesta,"1/%s,",row[0]);	
			printf("respuesta: %s\n", respuesta);
			mysql_close(conn);
		}
		else if (codigo ==2)
		{
			MYSQL_RES *resultado;
			MYSQL_ROW row;
			MYSQL *conn;
			char player[60];
			int ganadas = 0;
			int jugadas = 0;
			float porcentaje = 0;
			char consulta[80];
			conn = mysql_init(NULL);
			if (conn==NULL) 
			{
				printf ("Error al crear la conexion: %u %s\n", mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			conn = mysql_real_connect (conn, "localhost","root", "mysql", "cluedo",0, NULL, 0);
			if (conn==NULL) 
			{
				printf ("Error al inicializar la conexion: %u %s\n", 
						mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			strcpy(player,p);
			strcpy (consulta,"SELECT PARTICIPATION.GAME FROM PARTICIPATION WHERE PARTICIPATION.POSITION = 1 AND PARTICIPATION.PLAYER ='"); 
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
					ganadas++;
					row=mysql_fetch_row(resultado);
				}
			}
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
			porcentaje=(ganadas*100.0)/jugadas;
			printf("%s ha ganado el %f por ciento de las partidas. Ha ganado %d partidas de las %d que ha jugado\n", player, porcentaje, ganadas, jugadas);
			sprintf(respuesta,"2/%f",porcentaje);
			mysql_close (conn);
		}
		else if (codigo ==3)
		{
			MYSQL_RES *resultado;
			MYSQL_ROW row;
			MYSQL *conn;
			char player[60];
			int ganadas = 0;
			char consulta[80];
			conn = mysql_init(NULL);
			if (conn==NULL) 
			{
				printf ("Error al crear la conexion: %u %s\n", mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			conn = mysql_real_connect (conn, "localhost","root", "mysql", "cluedo",0, NULL, 0);
			if (conn==NULL) 
			{
				printf ("Error al inicializar la conexion: %u %s\n", 
						mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			printf("%s\n", p);
			strcpy(player,p);
			strcpy (consulta,"SELECT PARTICIPATION.GAME FROM PARTICIPATION WHERE PARTICIPATION.POSITION = 1 AND PARTICIPATION.PLAYER ='"); 
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
					ganadas++;
					row=mysql_fetch_row(resultado);
				}
			}
			printf("%s ha ganado %d partidas\n", player, ganadas);
			sprintf(respuesta,"3/%d",ganadas);
			mysql_close (conn);
		}
		
		else if (codigo == 4)
		{
			MYSQL_RES *resultado;
			MYSQL_ROW row;
			MYSQL *conn;
			char player[60];
			int jugadas = 0;
			char consulta[80];
			conn = mysql_init(NULL);
			if (conn==NULL) 
			{
				printf ("Error al crear la conexion: %u %s\n", mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			conn = mysql_real_connect (conn, "localhost","root", "mysql", "cluedo",0, NULL, 0);
			if (conn==NULL) 
			{
				printf ("Error al inicializar la conexion: %u %s\n", 
						mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
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
			sprintf(respuesta,"4/%d",jugadas);
			mysql_close (conn);
		}
		
		else if (codigo == 6)
		{
			MYSQL_RES *resultado;
			MYSQL_ROW row;
			MYSQL *conn;
			conn = mysql_init(NULL);
			if (conn==NULL) 
			{
				printf ("Error al crear la conexion: %u %s\n", mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			conn = mysql_real_connect (conn, "localhost","root", "mysql", "cluedo",0, NULL, 0);
			if (conn==NULL) 
			{
				printf ("Error al inicializar la conexion: %u %s\n", 
						mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			DameConectados (&miLista, misConectados);
			sprintf(respuesta,"6/%s",misConectados);
			mysql_close(conn);
		}
		
		else if (codigo == 7)
		{
			printf("Respuesta: %s\n", respuesta);
			MYSQL_RES *resultado;
			MYSQL_ROW row;
			MYSQL *conn;
			conn = mysql_init(NULL);
			if (conn==NULL) 
			{
				printf ("Error al crear la conexion: %u %s\n", mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			conn = mysql_real_connect (conn, "localhost","root", "mysql", "cluedo",0, NULL, 0);
			if (conn==NULL) 
			{
				printf ("Error al inicializar la conexion: %u %s\n", 
						mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			int s = Pon(&miLista, p, cont);
			DameConectados (&miLista, misConectados);
			char conectados[500];
			char *q = strtok (misConectados, ",");
			int n= atoi (q);
			q=strtok(NULL, ",");
			for (int i=0; i<n; i++){
				sprintf(conectados, "%s\n%s", conectados, q);
				q=strtok(NULL, ",");
			};
			cont=n;
			printf("Conectados:%s\n", conectados);
			strcpy(respuesta, "7/");
			strcat(respuesta, conectados);
			mysql_close(conn);
		}
		else if (codigo == 8)
		{
			printf("Respuesta: %s\n", respuesta);
			MYSQL_RES *resultado;
			MYSQL_ROW row;
			MYSQL *conn;
			conn = mysql_init(NULL);
			if (conn==NULL) 
			{
				printf ("Error al crear la conexion: %u %s\n", mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			conn = mysql_real_connect (conn, "localhost","root", "mysql", "cluedo",0, NULL, 0);
			if (conn==NULL) 
			{
				printf ("Error al inicializar la conexion: %u %s\n", 
						mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			int s = Elimina(&miLista, p);
			DameConectados (&miLista, misConectados);
			char conectados[500];
			char *q = strtok (misConectados, ",");
			int n= atoi (q);
			q=strtok(NULL, ",");
			for (int i=0; i<n; i++){
				sprintf(conectados, "%s\n%s", conectados, q);
				q=strtok(NULL, ",");
			};
			cont=n;
			printf("Conectados:%s\n", conectados);
			strcpy(respuesta, "8/");
			strcat(respuesta, conectados);
			mysql_close(conn);
		}
		else if(codigo == 0)
			terminar = 1;
		
		write(sock_conn,respuesta,strlen(respuesta));
	}
	exit(0);
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
	serv_adr.sin_port = htons(9080);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf("Error al bind\n");
	if (listen(sock_listen, 10) < 0)
		printf("Error en el listen\n");
	i=0;
	int r;
	int sockets[100];
	pthread_t thread[100];
	for(;;)
	{
		printf("Preparado para recibir la peticion\n");
		sock_conn = accept(sock_listen, NULL, NULL);
		printf("He recibido la conexion \n");	
		
		sockets[i] = sock_conn;		
		pthread_create (&thread[i], NULL, AtenderCliente, &sockets[i]);
		i++;
	}
}
