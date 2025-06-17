namespace version_1
{
    partial class FormPeticiones
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
            this.buttonPartida = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonInstrucciones = new System.Windows.Forms.Button();
            this.resJugador = new System.Windows.Forms.RadioButton();
            this.dia = new System.Windows.Forms.RadioButton();
            this.buscar_bto = new System.Windows.Forms.Button();
            this.idpartidaIntroducida = new System.Windows.Forms.TextBox();
            this.jugadorintrod = new System.Windows.Forms.TextBox();
            this.diaIntrod = new System.Windows.Forms.TextBox();
            this.IDpartida = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.InvitarBtn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPartida
            // 
            this.buttonPartida.Location = new System.Drawing.Point(13, 41);
            this.buttonPartida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPartida.Name = "buttonPartida";
            this.buttonPartida.Size = new System.Drawing.Size(128, 31);
            this.buttonPartida.TabIndex = 7;
            this.buttonPartida.Text = "Empezar partida";
            this.buttonPartida.UseVisualStyleBackColor = true;
            this.buttonPartida.Click += new System.EventHandler(this.buttonChat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonPartida);
            this.groupBox2.Location = new System.Drawing.Point(29, 287);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(203, 92);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Empieza una nueva partida!";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonInstrucciones);
            this.groupBox3.Location = new System.Drawing.Point(253, 287);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(192, 92);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "¿Cómo se juega a la Oca?";
            // 
            // buttonInstrucciones
            // 
            this.buttonInstrucciones.Location = new System.Drawing.Point(16, 41);
            this.buttonInstrucciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInstrucciones.Name = "buttonInstrucciones";
            this.buttonInstrucciones.Size = new System.Drawing.Size(128, 31);
            this.buttonInstrucciones.TabIndex = 0;
            this.buttonInstrucciones.Text = "Instrucciones";
            this.buttonInstrucciones.UseVisualStyleBackColor = true;
            this.buttonInstrucciones.Click += new System.EventHandler(this.buttonInstrucciones_Click);
            // 
            // resJugador
            // 
            this.resJugador.AutoSize = true;
            this.resJugador.Location = new System.Drawing.Point(53, 158);
            this.resJugador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resJugador.Name = "resJugador";
            this.resJugador.Size = new System.Drawing.Size(323, 20);
            this.resJugador.TabIndex = 2;
            this.resJugador.TabStop = true;
            this.resJugador.Text = "Detalles de las partidas que jugue con el jugador:";
            this.resJugador.UseVisualStyleBackColor = true;
            // 
            // dia
            // 
            this.dia.AutoSize = true;
            this.dia.Location = new System.Drawing.Point(53, 107);
            this.dia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dia.Name = "dia";
            this.dia.Size = new System.Drawing.Size(309, 20);
            this.dia.TabIndex = 1;
            this.dia.TabStop = true;
            this.dia.Text = "Dime el dia de las partidas que quieres buscar:";
            this.dia.UseVisualStyleBackColor = true;
            // 
            // buscar_bto
            // 
            this.buscar_bto.Location = new System.Drawing.Point(53, 198);
            this.buscar_bto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buscar_bto.Name = "buscar_bto";
            this.buscar_bto.Size = new System.Drawing.Size(128, 32);
            this.buscar_bto.TabIndex = 3;
            this.buscar_bto.Text = "Iniciar busqueda";
            this.buscar_bto.UseVisualStyleBackColor = true;
            this.buscar_bto.Click += new System.EventHandler(this.buscar_bto_Click);
            // 
            // idpartidaIntroducida
            // 
            this.idpartidaIntroducida.Location = new System.Drawing.Point(271, 81);
            this.idpartidaIntroducida.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.idpartidaIntroducida.Name = "idpartidaIntroducida";
            this.idpartidaIntroducida.Size = new System.Drawing.Size(129, 22);
            this.idpartidaIntroducida.TabIndex = 6;
            // 
            // jugadorintrod
            // 
            this.jugadorintrod.Location = new System.Drawing.Point(269, 182);
            this.jugadorintrod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.jugadorintrod.Name = "jugadorintrod";
            this.jugadorintrod.Size = new System.Drawing.Size(131, 22);
            this.jugadorintrod.TabIndex = 4;
            // 
            // diaIntrod
            // 
            this.diaIntrod.Location = new System.Drawing.Point(269, 132);
            this.diaIntrod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.diaIntrod.Name = "diaIntrod";
            this.diaIntrod.Size = new System.Drawing.Size(131, 22);
            this.diaIntrod.TabIndex = 5;
            // 
            // IDpartida
            // 
            this.IDpartida.AutoSize = true;
            this.IDpartida.Location = new System.Drawing.Point(53, 55);
            this.IDpartida.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IDpartida.Name = "IDpartida";
            this.IDpartida.Size = new System.Drawing.Size(297, 20);
            this.IDpartida.TabIndex = 0;
            this.IDpartida.TabStop = true;
            this.IDpartida.Text = "Dame el ID de la partida que quieres buscar: ";
            this.IDpartida.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(25, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(440, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "------- Marca la opción deseada e introduce la información -------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(88, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "-------------------- ¡Vamos a jugar! ---------------------";
            // 
            // InvitarBtn
            // 
            this.InvitarBtn.Location = new System.Drawing.Point(43, 405);
            this.InvitarBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InvitarBtn.Name = "InvitarBtn";
            this.InvitarBtn.Size = new System.Drawing.Size(128, 33);
            this.InvitarBtn.TabIndex = 13;
            this.InvitarBtn.Text = "Invitar";
            this.InvitarBtn.UseVisualStyleBackColor = true;
            this.InvitarBtn.Click += new System.EventHandler(this.InvitarBtn_Click);
            // 
            // FormPeticiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(557, 476);
            this.Controls.Add(this.InvitarBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscar_bto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dia);
            this.Controls.Add(this.diaIntrod);
            this.Controls.Add(this.IDpartida);
            this.Controls.Add(this.idpartidaIntroducida);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.jugadorintrod);
            this.Controls.Add(this.resJugador);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPeticiones";
            this.Text = "Form2";
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonPartida;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonInstrucciones;
        private System.Windows.Forms.RadioButton resJugador;
        private System.Windows.Forms.RadioButton dia;
        private System.Windows.Forms.Button buscar_bto;
        private System.Windows.Forms.TextBox idpartidaIntroducida;
        private System.Windows.Forms.TextBox jugadorintrod;
        private System.Windows.Forms.TextBox diaIntrod;
        private System.Windows.Forms.RadioButton IDpartida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InvitarBtn;
    }
}