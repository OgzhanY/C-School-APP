namespace Gazi.KazanMYO.OkulAPP
{
    partial class SinifBul
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
            this.txtSinifAdBul = new System.Windows.Forms.TextBox();
            this.btnSinifAdBul = new System.Windows.Forms.Button();
            this.lblSinifAdBul = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSinifAdBul
            // 
            this.txtSinifAdBul.Location = new System.Drawing.Point(170, 64);
            this.txtSinifAdBul.Name = "txtSinifAdBul";
            this.txtSinifAdBul.Size = new System.Drawing.Size(100, 20);
            this.txtSinifAdBul.TabIndex = 0;
            // 
            // btnSinifAdBul
            // 
            this.btnSinifAdBul.Location = new System.Drawing.Point(152, 108);
            this.btnSinifAdBul.Name = "btnSinifAdBul";
            this.btnSinifAdBul.Size = new System.Drawing.Size(59, 23);
            this.btnSinifAdBul.TabIndex = 1;
            this.btnSinifAdBul.Text = "Ara";
            this.btnSinifAdBul.UseVisualStyleBackColor = true;
            this.btnSinifAdBul.Click += new System.EventHandler(this.btnSinifAdBul_Click);
            // 
            // lblSinifAdBul
            // 
            this.lblSinifAdBul.AutoSize = true;
            this.lblSinifAdBul.Location = new System.Drawing.Point(99, 67);
            this.lblSinifAdBul.Name = "lblSinifAdBul";
            this.lblSinifAdBul.Size = new System.Drawing.Size(45, 13);
            this.lblSinifAdBul.TabIndex = 2;
            this.lblSinifAdBul.Text = "Sınıf Adı";
            // 
            // SinifBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 182);
            this.Controls.Add(this.lblSinifAdBul);
            this.Controls.Add(this.btnSinifAdBul);
            this.Controls.Add(this.txtSinifAdBul);
            this.Name = "SinifBul";
            this.Text = "Sinif Ara";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSinifAdBul;
        private System.Windows.Forms.Button btnSinifAdBul;
        private System.Windows.Forms.Label lblSinifAdBul;
    }
}