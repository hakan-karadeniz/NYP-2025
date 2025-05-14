namespace NesneProje
{
    partial class main_page
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_yoneticiGiris = new System.Windows.Forms.Button();
            this.button_ogrGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_yoneticiGiris
            // 
            this.button_yoneticiGiris.BackColor = System.Drawing.Color.PowderBlue;
            this.button_yoneticiGiris.Location = new System.Drawing.Point(135, 229);
            this.button_yoneticiGiris.Name = "button_yoneticiGiris";
            this.button_yoneticiGiris.Size = new System.Drawing.Size(199, 62);
            this.button_yoneticiGiris.TabIndex = 0;
            this.button_yoneticiGiris.Text = "Yönetici Giriş";
            this.button_yoneticiGiris.UseVisualStyleBackColor = false;
            this.button_yoneticiGiris.Click += new System.EventHandler(this.button1_Click);
            this.button_yoneticiGiris.MouseLeave += new System.EventHandler(this.button_yoneticiGiris_MouseLeave);
            this.button_yoneticiGiris.MouseHover += new System.EventHandler(this.button_yoneticiGiris_MouseHover);
            // 
            // button_ogrGiris
            // 
            this.button_ogrGiris.BackColor = System.Drawing.Color.PowderBlue;
            this.button_ogrGiris.Location = new System.Drawing.Point(135, 318);
            this.button_ogrGiris.Name = "button_ogrGiris";
            this.button_ogrGiris.Size = new System.Drawing.Size(199, 62);
            this.button_ogrGiris.TabIndex = 1;
            this.button_ogrGiris.Text = "Öğrenci Giriş";
            this.button_ogrGiris.UseVisualStyleBackColor = false;
            this.button_ogrGiris.Click += new System.EventHandler(this.button2_Click);
            this.button_ogrGiris.MouseLeave += new System.EventHandler(this.button_ogrGiris_MouseLeave);
            this.button_ogrGiris.MouseHover += new System.EventHandler(this.button_ogrGiris_MouseHover);
            // 
            // main_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(472, 553);
            this.Controls.Add(this.button_ogrGiris);
            this.Controls.Add(this.button_yoneticiGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "main_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.main_page_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_yoneticiGiris;
        private System.Windows.Forms.Button button_ogrGiris;
    }
}

