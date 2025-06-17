namespace version_1
{
    partial class FormPartida
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
            this.chatBox = new System.Windows.Forms.RichTextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.TirarBtn = new System.Windows.Forms.Button();
            this.resDato = new System.Windows.Forms.Label();
            this.preguntaBtn = new System.Windows.Forms.Button();
            this.preguntaBox = new System.Windows.Forms.Label();
            this.ResultadoGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ResultadoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // chatBox
            // 
            this.chatBox.Location = new System.Drawing.Point(12, 326);
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(181, 140);
            this.chatBox.TabIndex = 0;
            this.chatBox.Text = "";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(24, 471);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(100, 22);
            this.txtMessage.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(118, 471);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click_1);
            // 
            // TirarBtn
            // 
            this.TirarBtn.Location = new System.Drawing.Point(12, 12);
            this.TirarBtn.Name = "TirarBtn";
            this.TirarBtn.Size = new System.Drawing.Size(112, 40);
            this.TirarBtn.TabIndex = 4;
            this.TirarBtn.Text = "Tirar dato";
            this.TirarBtn.UseVisualStyleBackColor = true;
            this.TirarBtn.Click += new System.EventHandler(this.TirarBtn_Click);
            // 
            // resDato
            // 
            this.resDato.AutoSize = true;
            this.resDato.Location = new System.Drawing.Point(22, 67);
            this.resDato.Name = "resDato";
            this.resDato.Size = new System.Drawing.Size(63, 16);
            this.resDato.TabIndex = 5;
            this.resDato.Text = "resultado";
            // 
            // preguntaBtn
            // 
            this.preguntaBtn.Location = new System.Drawing.Point(25, 112);
            this.preguntaBtn.Name = "preguntaBtn";
            this.preguntaBtn.Size = new System.Drawing.Size(128, 23);
            this.preguntaBtn.TabIndex = 6;
            this.preguntaBtn.Text = "Nueva pregunta";
            this.preguntaBtn.UseVisualStyleBackColor = true;
            this.preguntaBtn.Click += new System.EventHandler(this.preguntaBtn_Click);
            // 
            // preguntaBox
            // 
            this.preguntaBox.AutoSize = true;
            this.preguntaBox.Location = new System.Drawing.Point(22, 150);
            this.preguntaBox.MaximumSize = new System.Drawing.Size(0, 100);
            this.preguntaBox.MinimumSize = new System.Drawing.Size(0, 50);
            this.preguntaBox.Name = "preguntaBox";
            this.preguntaBox.Size = new System.Drawing.Size(44, 50);
            this.preguntaBox.TabIndex = 7;
            this.preguntaBox.Text = "label1";
            // 
            // ResultadoGrid
            // 
            this.ResultadoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultadoGrid.Location = new System.Drawing.Point(279, 67);
            this.ResultadoGrid.Name = "ResultadoGrid";
            this.ResultadoGrid.RowHeadersWidth = 51;
            this.ResultadoGrid.RowTemplate.Height = 24;
            this.ResultadoGrid.Size = new System.Drawing.Size(487, 399);
            this.ResultadoGrid.TabIndex = 8;
            // 
            // FormPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 517);
            this.Controls.Add(this.ResultadoGrid);
            this.Controls.Add(this.preguntaBox);
            this.Controls.Add(this.preguntaBtn);
            this.Controls.Add(this.resDato);
            this.Controls.Add(this.TirarBtn);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.chatBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPartida";
            this.Text = "FormChat";
            ((System.ComponentModel.ISupportInitialize)(this.ResultadoGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox chatBox;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button TirarBtn;
        private System.Windows.Forms.Label resDato;
        private System.Windows.Forms.Button preguntaBtn;
        private System.Windows.Forms.Label preguntaBox;
        private System.Windows.Forms.DataGridView ResultadoGrid;
    }
}