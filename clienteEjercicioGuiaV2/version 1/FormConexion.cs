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
        FormPartida formPlay; //para inicar la partida
        public FormConexion()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
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
                string[] nombreinvitar= new string[2];
                switch (codigo)
                {

                    case 0: // log out
                        this.BackColor = Color.Gray;
                        server.Shutdown(SocketShutdown.Both);
                        server.Close();
                        MessageBox.Show("Se ha desconectado de servidor.");
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
                            this.Invoke((MethodInvoker)delegate {
                                FormPeticiones form2 = new FormPeticiones(server);
                                form2.Show();
                            });              
                        }
                        break;

                    case 2: //register
                        mensaje = trozos[1];
                        MessageBox.Show(mensaje);
                        //if (mensaje == "No se han obtenido datos")
                        //{
                        //    MessageBox.Show("Error. No se han obtenido datos.");
                        //}
                        //else
                        //{        
                            // Forms de peticiones del cliente
                            this.Invoke((MethodInvoker)delegate {
                                FormPeticiones form2 = new FormPeticiones(server);
                                form2.Show();
                            });
                        
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
                                this.Invoke((MethodInvoker)delegate {
                                    FormAceptarInv formAceptarInv = new FormAceptarInv(server, nombreinvitar[0], NombreUsuario );
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
                        //65/yes/ usuario invitador/usuario invitado/invitado2...

                        mensaje= trozos[1];
                        string invitado = trozos[3];
                        string anfitrion = trozos[2];
                        int repetir = 0; //para saber si el anfitrion ha vuelto a abrir form partida al mismo partida
                        //respuesta invitacion
                        if (mensaje == "no")
                        {
                            MessageBox.Show("Has rechazado la invitación");
                        }
                        else
                        {
                            //para el invitado
                            if ((mensaje == "yes") && (invitado == NombreUsuario))
                            {
                                MessageBox.Show("Has aceptado la invitación");
                                this.Invoke((MethodInvoker)delegate
                                {                                                   //invitado, anfitrion
                                    formPlay = new FormPartida(server, invitado, anfitrion, NombreUsuario);
                                    formPlay.Show();
                                });
                            }
                            //para el anfitrion
                            if ((mensaje == "yes") && (anfitrion == NombreUsuario) && (repetir == 0)) 
                            {
                                MessageBox.Show("Ha aceptado tu invitación");
                                this.Invoke((MethodInvoker)delegate
                                {
                                    formPlay = new FormPartida(server, invitado, anfitrion, NombreUsuario);
                                    formPlay.Show();
                                });
                                repetir = 1; // para que no se vuelva a abrir el form partida si otro invitado vuelve a aceptar la invitación
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

                    case 7: //notificacion                                       
                        //7/num/conectado1/conectado2...
                        string[] conectados = new string[80];
                        int numeroConectados = Convert.ToInt32(trozos[1]);
                        for (int i = 1; i <= numeroConectados; i++)
                        {
                              conectados[i-1] = trozos[i+1];
                        }
                        
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Nombre");
                        
                        for (int i = 0; i < numeroConectados; i++)
                        {
                            // Verifica que el índice existe en el array
                            if (i < numeroConectados+1)
                            {
                                string Nombres = conectados[i].Split('\0')[0];
                                dt.Rows.Add(Nombres);
                            }
                            else
                            {
                                MessageBox.Show("Datos incompletos recibidos del servidor.");
                                break;
                            }
                        }

                        // Asignar el DataSource
                        this.Invoke((MethodInvoker)delegate
                        {
                            dataGridViewConectados.DataSource = dt;
                        });
                        break;
                        
                }

            }
        }
        // BOTÓN PARA INICIAR LA CONEXIÓN CON EL SERVIDOR
        private void btnconexion_Click(object sender, EventArgs e)
        {
             //Creamos un IPEndPoint con el ip del servidor y puerto del servidor al que deseamos conectarnos
            IPAddress direc = IPAddress.Parse("192.168.56.102");//192.168.56.102, 10.4.119.5
            IPEndPoint ipep = new IPEndPoint(direc, 9010);//0, 50007

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
            string mensaje = "0/";
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
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

