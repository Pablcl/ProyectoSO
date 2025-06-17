using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using v1;
using System.Threading;
using System.Threading.Tasks;
using System.Reflection.Emit;

namespace version_1
{
    public partial class FormPartida : System.Windows.Forms.Form
    {
        Socket server;
        public FormPartida(Socket server)
        {
            InitializeComponent();
            this.server = server;
            InitializeDataTable();

           
        }
        private void InitializeDataTable()
        {
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Resultado", typeof(float));
            dt.Columns.Add("Resultado dado", typeof(int)); // Añadir columna para el resultado del dado
            ResultadoGrid.DataSource = dt;
        }

        //CHAT


        private bool isRunning = true;
        private string invitado;
        private string anfitrion;
        private string nombreusuario; // persona quien iniciado sesuinn
        private int idPartida;
        public string sender;
        public string message;
        private string[] jugadores; // otros jugadores que se han unido a la partida
        private int numeroJugadores;// número de jugadores en la partida, incluido el anfitrión y el invitado
        int actualizacionLista = 0; // variable para controlar la actualización de la lista de jugadores

        //juego
        int resultado; // resultado del dado
        int NumPregunta;
        DataTable dt = new DataTable();

        public FormPartida(Socket server, string invittado, string nanfitrion, string nnombreusuario, int idpartida)
        {
            InitializeComponent();
            this.server = server;
            this.invitado = invittado;
            this.anfitrion = nanfitrion;
            this.nombreusuario = nnombreusuario;
            this.idPartida = idpartida;
            


            this.Text = $"Juego: invitado: {invitado} vs anfitrion: {anfitrion}";
            //lblStatus.Text = $"Connected to {opponentName}";

            //Task.Run(ListenForMessages);
            InitializeDataTable();
            if (nombreusuario == anfitrion)
            {
                preguntaBtn.Enabled = true;
            }
            else
            {
                preguntaBtn.Enabled = false;
            }
        }
        public void RecibirChat(string sender, string message)
        {
            chatBox.AppendText($"{sender}: {message}{Environment.NewLine}");
            chatBox.ScrollToCaret();
        }


       

