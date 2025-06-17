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
    public partial class FormInstrucciones: System.Windows.Forms.Form
    {
        Socket server;
        public FormInstrucciones(Socket server)
        {
            InitializeComponent();
            this.server = server;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
