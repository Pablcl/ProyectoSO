namespace version_1
{
    partial class Form1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PLAYERNAME = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnregister = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordlogintxt = new System.Windows.Forms.TextBox();
            this.userlogintxt = new System.Windows.Forms.TextBox();
            this.conectados = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Ver_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnconexion);
            this.groupBox1.Location = new System.Drawing.Point(17, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(266, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Antes de nada, inicia la conexión!";
            // 
            // btnconexion
            // 
            this.btnconexion.Location = new System.Drawing.Point(173, 15);
            this.btnconexion.Margin = new System.Windows.Forms.Padding(2);
            this.btnconexion.Name = "btnconexion";
            this.btnconexion.Size = new System.Drawing.Size(76, 31);
            this.btnconexion.TabIndex = 1;
            this.btnconexion.Text = "Conéctate";
            this.btnconexion.UseVisualStyleBackColor = true;
            this.btnconexion.Click += new System.EventHandler(this.btnconexion_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PLAYERNAME);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnregister);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnlogin);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.passwordlogintxt);
            this.groupBox2.Controls.Add(this.userlogintxt);
            this.groupBox2.Location = new System.Drawing.Point(17, 88);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(235, 310);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingresa datos y selecciona opción";
            // 
            // PLAYERNAME
            // 
            this.PLAYERNAME.Location = new System.Drawing.Point(47, 184);
            this.PLAYERNAME.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PLAYERNAME.Name = "PLAYERNAME";
            this.PLAYERNAME.Size = new System.Drawing.Size(76, 20);
            this.PLAYERNAME.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "nombre jugador(si eres nuevo usuario)";
            // 
            // btnregister
            // 
            this.btnregister.Location = new System.Drawing.Point(136, 261);
            this.btnregister.Margin = new System.Windows.Forms.Padding(2);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(88, 34);
            this.btnregister.TabIndex = 3;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(136, 223);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(88, 34);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Iniciar sesión";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de usuario";
            // 
            // passwordlogintxt
            // 
            this.passwordlogintxt.Location = new System.Drawing.Point(47, 114);
            this.passwordlogintxt.Margin = new System.Windows.Forms.Padding(2);
            this.passwordlogintxt.Name = "passwordlogintxt";
            this.passwordlogintxt.Size = new System.Drawing.Size(101, 20);
            this.passwordlogintxt.TabIndex = 2;
            // 
            // userlogintxt
            // 
            this.userlogintxt.Location = new System.Drawing.Point(47, 67);
            this.userlogintxt.Margin = new System.Windows.Forms.Padding(2);
            this.userlogintxt.Name = "userlogintxt";
            this.userlogintxt.Size = new System.Drawing.Size(101, 20);
            this.userlogintxt.TabIndex = 2;
            // 
            // conectados
            // 
            this.conectados.AutoSize = true;
            this.conectados.Location = new System.Drawing.Point(23, 43);
            this.conectados.Name = "conectados";
            this.conectados.Size = new System.Drawing.Size(75, 15);
            this.conectados.TabIndex = 2;
            this.conectados.Text = "Conectados:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Ver_btn);
            this.groupBox3.Controls.Add(this.conectados);
            this.groupBox3.Location = new System.Drawing.Point(298, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(301, 382);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de los conectados";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // Ver_btn
            // 
            this.Ver_btn.Location = new System.Drawing.Point(148, 76);
            this.Ver_btn.Name = "Ver_btn";
            this.Ver_btn.Size = new System.Drawing.Size(75, 23);
            this.Ver_btn.TabIndex = 3;
            this.Ver_btn.Text = "Ver";
            this.Ver_btn.UseVisualStyleBackColor = true;
            this.Ver_btn.Click += new System.EventHandler(this.Ver_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 406);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnconexion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordlogintxt;
        private System.Windows.Forms.TextBox userlogintxt;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PLAYERNAME;
        private System.Windows.Forms.Label conectados;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Ver_btn;
    }
}

