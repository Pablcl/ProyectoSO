namespace version_1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IDpartida = new System.Windows.Forms.RadioButton();
            this.dia = new System.Windows.Forms.RadioButton();
            this.resJugador = new System.Windows.Forms.RadioButton();
            this.buscar_bto = new System.Windows.Forms.Button();
            this.jugadorintrod = new System.Windows.Forms.TextBox();
            this.diaIntrod = new System.Windows.Forms.TextBox();
            this.idpartidaIntroducida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IDpartida
            // 
            this.IDpartida.AutoSize = true;
            this.IDpartida.Location = new System.Drawing.Point(54, 38);
            this.IDpartida.Name = "IDpartida";
            this.IDpartida.Size = new System.Drawing.Size(297, 20);
            this.IDpartida.TabIndex = 0;
            this.IDpartida.TabStop = true;
            this.IDpartida.Text = "Dame el ID de la partida que quieres buscar: ";
            this.IDpartida.UseVisualStyleBackColor = true;
            // 
            // dia
            // 
            this.dia.AutoSize = true;
            this.dia.Location = new System.Drawing.Point(54, 83);
            this.dia.Name = "dia";
            this.dia.Size = new System.Drawing.Size(309, 20);
            this.dia.TabIndex = 1;
            this.dia.TabStop = true;
            this.dia.Text = "Dime el dia de las partidas que quieres buscar:";
            this.dia.UseVisualStyleBackColor = true;
            // 
            // resJugador
            // 
            this.resJugador.AutoSize = true;
            this.resJugador.Location = new System.Drawing.Point(54, 132);
            this.resJugador.Name = "resJugador";
            this.resJugador.Size = new System.Drawing.Size(323, 20);
            this.resJugador.TabIndex = 2;
            this.resJugador.TabStop = true;
            this.resJugador.Text = "Detalles de las partidas que jugue con el jugador:";
            this.resJugador.UseVisualStyleBackColor = true;
            // 
            // buscar_bto
            // 
            this.buscar_bto.Location = new System.Drawing.Point(54, 226);
            this.buscar_bto.Name = "buscar_bto";
            this.buscar_bto.Size = new System.Drawing.Size(75, 23);
            this.buscar_bto.TabIndex = 3;
            this.buscar_bto.Text = "Buscar";
            this.buscar_bto.UseVisualStyleBackColor = true;
            this.buscar_bto.Click += new System.EventHandler(this.buscar_bto_Click);
            // 
            // jugadorintrod
            // 
            this.jugadorintrod.Location = new System.Drawing.Point(405, 132);
            this.jugadorintrod.Name = "jugadorintrod";
            this.jugadorintrod.Size = new System.Drawing.Size(100, 22);
            this.jugadorintrod.TabIndex = 4;
            // 
            // diaIntrod
            // 
            this.diaIntrod.Location = new System.Drawing.Point(405, 83);
            this.diaIntrod.Name = "diaIntrod";
            this.diaIntrod.Size = new System.Drawing.Size(100, 22);
            this.diaIntrod.TabIndex = 5;
            // 
            // idpartidaIntroducida
            // 
            this.idpartidaIntroducida.Location = new System.Drawing.Point(362, 38);
            this.idpartidaIntroducida.Name = "idpartidaIntroducida";
            this.idpartidaIntroducida.Size = new System.Drawing.Size(100, 22);
            this.idpartidaIntroducida.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.idpartidaIntroducida);
            this.Controls.Add(this.diaIntrod);
            this.Controls.Add(this.jugadorintrod);
            this.Controls.Add(this.buscar_bto);
            this.Controls.Add(this.resJugador);
            this.Controls.Add(this.dia);
            this.Controls.Add(this.IDpartida);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton IDpartida;
        private System.Windows.Forms.RadioButton dia;
        private System.Windows.Forms.RadioButton resJugador;
        private System.Windows.Forms.Button buscar_bto;
        private System.Windows.Forms.TextBox jugadorintrod;
        private System.Windows.Forms.TextBox diaIntrod;
        private System.Windows.Forms.TextBox idpartidaIntroducida;
    }
}