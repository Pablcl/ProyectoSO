using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v1
{
    public partial class Form2: Form
    {
        int f2;
        Socket server;

        public Form2(int f2, Socket server)
        {
            InitializeComponent();
            this.f2 = f2;
            this.server = server;
        }


        //private void btnsalircnx_Click(object sender, EventArgs e)
        //{
        //    ////Mensaje de desconexión
        //    //string mensaje = "0/";

        //    //byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
        //    //server.Send(msg);

        //    // Nos desconectamos
        //    this.Hide();
        //    Form1 f1 = new Form1();
        //    f1.Show();
        //    server.Shutdown(SocketShutdown.Both);
        //    server.Close();
        //}

        private void btniniciarsesion_Click(object sender, EventArgs e)
        {

        }
    }
}
