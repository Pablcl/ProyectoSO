using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using v1;

namespace version_1
{
    public partial class Form3: System.Windows.Forms.Form
    {
        public Form3()
        {
            InitializeComponent();
        }

       

        private void jugar_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormConexion f1 = new FormConexion();
            f1.Show();
            
        }
    }
}
