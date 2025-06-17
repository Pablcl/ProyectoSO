#include <stdio.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <string.h>
#include <mysql/mysql.h>
#include <pthread.h>
#include <stdbool.h>

typedef struct {
	char nombre[20];
	int socket;
}Conectado;

typedef struct{
	Conectado conectados[100];
	int num;
}ListaConectados;

//Invitar-
typedef struct {
	char invitado[100];//NOMBRE DE LES PERSONES M繶IMS AL MATEIX JOC ES 4.	
}invitados;
typedef struct {
	char anfitrion[100];
	invitados inv[3];
	int numinvitados;
}AnfInv;
//estructura que guarda los nombres de los innvitados e invitador.
typedef struct{
	AnfInv jugadores[100];
	int numjugadores;
}listaPartidas;


//Variables de lista Conectados
ListaConectados milista;
pthread_mutex_t mutex = PTHREAD_MUTEX_INITIALIZER;  // Mutex para sincronizar el acceso a la lista
int numsock; // n鷐eros de sockets
int sockets[100];

//Variables de lista Partidas
listaPartidas milistaP;
//FUNCIONES
int PonConectados (ListaConectados *lista, char nombre[20], int socketreb)
{
	if(lista-> num == 100)
		return -1;
	else{
		strcpy(lista->conectados[lista->num]. nombre, nombre);
		lista->conectados[lista->num].socket = socketreb;
		lista-> num++;
		printf("socket: %d, nombre %s\n", socketreb, nombre);
		return 0;
	}
}

int DamePosicion (ListaConectados *lista, char nombre[20])
{
	int i =0;
	int encontrado =0;
	while ((i<lista-> num)&&!encontrado)
	{
		if (strcmp(lista->conectados[i].nombre, nombre))
			encontrado =1;
		if (!encontrado )
			i=i+1;
	}
	if (encontrado)
	{
		return i;
	}
	else 
		return -1;
}

int EliminarConectados(ListaConectados *lista, char nombre[20])
{
	int pos = DamePosicion (lista, nombre);
	if (pos == -1)
	{
		return -1;
	}
	else
	{
		int i;
		for(i=pos; i<lista->num-1; i++)
		{
			lista->conectados[i] = lista->conectados[i+1];
			/*			strcpy(lista.conectados[i].nombre, lista.conectados[i+1].nombre);*/
			/*			lista-> conectados[i].socket = lista-> conectados[i+1].socket ;*/
		}
		lista-> num--;
		return 0;
	}
}

void DameConectados (ListaConectados *lista, char conectados[300])
{
	//num/conectado1/conectado2...
	sprintf (conectados, "%d/", lista->num);
	int i;
	for(i=0; i<lista->num; i++)
	{
		sprintf (conectados, "%s%s/", conectados, lista->conectados[i].nombre);
	}
	conectados[strlen(conectados)-1] = '\0';
	strcat(conectados, "/");
}




int DameSocketConectados(ListaConectados *lista, char nnombre[200])
{
	for(int i=0; i < lista->num; i++)
	{
		if (strcmp(lista->conectados[i].nombre, nnombre)==0)
		{
			return lista->conectados[i].socket;
		}
	}
}

//Lista Jugador
int PonJugadores(listaPartidas *listaP, char nanfitrion[100], char nInvitado[100])
{
	int pos = listaP -> numjugadores;
	char *ninvitadotok;
	
	if (listaP->numjugadores >= 100) 
	{
		return -1;
	}
	else
	{
		strcpy(listaP->jugadores[pos].anfitrion, nanfitrion);
		ninvitadotok = strtok(nInvitado, ",");
		
		while (ninvitadotok != NULL)
		{
			if (listaP->jugadores[pos].numinvitados >= 3)
			{
				return -1;  // ya lleno
			}
			else
			{
				strcpy(listaP->jugadores[pos].inv[listaP->jugadores[pos].numinvitados].invitado, ninvitadotok);
				listaP->jugadores[pos].numinvitados++; 
				ninvitadotok = strtok(NULL, ",");
			}
		}
		listaP->numjugadores++;
		return 0;
	}
}

