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
            this.btnregister = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordlogintxt = new System.Windows.Forms.TextBox();
            this.userlogintxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PLAYERNAME = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnconexion);
            this.groupBox1.Location = new System.Drawing.Point(23, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(354, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Antes de nada, inicia la conexión!";
            // 
            // btnconexion
            // 
            this.btnconexion.Location = new System.Drawing.Point(231, 19);
            this.btnconexion.Margin = new System.Windows.Forms.Padding(2);
            this.btnconexion.Name = "btnconexion";
            this.btnconexion.Size = new System.Drawing.Size(102, 38);
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
            this.groupBox2.Location = new System.Drawing.Point(23, 108);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(313, 381);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingresa datos y selecciona opción";
            // 
            // btnregister
            // 
            this.btnregister.Location = new System.Drawing.Point(181, 321);
            this.btnregister.Margin = new System.Windows.Forms.Padding(2);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(117, 42);
            this.btnregister.TabIndex = 3;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(181, 275);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(117, 42);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Iniciar sesión";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de usuario";
            // 
            // passwordlogintxt
            // 
            this.passwordlogintxt.Location = new System.Drawing.Point(63, 140);
            this.passwordlogintxt.Margin = new System.Windows.Forms.Padding(2);
            this.passwordlogintxt.Name = "passwordlogintxt";
            this.passwordlogintxt.Size = new System.Drawing.Size(133, 22);
            this.passwordlogintxt.TabIndex = 2;
            // 
            // userlogintxt
            // 
            this.userlogintxt.Location = new System.Drawing.Point(63, 82);
            this.userlogintxt.Margin = new System.Windows.Forms.Padding(2);
            this.userlogintxt.Name = "userlogintxt";
            this.userlogintxt.Size = new System.Drawing.Size(133, 22);
            this.userlogintxt.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "nombre jugador(si eres nuevo usuario)";
            // 
            // PLAYERNAME
            // 
            this.PLAYERNAME.Location = new System.Drawing.Point(63, 227);
            this.PLAYERNAME.Name = "PLAYERNAME";
            this.PLAYERNAME.Size = new System.Drawing.Size(100, 22);
            this.PLAYERNAME.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 500);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
    }
}

