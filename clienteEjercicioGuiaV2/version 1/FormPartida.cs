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

namespace version_1
{
    public partial class FormPartida : System.Windows.Forms.Form
    {
        Socket server;
        public FormPartida(Socket server)
        {
            InitializeComponent();
            this.server = server;
        }

        //CHAT


        private bool isRunning = true;
        private string invitado;
        private string anfitrion;
        private string nombreusuario;
        public string sender;
        public string message;
        public FormPartida(Socket server, string invittado, string nanfitrion, string nnombreusuario)
        {
            InitializeComponent();
            this.server = server;
            this.invitado = invittado;
            this.anfitrion = nanfitrion;
            this.nombreusuario = nnombreusuario;

            this.Text = $"Juego: invitado: {invitado} vs anfitrion: {anfitrion}";
            //lblStatus.Text = $"Connected to {opponentName}";

            //Task.Run(ListenForMessages);

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
                    string mensaje = "66/" + anfitrion + "/" + nombreusuario + "/" + txtMessage.Text;
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
    
    }
}

