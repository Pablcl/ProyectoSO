namespace version_1
{
    partial class FormConexion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnconexion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PLAYERNAME = new System.Windows.Forms.TextBox();
            this.btnregister = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.passwordlogintxt = new System.Windows.Forms.TextBox();
            this.userlogintxt = new System.Windows.Forms.TextBox();
            this.conectados = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewConectados = new System.Windows.Forms.DataGridView();
            this.Desconectar = new System.Windows.Forms.Button();
            this.Ver_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InvitarBtn = new System.Windows.Forms.Button();
            this.buttonDesconn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConectados)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.btnconexion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(52, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(313, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Antes de nada, ¡inicia la conexión!";
            // 
            // btnconexion
            // 
            this.btnconexion.Location = new System.Drawing.Point(171, 37);
            this.btnconexion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnconexion.Name = "btnconexion";
            this.btnconexion.Size = new System.Drawing.Size(117, 38);
            this.btnconexion.TabIndex = 1;
            this.btnconexion.Text = "Conéctate";
            this.btnconexion.UseVisualStyleBackColor = true;
            this.btnconexion.Click += new System.EventHandler(this.btnconexion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 52);
            this.label3.TabIndex = 2;
            this.label3.Text = "          ";
            // 
            // PLAYERNAME
            // 
            this.PLAYERNAME.Location = new System.Drawing.Point(24, 34);
            this.PLAYERNAME.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PLAYERNAME.Name = "PLAYERNAME";
            this.PLAYERNAME.Size = new System.Drawing.Size(133, 22);
            this.PLAYERNAME.TabIndex = 2;
            // 
            // btnregister
            // 
            this.btnregister.Location = new System.Drawing.Point(223, 375);
            this.btnregister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(117, 42);
            this.btnregister.TabIndex = 3;
            this.btnregister.Text = "Registrarse";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(100, 375);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(117, 42);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Iniciar sesión";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // passwordlogintxt
            // 
            this.passwordlogintxt.Location = new System.Drawing.Point(24, 21);
            this.passwordlogintxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordlogintxt.Name = "passwordlogintxt";
            this.passwordlogintxt.Size = new System.Drawing.Size(133, 22);
            this.passwordlogintxt.TabIndex = 2;
            // 
            // userlogintxt
            // 
            this.userlogintxt.Location = new System.Drawing.Point(24, 20);
            this.userlogintxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userlogintxt.Name = "userlogintxt";
            this.userlogintxt.Size = new System.Drawing.Size(133, 22);
            this.userlogintxt.TabIndex = 2;
            // 
            // conectados
            // 
            this.conectados.AutoSize = true;
            this.conectados.Location = new System.Drawing.Point(16, 28);
            this.conectados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conectados.Name = "conectados";
            this.conectados.Size = new System.Drawing.Size(83, 16);
            this.conectados.TabIndex = 2;
            this.conectados.Text = "Conectados:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Controls.Add(this.dataGridViewConectados);
            this.groupBox3.Controls.Add(this.Desconectar);
            this.groupBox3.Controls.Add(this.conectados);
            this.groupBox3.Location = new System.Drawing.Point(5, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(251, 274);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de los conectados";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dataGridViewConectados
            // 
            this.dataGridViewConectados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConectados.Location = new System.Drawing.Point(4, 63);
            this.dataGridViewConectados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewConectados.Name = "dataGridViewConectados";
            this.dataGridViewConectados.RowHeadersWidth = 51;
            this.dataGridViewConectados.Size = new System.Drawing.Size(239, 154);
            this.dataGridViewConectados.TabIndex = 5;
            // 
            // Desconectar
            // 
            this.Desconectar.Location = new System.Drawing.Point(293, 422);
            this.Desconectar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Desconectar.Name = "Desconectar";
            this.Desconectar.Size = new System.Drawing.Size(100, 28);
            this.Desconectar.TabIndex = 4;
            this.Desconectar.Text = "Desconectar";
            this.Desconectar.UseVisualStyleBackColor = true;
            this.Desconectar.Click += new System.EventHandler(this.buttonDesconn_Click);
            // 
            // Ver_btn
            // 
            this.Ver_btn.Location = new System.Drawing.Point(0, 0);
            this.Ver_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ver_btn.Name = "Ver_btn";
            this.Ver_btn.Size = new System.Drawing.Size(51, 15);
            this.Ver_btn.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(48, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "---------------- ¡BIENVENIDO! -----------------";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox4.Controls.Add(this.userlogintxt);
            this.groupBox4.Location = new System.Drawing.Point(61, 188);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(304, 49);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nombre de usuario";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox5.Controls.Add(this.passwordlogintxt);
            this.groupBox5.Location = new System.Drawing.Point(61, 241);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(304, 49);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Contraseña";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox6.Controls.Add(this.PLAYERNAME);
            this.groupBox6.Location = new System.Drawing.Point(61, 294);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(304, 68);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Si eres nuevo, introduce también un nuveo nombre de jugador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(41, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "---- Ingrese los datos e indique la opción -----";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.InvitarBtn);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.Ver_btn);
            this.panel1.Location = new System.Drawing.Point(431, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 320);
            this.panel1.TabIndex = 17;
            // 
            // InvitarBtn
            // 
            this.InvitarBtn.Location = new System.Drawing.Point(139, 282);
            this.InvitarBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InvitarBtn.Name = "InvitarBtn";
            this.InvitarBtn.Size = new System.Drawing.Size(117, 34);
            this.InvitarBtn.TabIndex = 6;
            this.InvitarBtn.Text = "Invitar";
            this.InvitarBtn.UseVisualStyleBackColor = true;
            this.InvitarBtn.Click += new System.EventHandler(this.InvitarBtn_Click);
            // 
            // buttonDesconn
            // 
            this.buttonDesconn.Location = new System.Drawing.Point(569, 375);
            this.buttonDesconn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDesconn.Name = "buttonDesconn";
            this.buttonDesconn.Size = new System.Drawing.Size(117, 42);
            this.buttonDesconn.TabIndex = 18;
            this.buttonDesconn.Text = "Desconectarse";
            this.buttonDesconn.UseVisualStyleBackColor = true;
            this.buttonDesconn.Click += new System.EventHandler(this.buttonDesconn_Click);
            // 
            // FormConexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(788, 468);
            this.Controls.Add(this.buttonDesconn);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormConexion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConectados)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnconexion;
        private System.Windows.Forms.TextBox passwordlogintxt;
        private System.Windows.Forms.TextBox userlogintxt;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.TextBox PLAYERNAME;
        private System.Windows.Forms.Label conectados;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Ver_btn;
        private System.Windows.Forms.Button Desconectar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDesconn;
        private System.Windows.Forms.DataGridView dataGridViewConectados;
        private System.Windows.Forms.Button InvitarBtn;
    }
}

