namespace version_1
{
    partial class FormAceptarInv
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
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.RechazarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(84, 311);
            this.AceptarBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(424, 111);
            this.AceptarBtn.TabIndex = 0;
            this.AceptarBtn.Text = "Aceptar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // RechazarBtn
            // 
            this.RechazarBtn.Location = new System.Drawing.Point(560, 311);
            this.RechazarBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RechazarBtn.Name = "RechazarBtn";
            this.RechazarBtn.Size = new System.Drawing.Size(424, 111);
            this.RechazarBtn.TabIndex = 1;
            this.RechazarBtn.Text = "Rechazar";
            this.RechazarBtn.UseVisualStyleBackColor = true;
            this.RechazarBtn.Click += new System.EventHandler(this.RechazarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // FormAceptarInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RechazarBtn);
            this.Controls.Add(this.AceptarBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAceptarInv";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AceptarBtn;
        private System.Windows.Forms.Button RechazarBtn;
        private System.Windows.Forms.Label label1;
    }
}