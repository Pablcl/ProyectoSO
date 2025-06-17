namespace Projecte_verió_1
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
            this.btningresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(277, 186);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(155, 54);
            this.btningresar.TabIndex = 0;
            this.btningresar.Text = "Iniciar sesión";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de usuario";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(226, 77);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(206, 31);
            this.txtusuario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Location = new System.Drawing.Point(226, 119);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.PasswordChar = '*';
            this.txtcontrasena.Size = new System.Drawing.Size(206, 31);
            this.txtcontrasena.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnlimpiar);
            this.groupBox1.Controls.Add(this.txtcontrasena);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtusuario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btningresar);
            this.groupBox1.Location = new System.Drawing.Point(49, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 274);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese los datos requeridos:";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(19, 186);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(115, 54);
            this.btnlimpiar.TabIndex = 5;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(482, 391);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(114, 47);
            this.btnsalir.TabIndex = 6;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 461);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Inicio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcontrasena;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalir;
    }
}

