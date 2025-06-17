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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // jugar_btn
            // 
            this.jugar_btn.Location = new System.Drawing.Point(86, 49);
            this.jugar_btn.Name = "jugar_btn";
            this.jugar_btn.Size = new System.Drawing.Size(323, 103);
            this.jugar_btn.TabIndex = 0;
            this.jugar_btn.Text = "JUGAR";
            this.jugar_btn.UseVisualStyleBackColor = true;
            this.jugar_btn.Click += new System.EventHandler(this.jugar_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::version_1.Properties.Resources.logo_la_oca;
            this.pictureBox1.Location = new System.Drawing.Point(77, -24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 579);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1214, 668);
            this.Controls.Add(this.jugar_btn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button jugar_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}