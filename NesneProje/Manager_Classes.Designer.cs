namespace NesneProje
{
    partial class Manager_Classes
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
            this.button_dokuz = new System.Windows.Forms.Button();
            this.button_on = new System.Windows.Forms.Button();
            this.button_onbir = new System.Windows.Forms.Button();
            this.button_oniki = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_dokuz
            // 
            this.button_dokuz.BackColor = System.Drawing.Color.PowderBlue;
            this.button_dokuz.Location = new System.Drawing.Point(87, 117);
            this.button_dokuz.Name = "button_dokuz";
            this.button_dokuz.Size = new System.Drawing.Size(130, 130);
            this.button_dokuz.TabIndex = 0;
            this.button_dokuz.Text = "9. Sınıf";
            this.button_dokuz.UseVisualStyleBackColor = false;
            this.button_dokuz.Click += new System.EventHandler(this.button_dokuz_Click);
            // 
            // button_on
            // 
            this.button_on.BackColor = System.Drawing.Color.PowderBlue;
            this.button_on.Location = new System.Drawing.Point(261, 117);
            this.button_on.Name = "button_on";
            this.button_on.Size = new System.Drawing.Size(130, 130);
            this.button_on.TabIndex = 1;
            this.button_on.Text = "10. Sınıf";
            this.button_on.UseVisualStyleBackColor = false;
            this.button_on.Click += new System.EventHandler(this.button_on_Click);
            // 
            // button_onbir
            // 
            this.button_onbir.BackColor = System.Drawing.Color.PowderBlue;
            this.button_onbir.Location = new System.Drawing.Point(87, 286);
            this.button_onbir.Name = "button_onbir";
            this.button_onbir.Size = new System.Drawing.Size(130, 130);
            this.button_onbir.TabIndex = 2;
            this.button_onbir.Text = "11. Sınıf";
            this.button_onbir.UseVisualStyleBackColor = false;
            this.button_onbir.Click += new System.EventHandler(this.button_onbir_Click);
            // 
            // button_oniki
            // 
            this.button_oniki.BackColor = System.Drawing.Color.PowderBlue;
            this.button_oniki.Location = new System.Drawing.Point(261, 286);
            this.button_oniki.Name = "button_oniki";
            this.button_oniki.Size = new System.Drawing.Size(130, 130);
            this.button_oniki.TabIndex = 3;
            this.button_oniki.Text = "12. Sınıf";
            this.button_oniki.UseVisualStyleBackColor = false;
            this.button_oniki.Click += new System.EventHandler(this.button_oniki_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.PowderBlue;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_back.Location = new System.Drawing.Point(12, 501);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 40);
            this.button_back.TabIndex = 6;
            this.button_back.Text = "BACK";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // Manager_Classes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(472, 553);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_oniki);
            this.Controls.Add(this.button_onbir);
            this.Controls.Add(this.button_on);
            this.Controls.Add(this.button_dokuz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Manager_Classes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Classes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_dokuz;
        private System.Windows.Forms.Button button_on;
        private System.Windows.Forms.Button button_onbir;
        private System.Windows.Forms.Button button_oniki;
        private System.Windows.Forms.Button button_back;
    }
}