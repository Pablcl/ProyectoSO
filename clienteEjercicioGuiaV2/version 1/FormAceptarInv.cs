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

namespace version_1
{
    public partial class FormAceptarInv: System.Windows.Forms.Form
    {
        string invitador;
        Socket server;
        string NombreUsuario;
        public FormAceptarInv(Socket server, string innvitador, string nombreusr)
        {
            InitializeComponent();
            this.server = server;
            invitador = innvitador;
            NombreUsuario = nombreusr;
            label1.Text= "El jugador" + invitador + " te ha invitado a una partida.\n¿Quieres aceptar la invitación?";
        }
       
        private void AceptarBtn_Click(object sender, EventArgs e)
        {

            string mensaje = "65/yes/" + invitador + "/" + NombreUsuario;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
            this.Close();
        }

        private void RechazarBtn_Click(object sender, EventArgs e)
        {
            string mensaje = "65/no/" + invitador + "/" + NombreUsuario;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
            this.Close();   
        }
    }
}
