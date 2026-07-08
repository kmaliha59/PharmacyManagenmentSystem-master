namespace PharmacyManagenmentSystem
{
    partial class LoginFormed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFormed));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Usernamebtn = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Passwordbtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(487, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.title.Location = new System.Drawing.Point(315, 226);
            this.title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(670, 52);
            this.title.TabIndex = 70;
            this.title.Text = "Pharmacy Management  System";
            // 
            // Loginbtn
            // 
            this.Loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.Location = new System.Drawing.Point(511, 501);
            this.Loginbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(251, 58);
            this.Loginbtn.TabIndex = 72;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(557, 411);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(339, 34);
            this.textBox2.TabIndex = 74;
            // 
            // Usernamebtn
            // 
            this.Usernamebtn.AutoSize = true;
            this.Usernamebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernamebtn.Location = new System.Drawing.Point(357, 341);
            this.Usernamebtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Usernamebtn.Name = "Usernamebtn";
            this.Usernamebtn.Size = new System.Drawing.Size(150, 36);
            this.Usernamebtn.TabIndex = 73;
            this.Usernamebtn.Text = "Username";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(557, 342);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(339, 34);
            this.textBox1.TabIndex = 76;
            // 
            // Passwordbtn
            // 
            this.Passwordbtn.AutoSize = true;
            this.Passwordbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordbtn.Location = new System.Drawing.Point(357, 411);
            this.Passwordbtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Passwordbtn.Name = "Passwordbtn";
            this.Passwordbtn.Size = new System.Drawing.Size(147, 36);
            this.Passwordbtn.TabIndex = 75;
            this.Passwordbtn.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(440, 588);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 77;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // LoginFormed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1240, 634);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Passwordbtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Usernamebtn);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.title);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginFormed";
            this.Text = "LoginFormed";
            this.Load += new System.EventHandler(this.LoginFormed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Usernamebtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Passwordbtn;
        private System.Windows.Forms.Label label1;
    }
}