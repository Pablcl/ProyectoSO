using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace version_1
{
    public partial class FormPeticiones: System.Windows.Forms.Form
    {
        Socket server;
        public FormPeticiones(Socket server)
        {
            InitializeComponent();
            this.server = server;
        }

        private void buscar_bto_Click(object sender, EventArgs e)
        {
            if (IDpartida.Checked)
            {
                string mensaje = "3/" + idpartidaIntroducida.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                MessageBox.Show(mensaje);
            }
            else if (dia.Checked)
            {
                string mensaje = "4/" + diaIntrod.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                MessageBox.Show(mensaje);             
            }
            else
            {
                string mensaje = "5/" + jugadorintrod.Text;
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                MessageBox.Show(mensaje);
            }


        }

        private void buttonInstrucciones_Click(object sender, EventArgs e)
        {
            // Forms instrucciones juego
            this.Invoke((MethodInvoker)delegate
            {
                FormInstrucciones formInstr = new FormInstrucciones(server);
                formInstr.Show();
            });
        }

    }
}
