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
	MYSQL *conn;
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	//int socket_conn = * (int *) socket;
	int terminar = 0;
	while(terminar != 1){	
		ret=read(sock_conn,peticion, sizeof(peticion));
		printf("Recibido\n");
		peticion[ret]='\0';
		//Escribimos el nombre en la consola
		printf ("Peticion: %s\n",peticion);
		//Vamos a ver que quieren
		char *p=strtok (peticion, "/");
		int codigo = atoi (p);
		if (codigo != 0)
			p=strtok(NULL,"/");
		printf("Codigo: %d \n",codigo);
		if (codigo == 5)
		{
			char user[100];
			char password[100];
			char consulta[80];
			strcpy(user,p);
			p=strtok(NULL,"/");
			strcpy(password,p);
			// construimos la consulta SQL
			strcpy (consulta,"INSERT INTO PLAYER VALUES('"); 
			strcat (consulta, user);
			strcat (consulta,"','");
			strcat (consulta, password);
			strcat (consulta,"','-/-/-');");
			// hacemos la consulta 
			err = mysql_query (conn, consulta); 
			if (err!=0) 
			{
				printf ("Error al consultar datos de la base %u %s\n",
						mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			
		}
		else if (codigo == 1)
		{
			char friends[512];
			char consulta[80];
			
			// construimos la consulta SQL
			strcpy (consulta,"SELECT FRIENDS FROM PLAYER WHERE PLAYER.ID = '"); 
			strcat (consulta, p);
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
			{
				printf ("No se han obtenido datos en la consulta\n");
			}
			else 
				sprintf(respuesta,"%s,",row[0]);			
		}
		else if (codigo ==2)
		{
			char player[60];
			int ganadas = 0;
			int jugadas = 0;
			float porcentaje = 0;
			char consulta[80];
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
		}
		else if (codigo ==3)
		{
			char player[60];
			int ganadas = 0;
			char consulta[80];
			printf("%s\n", p);
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
			printf("%s ha ganado %d partidas\n", player, ganadas);
			sprintf(respuesta,"%d",ganadas);
		}
		
		else if (codigo == 4)
		{
			char player[60];
			int jugadas = 0;
			char consulta[80];
			printf("%s\n", p);
			strcpy(player,p);
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
			printf("%s ha jugado %d partidas\n", player, jugadas);
			sprintf(respuesta,"%d",jugadas);
		}
		else if(codigo == 0)
				 terminar = 1;
		
		write(sock_conn,respuesta,strlen(respuesta));
	}
	
	close(sock_conn);  
	//Necessari per a que el client detecti EOF 
	// cerrar la conexion con el servidor MYSQL
	mysql_close (conn);
	exit(0);
}
int main(int argc, char *argv[])
{	
	MYSQL *conn;
	int err;
	// Estructura especial para almacenar resultados de consultas 
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	//Creamos una conexion al servidor MYSQL 
	conn = mysql_init(NULL);
	if (conn==NULL) 
	{
		printf ("Error al crear la conexion: %u %s\n", mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	//inicializar la conexion
	conn = mysql_real_connect (conn, "localhost","root", "mysql", "cluedo",0, NULL, 0);
	if (conn==NULL) 
	{
		printf ("Error al inicializar la conexion: %u %s\n", 
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	int sock_conn, sock_listen;
	struct sockaddr_in serv_adr;
	
	
	// INICIALITZACIONS
	// Obrim el socket
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant socket\n");
	// Fem el bind al port
	// inicialitza a zero serv_addr
	memset(&serv_adr, 0, sizeof(serv_adr));
	serv_adr.sin_family = AF_INET;
	//El fica IP local 
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY); 
	//Indiquem per quin port entra el client
	serv_adr.sin_port = htons(9080);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf("Error al bind\n");
	// Limitem el nombre de connexions pendents
	if (listen(sock_listen, 10) < 0)
		printf("Error en el listen\n");
	// acceptem connexio d'un client￧
	int i;
	int sockets[100];
	pthread_t thread[100];
	for(;;)
	{
		printf("Preparado para recibir la peticion\n");
		sock_conn = accept(sock_listen, NULL, NULL);
		printf("He recibido la conexion \n");
		
		sockets[i] = sock_conn;
		//sock_conn es el socket que usaremos en este cliente
		// Crear thread y decirle lo que tiene que hacer
		pthread_create (&thread[i], NULL, AtenderCliente,&sockets[i]);
	}
}

