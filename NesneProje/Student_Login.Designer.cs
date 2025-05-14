namespace NesneProje
{
    partial class Student_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Login));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_stdNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_stdtc = new System.Windows.Forms.TextBox();
            this.button_enter = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student No       :";
            // 
            // textBox_stdNo
            // 
            this.textBox_stdNo.Location = new System.Drawing.Point(262, 279);
            this.textBox_stdNo.Name = "textBox_stdNo";
            this.textBox_stdNo.Size = new System.Drawing.Size(100, 22);
            this.textBox_stdNo.TabIndex = 1;
            this.textBox_stdNo.TextChanged += new System.EventHandler(this.textBox_stdNo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student Tc :";
            // 
            // textBox_stdtc
            // 
            this.textBox_stdtc.Location = new System.Drawing.Point(262, 327);
            this.textBox_stdtc.Name = "textBox_stdtc";
            this.textBox_stdtc.Size = new System.Drawing.Size(100, 22);
            this.textBox_stdtc.TabIndex = 3;
            this.textBox_stdtc.TextChanged += new System.EventHandler(this.textBox_stdParola_TextChanged);
            // 
            // button_enter
            // 
            this.button_enter.BackColor = System.Drawing.Color.PowderBlue;
            this.button_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_enter.Location = new System.Drawing.Point(199, 385);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(90, 40);
            this.button_enter.TabIndex = 4;
            this.button_enter.Text = "ENTER";
            this.button_enter.UseVisualStyleBackColor = false;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.PowderBlue;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_back.Location = new System.Drawing.Point(12, 501);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 40);
            this.button_back.TabIndex = 5;
            this.button_back.Text = "BACK";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(182, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Student_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(472, 553);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_enter);
            this.Controls.Add(this.textBox_stdtc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_stdNo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Student_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Login";
            this.Load += new System.EventHandler(this.Student_Login_Load);
            this.MouseLeave += new System.EventHandler(this.Student_Login_MouseLeave);
            this.MouseHover += new System.EventHandler(this.Student_Login_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_stdNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_stdtc;
        private System.Windows.Forms.Button button_enter;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}