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
    public partial class Form1 : Form
    {
        Socket server;
        Thread atender;
        bool conexion;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AtenderServidor()
        {
            while (conexion)
            {
                //recepción de mensaje de servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                string[] trozos = Encoding.ASCII.GetString(msg2).Split('/');
                int codigo = Convert.ToInt32(trozos[0]);
                string mensaje = mensaje = trozos[1].Split('\0')[0];
                switch (codigo)
                {

                    case 0: // log out
                        this.BackColor = Color.Gray;
                        server.Shutdown(SocketShutdown.Both);
                        server.Close();
                        MessageBox.Show("se ha desconectado.");
                        conexion = false;
                        break;

                    case 1: //login
                        MessageBox.Show(mensaje);
                        if (mensaje == "El usuario y/o la contrase￱a no son correctos")
                        {
                        }
                        else
                        {
                            Form2 form2 = new Form2(server);
                            form2.Show();

                        }
                        break;
                    case 2: //register
                        MessageBox.Show(mensaje);
                        if (mensaje == "No se han obtenido datos")
                        {

                        }
                        else
                        {
                            Form2 f2 = new Form2(server);
                            f2.Show();
                        }
                        break;
                    case 6:
                        //for (int i = 0; i < trozos.Length && trozos[i]!= " "; i++)
                        
                            conectados.Text = mensaje;
                        
                        break;
                }

            }
        }
        // BOTÓN PARA INICIAR LA CONEXIÓN CON EL SERVIDOR
        private void btnconexion_Click(object sender, EventArgs e)
        {
            //Creamos un IPEndPoint con el ip del servidor y puerto del servidor al que deseamos conectarnos
            IPAddress direc = IPAddress.Parse("10.4.119.5");//192.168.56.102, 10.4.119.5
            IPEndPoint ipep = new IPEndPoint(direc, 50007);//9040, 50007

            //Creamos el socket 
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                //Conexión con el servidor
                server.Connect(ipep);
                this.BackColor = Color.Green;
                MessageBox.Show("Conectado");
                conexion = true;
                //Pongo en marcha el thread que atenderá los mensajes del servidor
                //ThreadStart ts = delegate { AtenderServidor(); };
                //atender = new Thread(ts);
                //atender.Start();

            }
            catch (SocketException ex)
            {
                //Si hay excepcion imprimimos error y salimos del programa con return 
                MessageBox.Show("No he podido conectar con el servidor");
                return;
            }
            ThreadStart threadst = delegate { AtenderServidor(); };
            atender = new Thread(threadst);
            atender.Start();
        }

        // BOTON PARA INICIAR SESIÓN
        private void btnlogin_Click(object sender, EventArgs e)
        {
            string mensaje = "1/" + userlogintxt.Text + "/" + passwordlogintxt.Text;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            //byte[] msg2 = new byte[512];
            //int bytesRecibidos = server.Receive(msg2);
            //string respuesta = Encoding.ASCII.GetString(msg2, 0, bytesRecibidos).Trim('\0');  // Limpiar la respuesta


            //    MessageBox.Show(respuesta);
            ////else if (respuesta == "ERROR AL INSERTAR EL NUEVO USUARIO")
            ////    MessageBox.Show("ERROR AL INSERTAR EL NUEVO USUARIO");
            ////else if (respuesta == "ERROR USUARIO CON LA MISMA CUENTA")
            ////    MessageBox.Show("ERROR USUARIO CON LA MISMA CUENTA");

            //if (respuesta == "El usuario y/o la contrase￱a no son correctos") 
            //{ 
            //}
            //else
            //{
            //    Form2 form2 = new Form2(server);
            //    form2.Show();

            //}
        }

        //BOTÓN PARA REGISTRARSE
        private void btnregister_Click(object sender, EventArgs e)
        {
            string mensaje = "2/" + userlogintxt.Text + "/" + passwordlogintxt.Text + "/" + PLAYERNAME.Text;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            //byte[] msg2 = new byte[512];
            //int bytesRecibidos = server.Receive(msg2);
            //string respuesta = Encoding.ASCII.GetString(msg2, 0, bytesRecibidos).Trim('\0');  // Limpiar la respuesta

            //MessageBox.Show(respuesta);

            //if(respuesta== "No se han obtenido datos")
            //{

            //}
            //else
            //{
            //    Form2 f2 = new Form2(server);
            //    f2.Show();
            //}
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Ver_btn_Click(object sender, EventArgs e)
        {
            string mensaje = "6/";
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            //byte[] msg2 = new byte[512];
            //int bytesRecibidos = server.Receive(msg2);
            //string respuesta = Encoding.ASCII.GetString(msg2, 0, bytesRecibidos).Trim('\0');  // Limpiar la respuesta

            //conectados.Text = respuesta;
        }

        private void Desconectar_Click(object sender, EventArgs e)
        {
            string mensaje = "0/";
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);


           
        }
    }

    //BOTÓN DE CONSULTA 1

    //BOTÓN DE CONSULTA 2

    //BOTÓN DE CONSULTA 3



}

