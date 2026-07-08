namespace PharmacyManagenmentSystem
{
    partial class AddOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrder));
            this.label3 = new System.Windows.Forms.Label();
            this.NamecomboBox = new System.Windows.Forms.ComboBox();
            this.TypecomboBox = new System.Windows.Forms.ComboBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GetTotalbtn = new System.Windows.Forms.Button();
            this.SubTotaltextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.QuantitytextBox = new System.Windows.Forms.TextBox();
            this.PricetextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Nextbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.Resetbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(35, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Medicine Type";
            // 
            // NamecomboBox
            // 
            this.NamecomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamecomboBox.FormattingEnabled = true;
            this.NamecomboBox.Location = new System.Drawing.Point(247, 78);
            this.NamecomboBox.Name = "NamecomboBox";
            this.NamecomboBox.Size = new System.Drawing.Size(274, 32);
            this.NamecomboBox.TabIndex = 33;
            this.NamecomboBox.SelectedIndexChanged += new System.EventHandler(this.NamecomboBox_SelectedIndexChanged);
            // 
            // TypecomboBox
            // 
            this.TypecomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypecomboBox.FormattingEnabled = true;
            this.TypecomboBox.Items.AddRange(new object[] {
            "Vitamin",
            "Antibiotic",
            "Painkiller"});
            this.TypecomboBox.Location = new System.Drawing.Point(247, 38);
            this.TypecomboBox.Name = "TypecomboBox";
            this.TypecomboBox.Size = new System.Drawing.Size(274, 32);
            this.TypecomboBox.TabIndex = 41;
            this.TypecomboBox.SelectedIndexChanged += new System.EventHandler(this.TypecomboBox_SelectedIndexChanged);
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(277, 541);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(160, 50);
            this.AddBtn.TabIndex = 62;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.GetTotalbtn);
            this.panel1.Controls.Add(this.SubTotaltextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.QuantitytextBox);
            this.panel1.Controls.Add(this.PricetextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.NamecomboBox);
            this.panel1.Controls.Add(this.TypecomboBox);
            this.panel1.Location = new System.Drawing.Point(42, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 312);
            this.panel1.TabIndex = 0;
            // 
            // GetTotalbtn
            // 
            this.GetTotalbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetTotalbtn.Location = new System.Drawing.Point(377, 251);
            this.GetTotalbtn.Name = "GetTotalbtn";
            this.GetTotalbtn.Size = new System.Drawing.Size(132, 46);
            this.GetTotalbtn.TabIndex = 64;
            this.GetTotalbtn.Text = "GetTotal";
            this.GetTotalbtn.UseVisualStyleBackColor = true;
            this.GetTotalbtn.Click += new System.EventHandler(this.GetTotalbtn_Click);
            // 
            // SubTotaltextBox
            // 
            this.SubTotaltextBox.Location = new System.Drawing.Point(247, 198);
            this.SubTotaltextBox.Name = "SubTotaltextBox";
            this.SubTotaltextBox.ReadOnly = true;
            this.SubTotaltextBox.Size = new System.Drawing.Size(274, 30);
            this.SubTotaltextBox.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(35, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 30);
            this.label5.TabIndex = 65;
            this.label5.Text = "Subtotal";
            // 
            // QuantitytextBox
            // 
            this.QuantitytextBox.Location = new System.Drawing.Point(247, 120);
            this.QuantitytextBox.Name = "QuantitytextBox";
            this.QuantitytextBox.Size = new System.Drawing.Size(274, 30);
            this.QuantitytextBox.TabIndex = 64;
            // 
            // PricetextBox
            // 
            this.PricetextBox.Location = new System.Drawing.Point(247, 157);
            this.PricetextBox.Name = "PricetextBox";
            this.PricetextBox.ReadOnly = true;
            this.PricetextBox.Size = new System.Drawing.Size(274, 30);
            this.PricetextBox.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(35, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 30);
            this.label4.TabIndex = 44;
            this.label4.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(35, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 30);
            this.label2.TabIndex = 43;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(35, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 30);
            this.label1.TabIndex = 42;
            this.label1.Text = "Medicine Name";
            // 
            // Nextbtn
            // 
            this.Nextbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nextbtn.Location = new System.Drawing.Point(788, 541);
            this.Nextbtn.Name = "Nextbtn";
            this.Nextbtn.Size = new System.Drawing.Size(160, 50);
            this.Nextbtn.TabIndex = 63;
            this.Nextbtn.Text = "Next";
            this.Nextbtn.UseVisualStyleBackColor = true;
            this.Nextbtn.Click += new System.EventHandler(this.Nextbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(676, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(501, 312);
            this.dataGridView1.TabIndex = 64;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(146, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.title.Location = new System.Drawing.Point(320, 63);
            this.title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(670, 52);
            this.title.TabIndex = 65;
            this.title.Text = "Pharmacy Management  System";
            // 
            // Resetbtn
            // 
            this.Resetbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resetbtn.Location = new System.Drawing.Point(546, 541);
            this.Resetbtn.Margin = new System.Windows.Forms.Padding(6);
            this.Resetbtn.Name = "Resetbtn";
            this.Resetbtn.Size = new System.Drawing.Size(160, 49);
            this.Resetbtn.TabIndex = 67;
            this.Resetbtn.Text = "Reset";
            this.Resetbtn.UseVisualStyleBackColor = true;
            this.Resetbtn.Click += new System.EventHandler(this.Resetbtn_Click);
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1229, 626);
            this.Controls.Add(this.Resetbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Nextbtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacy";
            this.Load += new System.EventHandler(this.AddOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox NamecomboBox;
        private System.Windows.Forms.ComboBox TypecomboBox;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PricetextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Nextbtn;
        private System.Windows.Forms.TextBox QuantitytextBox;
        private System.Windows.Forms.Button GetTotalbtn;
        private System.Windows.Forms.TextBox SubTotaltextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button Resetbtn;
    }
}