        private void txtMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSend_Click_1(sender, e);
                e.Handled = true;
            }
        }

        private void btnSend_Click_1(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                try
                {

                    // Add to chat box
                    chatBox.AppendText($"You: {txtMessage.Text}{Environment.NewLine}");
                    chatBox.ScrollToCaret();
                    //66/anfitrion/sender/mensaje
                    string mensaje = "66/" + anfitrion + "/" + nombreusuario + "/" + txtMessage.Text + "/" + idPartida;
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);
                    txtMessage.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to send message: {ex.Message}");
                }
            }
        }

        //parte juego
        private void TirarBtn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            resultado = random.Next(1, 12);
            TirarBtn.Enabled = false;

            //10/amfitrion/nombreusuario/número de pregunta/resultado/idPartida
            string mensaje = "10/" + anfitrion + "/" + nombreusuario + "/" + NumPregunta + "/" + resultado + "/" + idPartida;
            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
        }

        public void RespuestaDados(string anfitrionDados, string invitadoDados, string OtrosJugadores, int numpreguntarep, int resultadoDados, int idPartidaDados)
        {
            List<string> listaJugadores = new List<string>();

            if (!string.IsNullOrEmpty(OtrosJugadores))
            {
                // Dividir la lista de otros jugadores (separados por comas)
                string[] otros = OtrosJugadores.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                listaJugadores.AddRange(otros);
            }

            this.numeroJugadores = listaJugadores.Count;
            // Asignar a la variable de clase
            this.jugadores = listaJugadores.ToArray();
            for (int i = 0; i < jugadores.Length; i++)
            {
                if (jugadores[i] == anfitrion)
                {
                    for (int j = i; j < jugadores.Length-1; j++)
                    {
                        
                        jugadores[j] = jugadores[j + 1]; //eliminar anfitrion de la lista de jugadores

                        
                    }
                    jugadores[jugadores.Length - 1] = null; // Asignar null al último elemento
                    break;
                }
            }
            if (actualizacionLista != 0)
            { // Actualizar las etiquetas de los jugadores
                anfitrionLbl.Text = "Anfitrión: " + anfitrion;
                if (jugadores[0] != null)
                {
                    jugador1Lbl.Text = "Jugador 1: " + jugadores[0];
                }

                if (jugadores.Length>1 && jugadores[1] != null)
                {
                    jugador2Lbl.Text = "Jugador 2: " + jugadores[1];
                }

                if (jugadores.Length>2 && jugadores[2] != null)
                {
                    jugador3Lbl.Text = "Jugador 3: " + jugadores[2];
                }
            }
            actualizacionLista = 1; // Indicar que la lista de jugadores ha sido actualizada
            //datos
            string anfitriond = anfitrionDados;
            string tirador = invitadoDados;
            int resultadod = resultadoDados;
            
            int idPartidad = idPartidaDados;
            this.NumPregunta = numpreguntarep;
            resDato.Text = "nombre: " + tirador + " resultado: " + resultadod;
            
            //dependiendo del resultado del dado, se envía a una funcion de pregunta diferente
            switch (NumPregunta)
            {
                case 1:
                    pregunta1(resultadod, tirador);
                    break;

                case 2:
                    pregunta2(resultadod, tirador);
                    break;

                case 3:
                    pregunta3(resultadod, tirador);
                    break;
                case 4:
                    pregunta4(resultadod, tirador);
                    break;
            }
        }


        private void preguntaBtn_Click(object sender, EventArgs e)
        {

            Random random = new Random();
            NumPregunta = random.Next(1, 5);//devuelve numero mayor o igual a minValue y menor a maxValue!!!
            Preguntas(NumPregunta);
            //11/anfitrion/NumPregunta/idPartida
            string mensaje = "11/" + anfitrion + "/" + NumPregunta + "/" + idPartida;
            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
        }

        public void Preguntas(int numpregunta1)
        {
            int maxLength = 30; // longitud máxima permitida
            string texto, text;

            switch (numpregunta1)
            {
                case 1:
                    text = "Se gana con el múltiple de 2 más grande, si no es múltipled de 2 se considera automáticamente 0.";
                    texto = InsertarSaltosDeLinea(text, maxLength);
                    preguntaBox.Text = texto;
                    break;

                case 2:
                    text = "Se gana con el número primo más grande.";
                    texto = InsertarSaltosDeLinea(text, maxLength);
                    preguntaBox.Text = texto;
                    break;

                case 3:
                    text = "Se gana con el número más cercano a raíz de π";
                    texto = InsertarSaltosDeLinea(text, maxLength);
                    preguntaBox.Text = texto;
                    break;

                case 4:
                    text = "Se gana con el número más lejos de 9";
                    texto = InsertarSaltosDeLinea(text, maxLength);
                    preguntaBox.Text = texto;
                    break;
            }
           
        }

        // Método para insertar saltos de línea en un texto largo 
        static string InsertarSaltosDeLinea(string texto, int maxCaracteresPorLinea)
        {
            // si el texto es más corto que el máximo permitido, no se hace nada
            if (texto.Length <= maxCaracteresPorLinea)
            {
                return texto;
            }
            // Busca el último espacio antes del límite de caracteres
            int ultimoEspacio = texto.LastIndexOf(' ', maxCaracteresPorLinea);
            // Si no hay espacios, corta en maxCaracteres
            if (ultimoEspacio <= 0) 
            {
                return texto.Substring(0, maxCaracteresPorLinea) +
                       Environment.NewLine +
                       InsertarSaltosDeLinea(texto.Substring(maxCaracteresPorLinea), maxCaracteresPorLinea);
            }
            // Si hay un espacio, corta en ese punto y llama recursivamente al método para el resto del texto
            return texto.Substring(0, ultimoEspacio) +
                   Environment.NewLine +
                   InsertarSaltosDeLinea(texto.Substring(ultimoEspacio + 1), maxCaracteresPorLinea);
        }


        private void pregunta1(int resultadoDadoP1, string nombre)
        {
            // Verifica si el resultado del dado es un múltiplo de 2
            float resP1 = resultadoDadoP1 / 2f;
            if (resultadoDadoP1 % 2 == 0)
            {
                //añadir al DataTable
                DataRow newRow = dt.NewRow();
                newRow["Nombre"] = nombre;
                newRow["Resultado"] = resP1;
                newRow["Resultado dado"] = resultadoDadoP1; 
                dt.Rows.Add(newRow);
            }
            else
            {
                //añadir al DataTable
                DataRow newRow = dt.NewRow();
                newRow["Nombre"] = nombre;
                newRow["Resultado"] = 0f; // Si no es múltiplo de 2, el resultado es 0
                newRow["Resultado dado"] = resultadoDadoP1; // Guardar el resultado del dado
                dt.Rows.Add(newRow);
            }
            //Comparar los resultados de los jugadores y determinar el ganador
            if (dt.Rows.Count >= numeroJugadores)
            {
                string ganador = "";
                float maxResultado = float.MinValue;
               
                foreach (DataRow row in dt.Rows)
                {
                    float res = Convert.ToSingle(row["Resultado"]);
                    if (res > maxResultado)
                    {
                        maxResultado = res;
                        ganador = row["Nombre"].ToString();
                    }
                }

                //buscar los ganadores con el mismo resultado
                var jugadoresGanadores = new List<string>();
                foreach (DataRow row in dt.Rows)
                {
                    int res = Convert.ToInt32(row["Resultado"]);
                    if (res == maxResultado)
                    {
                        jugadoresGanadores.Add(row["Nombre"].ToString());
                    }
                }
                
                //se empata los jugadores
                if (jugadoresGanadores.Count >=2) 
                {
                    MessageBox.Show($"Empate entre {string.Join(", ", jugadoresGanadores)}  jugadores con resultado {maxResultado}");
                }
                else
                {
                    MessageBox.Show($"El ganador es: {ganador} con resultado {maxResultado}");
                }
                TirarBtn.Enabled = true;
                dt.Clear();
            }

        }

        private void pregunta2(int resultadoDadoP2, string nombre)
        {
            // Inicializar la variable resP2 con un valor predeterminado
            int resP2 = 0;
            // Verifica si el resultado del dado es un número primo
            bool esPrimo = true;
            if (resultadoDadoP2 < 2)
            {
                esPrimo = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(resultadoDadoP2); i++)
                {
                    if (resultadoDadoP2 % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
            }

            // Si es primo, asignar el valor del dado a resP2
            if (esPrimo)
            {
                resP2 = resultadoDadoP2;
            }

            // Añadir al DataTable
            DataRow newRow = dt.NewRow();
            newRow["Nombre"] = nombre;
            newRow["Resultado"] = resP2;
            newRow["Resultado dado"] = resultadoDadoP2; // Guardar el resultado del dado
            dt.Rows.Add(newRow);

            //Comparar los resultados de los jugadores y determinar el ganador
            if (dt.Rows.Count >= numeroJugadores)
            {
                string ganador = "";
                int maxResultado = int.MinValue;

                foreach (DataRow row in dt.Rows)
                {
                    int res = Convert.ToInt32(row["Resultado"]);
                    if (res > maxResultado)
                    {
                        maxResultado = res;
                        ganador = row["Nombre"].ToString();
                    }
                }

                //buscar los ganadores con el mismo resultado
                var jugadoresGanadores = new List<string>();
                foreach (DataRow row in dt.Rows)
                {
                    int res = Convert.ToInt32(row["Resultado"]);
                    if (res == maxResultado)
                    {
                        jugadoresGanadores.Add(row["Nombre"].ToString());
                    }
                }

                if (jugadoresGanadores.Count >=2)
                {
                    MessageBox.Show($"Empate entre los jugadores {string.Join(", ", jugadoresGanadores)}, con resultado {maxResultado}");
                    return;
                }
                else
                {
                    MessageBox.Show($"El ganador es: {ganador} con resultado {maxResultado}");
                }
                TirarBtn.Enabled = true; // Habilitar el botón para tirar de nuevo
                dt.Clear(); // Limpiar el DataTable para la próxima ronda
            }
        }

        private void pregunta3 (int resultadoDadoP3, string nombre)
        {

            // Añadir al DataTable
            DataRow newRow = dt.NewRow();
            newRow["Nombre"] = nombre;
            
            newRow["Resultado dado"] = resultadoDadoP3;
            dt.Rows.Add(newRow);

            double raizPi = 1.7725;
            

            //Comparar los resultados de los jugadores y determinar el ganador
            if (dt.Rows.Count >= numeroJugadores)
            {
                string ganador = "";
                double diferenciaMinima = double.MaxValue;

                foreach (DataRow row in dt.Rows)
                {
                    int res = Convert.ToInt32(row["Resultado dado"]);
                    double diferencia = Math.Abs(res - raizPi);
                    row["Resultado"] = diferencia; 
                    
                    if (diferencia < diferenciaMinima)
                    {
                        diferenciaMinima = diferencia;
                        ganador = row["Nombre"].ToString();
                    }

                }

                //buscar los ganadores con el mismo resultado
                var jugadoresGanadores = new List<string>();
                foreach (DataRow row in dt.Rows)
                {
                    int res = Convert.ToInt32(row["Resultado"]);
                    if (res == diferenciaMinima)
                    {
                        jugadoresGanadores.Add(row["Nombre"].ToString());
                    }
                }

                if (jugadoresGanadores.Count >= 2)
                {
                    MessageBox.Show($"Empate entre jugadores {string.Join(", ", jugadoresGanadores)} con resultado {diferenciaMinima}");
                    return;
                }
                else
                {
                    MessageBox.Show($"El ganador es: {ganador} con resultado {diferenciaMinima}", "Resultado de la Ronda");
                }
                TirarBtn.Enabled = true; // Habilitar el botón para tirar de nuevo
                dt.Clear(); // Limpiar el DataTable para la próxima ronda
            }
        }

        private void pregunta4(int resultadoDadoP4, string nombre)
        {
            int distancia = Math.Abs(resultadoDadoP4 - 9);

            // Añadir al DataTable
            DataRow newRow = dt.NewRow();
            newRow["Nombre"] = nombre;
            newRow["Resultado"] = distancia;
            newRow["Resultado dado"] = resultadoDadoP4;
            dt.Rows.Add(newRow);

            //Comparar los resultados de los jugadores y determinar el ganador
            if (dt.Rows.Count >= numeroJugadores)
            {
                string ganador = "";
                int maxDistancia = int.MinValue;

                foreach (DataRow row in dt.Rows)
                {
                    int dist = Convert.ToInt32(row["Resultado"]);
                    if (dist > maxDistancia)
                    {
                        maxDistancia = dist;
                        ganador = row["Nombre"].ToString();
                    }
                }

                //buscar los ganadores con el mismo resultado
                var jugadoresGanadores = new List<string>();
                foreach (DataRow row in dt.Rows)
                {
                    int res = Convert.ToInt32(row["Resultado"]);
                    if (res == maxDistancia)
                    {
                        jugadoresGanadores.Add(row["Nombre"].ToString());
                    }
                }

                if (jugadoresGanadores.Count >= 2)
                {
                    MessageBox.Show($"Empate entre jugadores {string.Join(", ", jugadoresGanadores)} con resultado {maxDistancia}");
                    return;
                }
                else
                {
                    MessageBox.Show($"El ganador es: {ganador} con resultado {maxDistancia}", "Resultado de la Ronda");
                }
                TirarBtn.Enabled = true; // Habilitar el botón para tirar de nuevo
                dt.Clear(); // Limpiar el DataTable para la próxima ronda
            }
        }
        
    }
}

