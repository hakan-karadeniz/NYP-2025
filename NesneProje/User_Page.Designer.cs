namespace NesneProje
{
    partial class User_Page
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
            this.button_lessons = new System.Windows.Forms.Button();
            this.button_stdInfo = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_lessons
            // 
            this.button_lessons.BackColor = System.Drawing.Color.PowderBlue;
            this.button_lessons.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_lessons.Location = new System.Drawing.Point(113, 215);
            this.button_lessons.Name = "button_lessons";
            this.button_lessons.Size = new System.Drawing.Size(240, 75);
            this.button_lessons.TabIndex = 0;
            this.button_lessons.Text = "Derslerim";
            this.button_lessons.UseVisualStyleBackColor = false;
            this.button_lessons.Click += new System.EventHandler(this.button_lessons_Click);
            // 
            // button_stdInfo
            // 
            this.button_stdInfo.BackColor = System.Drawing.Color.PowderBlue;
            this.button_stdInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_stdInfo.Location = new System.Drawing.Point(113, 331);
            this.button_stdInfo.Name = "button_stdInfo";
            this.button_stdInfo.Size = new System.Drawing.Size(240, 75);
            this.button_stdInfo.TabIndex = 1;
            this.button_stdInfo.Text = "Öğrenci Bilgi";
            this.button_stdInfo.UseVisualStyleBackColor = false;
            this.button_stdInfo.Click += new System.EventHandler(this.button_stdInfo_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.PowderBlue;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_back.Location = new System.Drawing.Point(12, 501);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 40);
            this.button_back.TabIndex = 2;
            this.button_back.Text = "BACK";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // User_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(472, 553);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_stdInfo);
            this.Controls.Add(this.button_lessons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "User_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_lessons;
        private System.Windows.Forms.Button button_stdInfo;
        private System.Windows.Forms.Button button_back;
    }
}