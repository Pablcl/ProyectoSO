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

namespace version_1             /////////PAULAAAAAAA
{
    public partial class Form1: Form
    {
        Socket server;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // BOTÓN PARA INICIAR LA CONEXIÓN CON EL SERVIDOR
        private void btnconexion_Click(object sender, EventArgs e)
        {
            //Creamos un IPEndPoint con el ip del servidor y puerto del servidor al que deseamos conectarnos
            IPAddress direc = IPAddress.Parse("192.168.56.102");
            IPEndPoint ipep = new IPEndPoint(direc, 9040);

            //Creamos el socket 
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                //Conexión con el servidor
                server.Connect(ipep);
                this.BackColor = Color.Green;
                MessageBox.Show("Conectado");

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
        }

        // BOTON PARA INICIAR SESIÓN
        private void btnlogin_Click(object sender, EventArgs e)
        {
            string mensaje = "1/" + userlogintxt.Text + "/" + passwordlogintxt.Text;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            byte[] msg2 = new byte[512];
            int bytesRecibidos = server.Receive(msg2);
            string respuesta = Encoding.ASCII.GetString(msg2, 0, bytesRecibidos).Trim('\0');  // Limpiar la respuesta

            
                MessageBox.Show(respuesta);
            //else if (respuesta == "ERROR AL INSERTAR EL NUEVO USUARIO")
            //    MessageBox.Show("ERROR AL INSERTAR EL NUEVO USUARIO");
            //else if (respuesta == "ERROR USUARIO CON LA MISMA CUENTA")
            //    MessageBox.Show("ERROR USUARIO CON LA MISMA CUENTA");

            if (respuesta == "El usuario y/o la contrase￱a no son correctos") 
            { 
            }
            else
            {
                Form2 form2 = new Form2(server);
                form2.Show();

            }
        }

        //BOTÓN PARA REGISTRARSE
        private void btnregister_Click(object sender, EventArgs e)
        {
            string mensaje = "2/" + userlogintxt.Text + "/" + passwordlogintxt.Text + "/" + PLAYERNAME.Text;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            byte[] msg2 = new byte[512];
            int bytesRecibidos = server.Receive(msg2);
            string respuesta = Encoding.ASCII.GetString(msg2, 0, bytesRecibidos).Trim('\0');  // Limpiar la respuesta

            MessageBox.Show(respuesta);

            if(respuesta== "No se han obtenido datos")
            {

            }
            else
            {
                Form2 f2 = new Form2(server);
                f2.Show();
            }
        }

        //BOTÓN DE CONSULTA 1

        //BOTÓN DE CONSULTA 2

        //BOTÓN DE CONSULTA 3



    }
}
