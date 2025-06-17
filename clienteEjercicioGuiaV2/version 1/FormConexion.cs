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


namespace version_1            
{
    public partial class FormConexion : System.Windows.Forms.Form
    {
        Socket server;
        Thread atender;
        bool conecion;
        string NombreUsuario;//el nombre del usuario que se ha inicado la sesion
        int inicializado = 0; // variable para saber si el usuario ha inicializado la sesion o no
        DataTable dt = new DataTable();// tabla para almacenar los usuarios conectados
        FormPartida formPlay; //para inicar la partida
        int repetir = 0; //para saber si el anfitrion ha vuelto a abrir form partida al mismo partida
        int partidaId = 0;
        public FormConexion()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            dt.Columns.Add("Nombre", typeof(string));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AtenderServidor()
        {
            while (conecion)
            {
                //recepción de mensaje de servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                string[] trozos = Encoding.ASCII.GetString(msg2).Split('\0')[0].Split('/');
                int codigo = Convert.ToInt32(trozos[0]);
                string mensaje;
                string[] nombreinvitar = new string[2];
                switch (codigo)
                {

                    case 0: // log out
                        if (trozos[1] == "ok")
                        {
                            label3.BackColor = Color.Gray;
                            server.Shutdown(SocketShutdown.Both);
                            server.Close();
                            conecion = false;
                            MessageBox.Show("Se ha desconectado de servidor.");
                        }
                        break;

                    case 1: //login
                        mensaje = trozos[1];
                        if (mensaje == "El usuario o la contrasena no son correctos\n")
                        {
                            MessageBox.Show(mensaje);
                        }
                        else
                        {
                            MessageBox.Show(mensaje);
                            // Forms de peticiones del cliente
                            this.Invoke((MethodInvoker)delegate
                            {
                                FormPeticiones form2 = new FormPeticiones(server);
                                form2.Show();
                            });
                        }
                        break;

                    case 2: //register
                        mensaje = trozos[1];
                        MessageBox.Show(mensaje);
                        break;

                    case 6:
                        //invitar
                        mensaje = trozos[1];
                        for (int i = 1; i <= 2; i++)
                        {
                            nombreinvitar[i - 1] = trozos[i];
                        } // FROMATO RECIBIDO: anfitrion/invitado

                        if (mensaje == "Error, no ha llegado el nombre.")
                        {
                            // Si el mensaje es "No se ha podido enviar la invitación" se muestra un mensaje de error
                            MessageBox.Show("No se ha podido enviar la invitación");
                        }
                        else
                        {
                            if (nombreinvitar[1] == NombreUsuario)//para en invitado
                            {
                                MessageBox.Show("Has recibido una invitación de " + nombreinvitar[0]);
                                this.Invoke((MethodInvoker)delegate
                                {
                                    FormAceptarInv formAceptarInv = new FormAceptarInv(server, nombreinvitar[0], NombreUsuario);
                                    formAceptarInv.Show();
                                });
                            }
                            else
                            {
                                MessageBox.Show("ha enviado con exito");
                            }
                        }

                        // Si el mensaje es "No se ha podido enviar la invitación" se muestra un mensaje de error
                        if (mensaje == "No se ha podido enviar la invitación")
                        {
                            MessageBox.Show("No se ha podido enviar la invitación");
                        }
                        break;

                    case 65:
                        //65/yes/ anfitrion/usuario invitado/id partida
                        mensaje = trozos[1];
                        string anfitrion = trozos[2];
                        string invitado = trozos[3];
                        int nuevoPartidaId = Convert.ToInt32(trozos[4]); // Guardar el nuevo ID

                        //respuesta invitacion
                        if (mensaje == "no")
                        {
                            MessageBox.Show("Has rechazado la invitación");
                        }
                        else
                        {
                            // Si el usuario actual es el invitado
                            if ((mensaje == "yes") && (invitado == NombreUsuario))
                            {
                                MessageBox.Show("Has aceptado la invitación");
                                this.Invoke((MethodInvoker)delegate
                                {
                                    formPlay = new FormPartida(server, invitado, anfitrion, NombreUsuario, nuevoPartidaId);
                                    formPlay.Show();
                                });
                            }

                            // Si el usuario actual es el anfitrión
                            if ((mensaje == "yes") && (anfitrion == NombreUsuario))
                            {
                                // Si es una nueva partida (ID diferente) o no hay ventana abierta
                                if (nuevoPartidaId != partidaId || formPlay == null || formPlay.IsDisposed)
                                {
                                    MessageBox.Show("Ha aceptado tu invitación");
                                    this.Invoke((MethodInvoker)delegate
                                    {
                                        formPlay = new FormPartida(server, invitado, anfitrion, NombreUsuario, nuevoPartidaId);
                                        formPlay.Show();
                                    });
                                    partidaId = nuevoPartidaId; // Actualizar el ID de la partida actual
                                    repetir = 0; // Permitir que se abra una nueva ventana si cambia la partida
                                }
                                // Si es la misma partida (mismo ID), no abrimos ventana nueva
                                else
                                {
                                    MessageBox.Show("Ya tienes una ventana abierta para esta partida.");
                                }
                            }
                        }
                        break;

                    case 66: // chat: 66/sender/message
                        string sender = trozos[1];
                        mensaje = trozos[2];
                        if (formPlay != null)
                        {
                            // invocamos en el hilo de UI del FormPartida
                            formPlay.Invoke((MethodInvoker)(() =>
                                formPlay.RecibirChat(sender, mensaje)
                            ));
                        }
                        break;

                    case 7:
                        this.Invoke((MethodInvoker)delegate
                        {
                            try
                            {
                                int numeroConectados = Convert.ToInt32(trozos[1]);

                                // Desvincular primero para evitar conflictos
                                dataGridViewConectados.DataSource = null;

                                // Limpiar la tabla antes de llenarla
                                dt.Clear();

                                for (int i = 0; i < numeroConectados; i++)
                                {
                                    int index = i + 2; // usuarios empiezan en trozos[2]
                                    if (index < trozos.Length)
                                    {
                                        string nombreConectado = trozos[index];
                                        if (!string.IsNullOrEmpty(nombreConectado))
                                        {
                                            DataRow newRow = dt.NewRow();
                                            newRow["Nombre"] = nombreConectado;
                                            dt.Rows.Add(newRow);
                                        }
                                    }
                                }

                                // Asignar nueva fuente de datos
                                dataGridViewConectados.DataSource = dt;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error al actualizar usuarios conectados: " + ex.Message);
                            }
                        });
                        break;

                    //recibir el resultado de dado 
                    case 10:
                        //10/anfitrion/nombreusuario/número de pregunta/resultado/idPartida
                        string anfitrionTirar = trozos[1];
                        string tirador = trozos[2];
                        int numeroPregunta = Convert.ToInt32(trozos[3]); // Número de pregunta
                        int resultado = Convert.ToInt32(trozos[4]);
                        int idPartida = Convert.ToInt32(trozos[5]);
                        if (formPlay != null)
                        {
                            formPlay.Invoke((MethodInvoker)(() =>
                                formPlay.RespuestaDados(anfitrionTirar, tirador, numeroPregunta, resultado, idPartida)
                            ));
                        }
                        break;
                    case 11:
                        //11/anfitrion/NumPregunta/idPartida
                        string anfitrionPreguntar = trozos[1];
                        int numeroPregunta11 = Convert.ToInt32(trozos[2]); // Número de pregunta
                        int idPartida11 = Convert.ToInt32(trozos[3]);
                        if (formPlay != null)
                        {
                            formPlay.Invoke((MethodInvoker)(() =>
                                formPlay.Preguntas(numeroPregunta11)
                            ));
                        }
                        break;

                }
            }
        }
        // BOTÓN PARA INICIAR LA CONEXIÓN CON EL SERVIDOR
        private void btnconexion_Click(object sender, EventArgs e)
        {
             //Creamos un IPEndPoint con el ip del servidor y puerto del servidor al que deseamos conectarnos
            IPAddress direc = IPAddress.Parse("192.168.56.102");//192.168.56.102, 10.4.119.5
            IPEndPoint ipep = new IPEndPoint(direc, 9014);//9000, 50007

            //Creamos el socket 
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                //Conexión con el servidor
                server.Connect(ipep);
                label3.BackColor = Color.Green;
                MessageBox.Show("Conectado correctamente");
                conecion = true;
            }
            catch (SocketException ex)
            {
                //Si hay excepcion imprimimos error y salimos del programa con return 
                MessageBox.Show("No se ha podido conectar con el servidor. Intentalo mas tarde.");
                return;
            }
            ThreadStart threadst = delegate { AtenderServidor(); };
            atender = new Thread(threadst);
            atender.Start();
        }