int DameNumInvitados(listaPartidas *listaP, const char *anfitrion)
{
	for (int i = 0; i < listaP->numjugadores; i++)
	{
		if (strcmp(listaP->jugadores[i].anfitrion, anfitrion) == 0)
		{
			return listaP->jugadores[i].numinvitados;
		}
	}
	// Si no existe esa partida:
	return 0;
}

//para encontrar la posicion de la partida en la lista 
int DamePosicionJugadores (listaPartidas *listaP, char nanfitrion[100])
{
	int i =0;
	int encontrado =0;
	while ((i<listaP-> numjugadores)&&!encontrado)
	{
		if (strcmp(listaP->jugadores[i].anfitrion, nanfitrion)==0)
			encontrado =1;
		if (!encontrado)
			i=i+1;
	}
	if (encontrado)
	{
		return i;
	}
	else 
	{
		return -1;
	}
}

int EliminarJugadores(listaPartidas *listaP, char ninvitado[20])
{
	int pos = DamePosicionJugadores (listaP, ninvitado);
	if (pos == -1)
	{
		return -1;
	}
	else
	{
		int i;
		for(i=pos; i<listaP->numjugadores-1; i++)
		{
			listaP->jugadores[i] = listaP->jugadores[i+1];
			/*			strcpy(lista.conectados[i].nombre, lista.conectados[i+1].nombre);*/
			/*			lista-> conectados[i].socket = lista-> conectados[i+1].socket ;*/
		}
		listaP-> numjugadores--;
		return 0;
	}
}
void DameNombresDeLosJugadores(listaPartidas *listaP, char nanfitrion[200], char result[300])
{
	for (int j = 0; j < listaP->numjugadores; j++)
	{
		if(strcmp(listaP->jugadores[j].anfitrion, nanfitrion)==0)
		{
			sprintf(result, "%s", nanfitrion);
			for(int i = 0; i < listaP->jugadores[j].numinvitados; i++)
			{
				sprintf(result, "%s/%s", result, listaP->jugadores[j].inv[i].invitado);
			}
			return; // Salir despu茅s de encontrar la partida
		}
	}
	// Si no se encuentra la partida
	sprintf(result, "%s", nanfitrion);
}
void *AtenderCliente(void *sock)
{
	int sock_conn;
	int *s;
	s = (int *) sock;
	sock_conn = *s;
	
	char peticion[600];
	char respuesta[600];
	
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	
	int ret;
	int err;
	char consulta[256];
	char insertar[256];
	
	MYSQL *conn;
	conn = mysql_init(NULL);
	
	int terminar = 0;
	
	conn = mysql_real_connect(conn, "localhost", "root", "mysql", NULL, 0, NULL, 0);//!!!
	if (conn == NULL)
	{
		printf("Error al inicializar la conexi贸n: %u %s\n", mysql_errno(conn), mysql_error(conn));
		exit(1);
	}
	
	err = mysql_query(conn, "USE info;");//!!!
	if (err != 0) {
		printf("Error al seleccionar la base de datos: %u %s\n", mysql_errno(conn), mysql_error(conn));
		exit(1);
	}
	
	
	while (terminar == 0) 
	{
		ret = read(sock_conn, peticion, sizeof(peticion));
		printf("Recibido\n");
		peticion[ret] = '\0';
		printf("Peticion: %s\n", peticion);
		//peticon: 1/userid/password,playername
		char userID[20]; //nombre de usuario introduido por usuario
		char password[40];
		char playername[30];
		char *p = strtok(peticion, "/");
		int codigo = atoi(p);
		printf("peticion:%s, codigo:%d\n", peticion, codigo);
		if ((codigo<3)&&(codigo != 0)) 
		{
			p = strtok(NULL, "/");
			if (p != NULL) strcpy(userID, p);
			p = strtok(NULL, "/");
			if (p != NULL) strcpy(password, p);
			p = strtok(NULL, "/");
			if (p != NULL) strcpy(playername, p);
			printf("Codigo: %d, UserID: %s, Password: %s, Playername: %s\n", codigo, userID, password, playername);
		}
		
		if (codigo == 0)//Desconectar
		{
			EliminarConectados(&milista, userID);
			printf("se ha desconectado %s\n",userID);
			sprintf(respuesta,"0/Se ha desconectado\n");
			write (sock_conn,respuesta, strlen(respuesta));
			terminar = 1;
		}
		else if (codigo == 1) //INICIAR SESION
		{
			sprintf(consulta, "SELECT USERID, PASSWORD_P FROM player WHERE USERID = '%s' AND PASSWORD_P = '%s'", userID, password);
			err = mysql_query(conn, consulta);
			if (err != 0) {
				printf("Error al consultar datos de la base: %u %s\n", mysql_errno(conn), mysql_error(conn));
				exit(1);
			}
			
			resultado = mysql_store_result(conn);
			row = mysql_fetch_row(resultado);
			if (row == NULL) {
				sprintf(respuesta,"1/El usuario o la contrasena no son correctos\n");
			} else {
				sprintf(respuesta,"2/Se ha iniciado sesion correctamente, bienvenido %s\n", row[0]);
				// Bloqueamos el mutex antes de modificar la lista
				pthread_mutex_lock(&mutex);
				PonConectados(&milista, userID, sock_conn);
				pthread_mutex_unlock(&mutex); // Desbloqueamos el mutex
			}
			
			write (sock_conn,respuesta, strlen(respuesta));
			
			//actualiza la lista de los conectados
			char misContactos[400];
			// Bloqueamos el mutex antes de leer la lista
			pthread_mutex_lock(&mutex);
			DameConectados(&milista, misContactos);
			pthread_mutex_unlock(&mutex); // Desbloqueamos el mutex
			char notificacion[100];
			sprintf(notificacion, "7/%s", misContactos);
			printf("%s\n",notificacion);
			int j;
			for(j=0; j<numsock;j++)
			{
				write (sockets[j], notificacion, strlen(notificacion));
			}
			
		}
		
		//REGISTRAR
		else if (codigo == 2)
		{
			printf("petiicion f2 %s\n", peticion);
			sprintf(insertar, "INSERT INTO player (PLAYERNAME, USERID, PASSWORD_P) VALUES ('%s', '%s', '%s')", playername, userID, password);
			err = mysql_query(conn, insertar);
			if (err != 0) {
				sprintf(respuesta, "Error al insertar datos en la base: %u %s\n", mysql_errno(conn), mysql_error(conn));
				exit(1);
			}
			resultado = mysql_store_result(conn);
			row = mysql_fetch_row(resultado);
			sprintf(respuesta, "2/Se ha registrado correctamente: %s\n", userID);
			write (sock_conn,respuesta, strlen(respuesta));
			
			char misContactos[400];
			// Bloqueamos el mutex antes de leer la lista
			pthread_mutex_lock(&mutex);
			DameConectados(&milista, misContactos);
			pthread_mutex_unlock(&mutex); // Desbloqueamos el mutex
			char notificacion[100];
			sprintf(notificacion, "7/%s", misContactos);
			printf("%s\n",notificacion);
			int j;
			for(j=0; j<numsock;j++)
			{
				write (sockets[j], notificacion, strlen(notificacion));
			}
			
			
		}
		
		//QUERY: ENCONTRAR LOS JUGADORES QUE EN UN ID PARTIDA DADA
		else if (codigo == 3) {
			char gameID[20];
			char *c = strtok(NULL, "/");
			strcpy(gameID,c);
			printf("Dame el ID de la partida que quieres buscar: ");
			sprintf(consulta, "SELECT WINNER, LOSER FROM game WHERE GAMEID = '%s'", gameID);
			err = mysql_query(conn, consulta);
			if (err != 0) {
				printf( "Error al consultar datos de la base: %u %s\n", mysql_errno(conn), mysql_error(conn));
				exit(1);
			}
			resultado = mysql_store_result(conn);
			row = mysql_fetch_row(resultado);
			if (row == NULL) {
				sprintf(respuesta, "3/No se han obtenido datos\n");
			} else {
				sprintf(respuesta, "3/Nombre de las personas con las que has jugado: %s, %s\n", row[0], row[1]);
			}
			mysql_free_result(resultado);
			write (sock_conn,respuesta, strlen(respuesta));
			
			
		} 
		
		////QUERY: LAS PARTIDAS QUE HE JUGADO EN EL DIA INTRODUCIDA
		else if (codigo == 4) {
			int date;
			char *c = strtok(NULL, "/");
			date = atoi(c);
			printf("Dime el data de las partidas que quieres buscar: ");
			
			sprintf(consulta, "SELECT * FROM game WHERE GAME_DATE = %d", date);
			err = mysql_query(conn, consulta);
			if (err != 0) {
				printf("Error al consultar datos de la base: %u %s\n", mysql_errno(conn), mysql_error(conn));
				exit(1);
			}
			resultado = mysql_store_result(conn);
			
			if (mysql_num_rows(resultado) == 0) {
				sprintf(respuesta,"4/No se han obtenido datos en la consulta\n");
			} else {
				while ((row = mysql_fetch_row(resultado)) != NULL) {
					char temp[256];
					sprintf(temp, "4/GAMEID: %s, GAME_DATE: %s, GAME_TIME: %s, DURATION: %s, WINNER: %s, LOSER: %s\n",
							row[0], row[1], row[2], row[3], row[4], row[5]);
					strcat(respuesta, temp);
				}
				mysql_free_result(resultado);
			}
			write (sock_conn,respuesta, strlen(respuesta));
		}
		
		//CONSULTAR LOS DETALLES DE LOS PARTIDOS CON EL JUGADOR INTRODUCIDO
		else if (codigo == 5) {
			char playername5[50];
			char *c = strtok(NULL, "/");
			strcpy (playername5,c);
			sprintf(consulta, "SELECT * FROM game WHERE WINNER = '%s' OR LOSER = '%s'", playername5, playername5);
			err = mysql_query(conn, consulta);
			if (err != 0) {
				printf("Error al consultar datos de la base: %u %s\n", mysql_errno(conn), mysql_error(conn));
				exit(1);
			}
			resultado = mysql_store_result(conn);
			if (resultado == NULL) {
				sprintf(respuesta, "5/No se encontraron partidas para el jugador %s\n", playername5);
			} else {
				
				while ((row = mysql_fetch_row(resultado)) != NULL) {
					sprintf(respuesta,"5/GAMEID: %s, GAME_DATE: %s, GAME_TIME: %s, DURATION: %s, WINNER: %s, LOSER: %s\n",
							row[0], row[1], row[2], row[3], row[4], row[5]);
				}
				mysql_free_result(resultado);
			}
			write (sock_conn,respuesta, strlen(respuesta));
		}
		
		//Invitar
		
		else if (codigo == 6)
		{
			char anfitrion6[200];
			char nombresInvitados[200];
			char nombresInvitados2[500];
			
			// Extraer anfitri贸n
			char *x1 = strtok(NULL, "/");
			if (x1 == NULL) {
				sprintf(respuesta, "6/Error: Falta anfitrion");
				write(sock_conn, respuesta, strlen(respuesta));
				break;
			}
			strcpy(anfitrion6, x1);
			//fromato: nombre1,nombre2,nombre3
			// Extraer invitados
			char *x2 = strtok(NULL, "/");
			if (x2 == NULL) {
				sprintf(respuesta, "6/Error: Falta lista de invitados");
				write(sock_conn, respuesta, strlen(respuesta));
				break;
			}
			strcpy(nombresInvitados, x2);
			strcpy(nombresInvitados2, nombresInvitados); // Copia para strtok
			// A帽adir a la lista de partidas
			if(PonJugadores(&milistaP, anfitrion6, nombresInvitados2) == -1) {
				sprintf(respuesta, "6/Error: No se pudo crear la partida");
				write(sock_conn, respuesta, strlen(respuesta));
				break;
			}
			// Enviar invitaciones a cada jugador
			char *invitado = strtok(nombresInvitados, ",");
			while (invitado != NULL)
			{
				sprintf(respuesta, "6/%s/%s", anfitrion6, invitado);
				
				// Buscar socket del invitado
				
				for(int j = 0; j < milista.num; j++)
				{
					if(strcmp(milista.conectados[j].nombre, invitado) == 0)
					{
						write(milista.conectados[j].socket, respuesta, strlen(respuesta));
						break;
					}
				}
				invitado = strtok(NULL, ",");
			}
			printf(respuesta, "6/Invitaciones enviadas");
			write(sock_conn, respuesta, strlen(respuesta));
		}
		
		else if (codigo == 65)
		{
			//formato: 65/yes or no/anfitrion/nombre invitado
			char resinvitado[100]; //respuesta del invitado
			char anfitrion65[200];
			char Invitado65[100];
			
			int res;
			
			char *x2 = strtok(NULL, "/"); 
			strcpy (resinvitado, x2);
			printf("resinv:%s", resinvitado);
			
			char *x3= strtok(NULL, "/");
			strcpy(anfitrion65, x3);
			printf("anfitrion:%s", anfitrion65);
			
			char *x4 = strtok (NULL, "/");
			strcpy(Invitado65, x4);
			printf("invitado:%s", Invitado65);
			
			
			printf("resinv: %s. invitado65: %s\n", resinvitado, Invitado65);
			if(strcmp(resinvitado, "yes")==0)
			{
				
				//funcion creado para encontrar el anfitrion con el nombre del invitado dado y guarda ese nombre al variable anfitrion
				
				printf ("Jugador %s ha aceptado tu invitacion, anfitrion: %s, resinv: %s\n", Invitado65, anfitrion65, resinvitado);
				sprintf (respuesta,"65/yes/%s/%s", anfitrion65,Invitado65);//65/yes/usuario anfitrion/usuarioInvitado,
				
			}
			else
			{
				pthread_mutex_lock(&mutex);
				res =EliminarJugadores(&milistaP, Invitado65);
				pthread_mutex_unlock(&mutex);
				printf ( "Jugador %s ha rechazado tu invitacion, resinv: %s\n", Invitado65, resinvitado);
				sprintf (respuesta,"65/no/%s/%s", anfitrion65, Invitado65);
			}
			int j;
			
			for(j=0; j<numsock;j++)
				
			{
				
				write (sockets[j], respuesta, strlen(respuesta));
				
			}
			
		}
		
		// Chat
		else if (codigo == 66)
		{
			char anfitrion66[200];
			char sender[200];
			char message[1000];
			
			// Extraer datos
			char *x1 = strtok(NULL, "/");
			if (!x1) {
				printf("Error: falta anfitrion\n");
				break;
			}
			strcpy(anfitrion66, x1);
			
			char *x2 = strtok(NULL, "/");
			if (!x2) {
				printf("Error: falta sender\n");
				break;
			}
			strcpy(sender, x2);
			
			char *x3 = strtok(NULL, "/");
			if (!x3) {
				printf("Error: falta mensaje\n");
				break;
			}
			strcpy(message, x3);
			
			// Preparar mensaje para enviar
			sprintf(respuesta, "66/%s/%s", sender, message);
			// Obtener nombres de todos los jugadores en la partida
			char nombrejugadores[300];
			DameNombresDeLosJugadores(&milistaP, anfitrion66, nombrejugadores);
			
			// Enviar mensaje a cada jugador
			char *token = strtok(nombrejugadores, "/");
			while (token != NULL) 
			{        int socket66 = DameSocketConectados(&milista, token);
			if (socket66 >= 0) 
			{
				write(socket66, respuesta, strlen(respuesta));
			}
			token = strtok(NULL, "/");
			}
		}
		
		printf ("Respuesta: %s\n", respuesta);
		// Enviamos respuesta
		
		
		
	}
	close(sock_conn);
}



int main(int argc, char *argv[])
{
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	int puerto = 9010;
	milista.num=0;
	
	// Crear socket de escucha
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
	{
		printf("Error al crear socket\n");
		exit(1);
	}
	
	// Inicializar la estructura de direcci贸n del servidor
	memset(&serv_adr, 0, sizeof(serv_adr));
	serv_adr.sin_family = AF_INET;
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	serv_adr.sin_port = htons(puerto);
	
	// Vincular el socket a la direcci贸n y puerto
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
	{
		printf("Error en el bind\n");
		exit(1);
	}
	
	// Escuchar conexiones entrantes
	if (listen(sock_listen, 3) < 0)
	{
		printf("Error en el listen\n");
		exit(1);
	}
	
	
	pthread_t thread[100];
	for (;;)
	{ 
		printf("Escuchando...\n");
		sock_conn = accept(sock_listen, NULL, NULL);
		printf("He recibido conexi贸n\n");
		
		sockets[numsock]= sock_conn; 
		pthread_create (&thread[numsock], NULL, AtenderCliente,&sockets[numsock]);
		numsock++;
	}
	
	/*	for (i=0;i<5;i++)*/
	/*	{*/
	/*		pthread_join (&thread[i], NULL);*/
	/*	}*/
}

