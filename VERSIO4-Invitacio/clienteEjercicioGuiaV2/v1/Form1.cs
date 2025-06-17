using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v1
{
    public partial class Form1: Form
    {
        Socket server;
        public Form1()
        {
            InitializeComponent();
        }

        List<Form2> formularios = new List<Form2>();


        private void btnentrar_Click(object sender, EventArgs e)
        {
            //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
            //al que deseamos conectarnos
            IPAddress direc = IPAddress.Parse("192.168.56.102");
            // a esa dirección asociamos el puerto 9050
            IPEndPoint ipep = new IPEndPoint(direc, 9050);


            //Creamos el socket 
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep);//Intentamos conectar el socket
                // creamos nuevo formulario
                //Form2 f2 = new Form2();
                // ocultamos formulario 1
                this.Hide();
                // mostramos formulario 2
                //f2.Show();


                ////pongo en marcha el thread que atenderá los mensajes del servidor
                //ThreadStart ts = delegate { AtenderServidor(); };
                //atender = new Thread(ts);
                //atender.Start();

            }
            catch (SocketException ex)
            {
                //Si hay excepcion imprimimos error y salimos del programa con return 
                MessageBox.Show("Hay un error de conexión, intentalo de nuevo");
                return;
            }
        }

        private void PonerEnMarchaFormulario()
        {
            int cont = formularios.Count;
            Form2 f = new Form2(cont, server);
            formularios.Add(f);
            f.ShowDialog();


        }



    }
}