        // BOTON PARA INICIAR SESIÓN
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (inicializado == 0)
            {
                // Resetear si ya estaba inicializado
                if (inicializado == 1)
                {
                    inicializado = 0;
                }

                NombreUsuario = userlogintxt.Text;
                FormInvitar nuevoForm = new FormInvitar(NombreUsuario);
                string mensaje = "1/" + userlogintxt.Text + "/" + passwordlogintxt.Text;
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
                inicializado = 1; // el usuario ha inicializado la sesion
            }
        }

        //BOTÓN PARA REGISTRARSE
        private void btnregister_Click(object sender, EventArgs e)
        {
            string mensaje = "2/" + userlogintxt.Text + "/" + passwordlogintxt.Text + "/" + PLAYERNAME.Text;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void buttonDesconn_Click(object sender, EventArgs e)
        {
            string mensaje = "0/" + NombreUsuario;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            // Resetear variables de estado
            inicializado = 0;
            conecion = false;
            NombreUsuario = "";

            // Limpiar el formulario
            userlogintxt.Text = "";
            passwordlogintxt.Text = "";
            dt.Clear(); 
        }

        private void InvitarBtn_Click(object sender, EventArgs e)
        {
            dataGridViewConectados.MultiSelect = true;
            dataGridViewConectados.ReadOnly = true;//cada usuario solo puede leer las celdas
            
            //SOLO PARA EL VALOR DE UNA CELDA string invitarUsuario = dataGridViewConectados.CurrentRow.Cells[0].Value.ToString();
            List<string> usuariosInvitar = new List<string>();
            foreach (DataGridViewCell cell in dataGridViewConectados.SelectedCells)
            {
                string valor = cell.Value?.ToString();
                if (!string.IsNullOrWhiteSpace(valor) && !usuariosInvitar.Contains(valor))
                {
                    usuariosInvitar.Add(valor);
                }
            }
            string mensaje = "6/" + NombreUsuario + "/"+ string.Join(",", usuariosInvitar) ;//formato: 6/invitador/invitado
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

        }
    }
}

