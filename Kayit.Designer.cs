namespace Gazi.KazanMYO.OkulAPP
{
    partial class Kayit
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
            this.lblSinifAd = new System.Windows.Forms.Label();
            this.lblKontenjan = new System.Windows.Forms.Label();
            this.txtSinifAd = new System.Windows.Forms.TextBox();
            this.txtKontenjan = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSinifBul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSinifAd
            // 
            this.lblSinifAd.AutoSize = true;
            this.lblSinifAd.Location = new System.Drawing.Point(36, 27);
            this.lblSinifAd.Name = "lblSinifAd";
            this.lblSinifAd.Size = new System.Drawing.Size(45, 13);
            this.lblSinifAd.TabIndex = 0;
            this.lblSinifAd.Text = "Sınıf Adı";
            // 
            // lblKontenjan
            // 
            this.lblKontenjan.AutoSize = true;
            this.lblKontenjan.Location = new System.Drawing.Point(26, 74);
            this.lblKontenjan.Name = "lblKontenjan";
            this.lblKontenjan.Size = new System.Drawing.Size(55, 13);
            this.lblKontenjan.TabIndex = 1;
            this.lblKontenjan.Text = "Kontenjan";
            // 
            // txtSinifAd
            // 
            this.txtSinifAd.Location = new System.Drawing.Point(95, 24);
            this.txtSinifAd.Name = "txtSinifAd";
            this.txtSinifAd.Size = new System.Drawing.Size(130, 20);
            this.txtSinifAd.TabIndex = 2;
            // 
            // txtKontenjan
            // 
            this.txtKontenjan.Location = new System.Drawing.Point(95, 74);
            this.txtKontenjan.Name = "txtKontenjan";
            this.txtKontenjan.Size = new System.Drawing.Size(130, 20);
            this.txtKontenjan.TabIndex = 3;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(258, 14);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(58, 38);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSinifBul
            // 
            this.btnSinifBul.Location = new System.Drawing.Point(258, 63);
            this.btnSinifBul.Name = "btnSinifBul";
            this.btnSinifBul.Size = new System.Drawing.Size(58, 35);
            this.btnSinifBul.TabIndex = 5;
            this.btnSinifBul.Text = "Ara";
            this.btnSinifBul.UseVisualStyleBackColor = true;
            this.btnSinifBul.Click += new System.EventHandler(this.btnSinifBul_Click);
            // 
            // Kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 138);
            this.Controls.Add(this.btnSinifBul);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtKontenjan);
            this.Controls.Add(this.txtSinifAd);
            this.Controls.Add(this.lblKontenjan);
            this.Controls.Add(this.lblSinifAd);
            this.Name = "Kayit";
            this.Text = "Kayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSinifAd;
        private System.Windows.Forms.Label lblKontenjan;
        private System.Windows.Forms.TextBox txtSinifAd;
        private System.Windows.Forms.TextBox txtKontenjan;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSinifBul;
    }
}

