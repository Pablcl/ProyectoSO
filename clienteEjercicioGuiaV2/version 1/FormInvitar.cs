using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace version_1
{
    public partial class FormInvitar: System.Windows.Forms.Form
    {
        Socket server;
        private string nombreUsuario;

        public FormInvitar(Socket server)
        {
            InitializeComponent();
            this.server = server; 
        }
        

        public FormInvitar(string nombre)
        {
            InitializeComponent();
            nombreUsuario = nombre;            
        }
        private void invitBtn_Click(object sender, EventArgs e)
        {
            // Enviamos al servidor el nombre tecleado
            string invitarUsuario = dataGridViewConectados.CurrentRow.Cells[0].Value.ToString();

            string mensaje = "6/" + invitarUsuario + "/";
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            //Recibimos la respuesta del servidor
            byte[] msg3 = new byte[80];
            server.Receive(msg3);
            mensaje = Encoding.ASCII.GetString(msg3).Split('\0')[0];
            MessageBox.Show(mensaje);

            // Si el mensaje es "Invitación enviada" se cierra la ventana

            if (mensaje == "Error, no ha llegado el nombre.\n")
            {
                // Si el mensaje es "No se ha podido enviar la invitación" se muestra un mensaje de error
                MessageBox.Show("No se ha podido enviar la invitación");
            }
            else
            {
                this.Close();
            }

            // Si el mensaje es "No se ha podido enviar la invitación" se muestra un mensaje de error
            if (mensaje == "No se ha podido enviar la invitación")
            {
                MessageBox.Show("No se ha podido enviar la invitación");
            }
        }
    }
}
