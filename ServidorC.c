#include <stdio.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <string.h>
#include <mysql/mysql.h>

int main(int argc, char *argv[]) {
    int sock_conn, sock_listen, ret;
    struct sockaddr_in serv_adr;
    char peticion[600];
    char respuesta[600];

    // Crear socket de escucha
    if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0) {
        printf("Error al crear socket\n");
        exit(1);
    }

    // Inicializar la estructura de direcci贸n del servidor
    memset(&serv_adr, 0, sizeof(serv_adr));
    serv_adr.sin_family = AF_INET;
    serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
    serv_adr.sin_port = htons(9040);

    // Vincular el socket a la direcci贸n y puerto
    if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0) {
        printf("Error en el bind\n");
        exit(1);
    }

    // Escuchar conexiones entrantes
    if (listen(sock_listen, 3) < 0) {
        printf("Error en el listen\n");
        exit(1);
    }

    // Conexi贸n a la base de datos MySQL
    MYSQL *conn;
    int err;
    char consulta[256];
    char insertar[256];
    MYSQL_RES *resultado;
    MYSQL_ROW row;
    conn = mysql_init(NULL);

    if (conn == NULL) {
        printf("Error al crear conexi贸n: %u %s\n", mysql_errno(conn), mysql_error(conn));
        exit(1);
    }

    conn = mysql_real_connect(conn, "localhost", "root", "mysql", NULL, 0, NULL, 0);
    if (conn == NULL) {
        printf("Error al inicializar la conexi贸n: %u %s\n", mysql_errno(conn), mysql_error(conn));
        exit(1);
    }

    err = mysql_query(conn, "USE info;");
    if (err != 0) {
        printf("Error al seleccionar la base de datos: %u %s\n", mysql_errno(conn), mysql_error(conn));
        exit(1);
    }

    // Bucle infinito para escuchar peticiones
    for (;;) {
        printf("Escuchando...\n");
        sock_conn = accept(sock_listen, NULL, NULL);
        printf("He recibido conexi贸n\n");

        int terminar = 0;
        while (terminar == 0) 
		{
            ret = read(sock_conn, peticion, sizeof(peticion));
            printf("Recibido\n");
            peticion[ret] = '\0';
            printf("Petici贸n: %s\n", peticion);

			
            char userID[20];
            char password[40];
            char playername[30];
            char *p = strtok(peticion, "/");
            int codigo = atoi(p);
            if ((codigo<3)&&(codigo != 0)) 
			{
                p = strtok(NULL, "/");
                if (p != NULL) strcpy(userID, p);
                p = strtok(NULL, "/");
                if (p != NULL) strcpy(password, p);
                p = strtok(NULL, "/");
                if (p != NULL) strcpy(playername, p);
                printf("C贸digo: %d, UserID: %s, Password: %s, Playername: %s\n", codigo, userID, password, playername);
            }

            if (codigo == 0) {
                terminar = 1;
				//INICIAR SESION
            } else if (codigo == 1) {
                sprintf(consulta, "SELECT USERID, PASSWORD_P FROM player WHERE USERID = '%s' AND PASSWORD_P = '%s'", userID, password);
                err = mysql_query(conn, consulta);
                if (err != 0) {
                    printf("Error al consultar datos de la base: %u %s\n", mysql_errno(conn), mysql_error(conn));
                    exit(1);
                }

                resultado = mysql_store_result(conn);
                row = mysql_fetch_row(resultado);
                if (row == NULL) {
                    sprintf(respuesta,"El usuario y/o la contrase馻 no son correctos\n");
                } else {
                    sprintf(respuesta,"Se ha iniciado sesion correctamente, bienvenido %s\n", row[0]);
                }
               // mysql_free_result(resultado);
				//REGISTRAR
            } else if (codigo == 2) {
                sprintf(insertar, "INSERT INTO player (PLAYERNAME, USERID, PASSWORD_P) VALUES ('%s', '%s', '%s')", playername, userID, password);
                err = mysql_query(conn, insertar);
                if (err != 0) {
                    sprintf(respuesta, "Error al insertar datos en la base: %u %s\n", mysql_errno(conn), mysql_error(conn));
                    exit(1);
                }
				resultado = mysql_store_result(conn);
				row = mysql_fetch_row(resultado);
                sprintf(respuesta, "Se ha registrado correctamente: %s\n", resultado);
				//QUERY: ENCONTRAR LOS JUGADORES QUE EN UN ID PARTIDA DADA
            } else if (codigo == 3) {
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
                    sprintf(respuesta, "No se han obtenido datos\n");
                } else {
                    sprintf(respuesta, "Nombre de las personas con las que has jugado: %s, %s\n", row[0], row[1]);
                }
                mysql_free_result(resultado);
				////QUERY: LAS PARTIDAS QUE HE JUGADO EN EL DIA INTRODUCIDA
            } else if (codigo == 4) {
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
                    sprintf(respuesta,"No se han obtenido datos en la consulta\n");
                } else {
                    while ((row = mysql_fetch_row(resultado)) != NULL) {
						char temp[256];
						sprintf(temp, "GAMEID: %s, GAME_DATE: %s, GAME_TIME: %s, DURATION: %s, WINNER: %s, LOSER: %s\n",
								row[0], row[1], row[2], row[3], row[4], row[5]);
						strcat(respuesta, temp);
                    }
                    mysql_free_result(resultado);
                }
				
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
                    sprintf(respuesta, "No se encontraron partidas para el jugador %s\n", playername5);
                } else {
                   
                    while ((row = mysql_fetch_row(resultado)) != NULL) {
                        sprintf(respuesta,"GAMEID: %s, GAME_DATE: %s, GAME_TIME: %s, DURATION: %s, WINNER: %s, LOSER: %s\n",
								row[0], row[1], row[2], row[3], row[4], row[5]);
                    }
                    mysql_free_result(resultado);
                }
            }
			if (codigo !=0)
			{
				
				printf ("Respuesta: %s\n", respuesta);
				// Enviamos respuesta
				write (sock_conn,respuesta, strlen(respuesta));
			}
        }
        close(sock_conn);
    }
    mysql_close(conn);
    return 0;
}
