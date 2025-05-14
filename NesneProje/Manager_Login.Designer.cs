namespace NesneProje
{
    partial class Manager_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager_Login));
            this.textBox_managerName = new System.Windows.Forms.TextBox();
            this.label_mangerName = new System.Windows.Forms.Label();
            this.label_managerParola = new System.Windows.Forms.Label();
            this.textBox_managerParola = new System.Windows.Forms.TextBox();
            this.button_enter = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_managerName
            // 
            this.textBox_managerName.Location = new System.Drawing.Point(238, 272);
            this.textBox_managerName.Name = "textBox_managerName";
            this.textBox_managerName.Size = new System.Drawing.Size(100, 22);
            this.textBox_managerName.TabIndex = 0;
            this.textBox_managerName.TextChanged += new System.EventHandler(this.textBox_managerName_TextChanged);
            // 
            // label_mangerName
            // 
            this.label_mangerName.AutoSize = true;
            this.label_mangerName.Location = new System.Drawing.Point(113, 275);
            this.label_mangerName.Name = "label_mangerName";
            this.label_mangerName.Size = new System.Drawing.Size(110, 16);
            this.label_mangerName.TabIndex = 1;
            this.label_mangerName.Text = "Manager Name  :";
            // 
            // label_managerParola
            // 
            this.label_managerParola.AutoSize = true;
            this.label_managerParola.Location = new System.Drawing.Point(113, 323);
            this.label_managerParola.Name = "label_managerParola";
            this.label_managerParola.Size = new System.Drawing.Size(110, 16);
            this.label_managerParola.TabIndex = 2;
            this.label_managerParola.Text = "Manager Parola :";
            // 
            // textBox_managerParola
            // 
            this.textBox_managerParola.Location = new System.Drawing.Point(238, 323);
            this.textBox_managerParola.Name = "textBox_managerParola";
            this.textBox_managerParola.PasswordChar = '*';
            this.textBox_managerParola.Size = new System.Drawing.Size(100, 22);
            this.textBox_managerParola.TabIndex = 3;
            this.textBox_managerParola.TextChanged += new System.EventHandler(this.textBox_managerParola_TextChanged);
            // 
            // button_enter
            // 
            this.button_enter.BackColor = System.Drawing.Color.PowderBlue;
            this.button_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_enter.Location = new System.Drawing.Point(186, 400);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(90, 40);
            this.button_enter.TabIndex = 4;
            this.button_enter.Text = "ENTER";
            this.button_enter.UseVisualStyleBackColor = false;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click);
            this.button_enter.MouseLeave += new System.EventHandler(this.button_enter_MouseLeave);
            this.button_enter.MouseHover += new System.EventHandler(this.button_enter_MouseHover);
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
            this.pictureBox1.Location = new System.Drawing.Point(167, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Manager_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(472, 553);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_enter);
            this.Controls.Add(this.textBox_managerParola);
            this.Controls.Add(this.label_managerParola);
            this.Controls.Add(this.label_mangerName);
            this.Controls.Add(this.textBox_managerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Manager_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Login";
            this.Load += new System.EventHandler(this.Manager_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_managerName;
        private System.Windows.Forms.Label label_mangerName;
        private System.Windows.Forms.Label label_managerParola;
        private System.Windows.Forms.TextBox textBox_managerParola;
        private System.Windows.Forms.Button button_enter;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}