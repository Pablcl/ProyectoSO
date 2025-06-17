namespace version_1
{
    partial class FormInvitar
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
            this.dataGridViewConectados = new System.Windows.Forms.DataGridView();
            this.invitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConectados)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewConectados
            // 
            this.dataGridViewConectados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConectados.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewConectados.Name = "dataGridViewConectados";
            this.dataGridViewConectados.RowHeadersWidth = 51;
            this.dataGridViewConectados.Size = new System.Drawing.Size(220, 293);
            this.dataGridViewConectados.TabIndex = 0;
            // 
            // invitBtn
            // 
            this.invitBtn.Location = new System.Drawing.Point(59, 328);
            this.invitBtn.Name = "invitBtn";
            this.invitBtn.Size = new System.Drawing.Size(120, 23);
            this.invitBtn.TabIndex = 1;
            this.invitBtn.Text = "Hacer Invitacion";
            this.invitBtn.UseVisualStyleBackColor = true;
            this.invitBtn.Click += new System.EventHandler(this.invitBtn_Click);
            // 
            // FormInvitar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 407);
            this.Controls.Add(this.invitBtn);
            this.Controls.Add(this.dataGridViewConectados);
            this.Name = "FormInvitar";
            this.Text = "FormInvitar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConectados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewConectados;
        private System.Windows.Forms.Button invitBtn;
    }
}