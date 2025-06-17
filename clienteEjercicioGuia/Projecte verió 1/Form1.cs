using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projecte_verió_1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // conexión con la base de datos
        SqlConnection conexion = new SqlConnection("server=PAULATOLOSA33A0\\SQLEXPRESS;database=USUARIOS PRJV1; integrated security=true");

        private void btningresar_Click(object sender, EventArgs e)
        {
            // abrimos conexión con la base
            conexion.Open();
            // cadena donde se encuntra la consulta de sql obtener usuario y contraseña
            string consulta = "select * from tbleusuers where usuario='" + txtusuario.Text + "'and password='" + txtcontrasena.Text + "'";
            
            SqlCommand comando = new SqlCommand(consulta, conexion);

            // creamos variable para poder leer el contenido de la tabla
            SqlDataReader lector;
            lector = comando.ExecuteReader();

            // miramos si el usuario y contraseña introucidos coinciden con alguno de la tabla
            if (lector.HasRows == true)
            {
                // creamos objeto del fomrulario 2
                Form2 f2 = new Form2();
                // ocultamos formulario 1
                this.Hide();
                // mostramos formulario 2
                f2.Show();

            }
            else { MessageBox.Show("Usuario o contraseña incorrectos"); }

            conexion.Close();
        }
    }
}
