namespace version_1
{
    partial class Form3
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
            this.jugar_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // jugar_btn
            // 
            this.jugar_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.jugar_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.jugar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jugar_btn.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jugar_btn.ForeColor = System.Drawing.Color.IndianRed;
            this.jugar_btn.Location = new System.Drawing.Point(13, 10);
            this.jugar_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.jugar_btn.Name = "jugar_btn";
            this.jugar_btn.Size = new System.Drawing.Size(196, 60);
            this.jugar_btn.TabIndex = 0;
            this.jugar_btn.Text = "JUGAR";
            this.jugar_btn.UseVisualStyleBackColor = false;
            this.jugar_btn.Click += new System.EventHandler(this.jugar_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.jugar_btn);
            this.panel1.Location = new System.Drawing.Point(328, 196);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 78);
            this.panel1.TabIndex = 2;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(885, 488);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button jugar_btn;
        private System.Windows.Forms.Panel panel1;
    }
}