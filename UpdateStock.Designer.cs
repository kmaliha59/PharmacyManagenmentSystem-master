namespace PharmacyManagenmentSystem
{
    partial class UpdateStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateStock));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.MedicineType = new System.Windows.Forms.Label();
            this.MedicineName = new System.Windows.Forms.Label();
            this.Quanitity = new System.Windows.Forms.Label();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.TypecomboBox = new System.Windows.Forms.ComboBox();
            this.NamecomboBox = new System.Windows.Forms.ComboBox();
            this.Backbtn = new System.Windows.Forms.Button();
            this.QuantitytextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(187, 43);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.title.Location = new System.Drawing.Point(360, 84);
            this.title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(658, 52);
            this.title.TabIndex = 5;
            this.title.Text = "Pharmacy Management System";
            // 
            // MedicineType
            // 
            this.MedicineType.AutoSize = true;
            this.MedicineType.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicineType.Location = new System.Drawing.Point(281, 262);
            this.MedicineType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MedicineType.Name = "MedicineType";
            this.MedicineType.Size = new System.Drawing.Size(209, 36);
            this.MedicineType.TabIndex = 25;
            this.MedicineType.Text = "Medicine Type";
            // 
            // MedicineName
            // 
            this.MedicineName.AutoSize = true;
            this.MedicineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicineName.Location = new System.Drawing.Point(281, 330);
            this.MedicineName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MedicineName.Name = "MedicineName";
            this.MedicineName.Size = new System.Drawing.Size(220, 36);
            this.MedicineName.TabIndex = 23;
            this.MedicineName.Text = "Medicine Name";
            // 
            // Quanitity
            // 
            this.Quanitity.AutoSize = true;
            this.Quanitity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quanitity.Location = new System.Drawing.Point(281, 383);
            this.Quanitity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Quanitity.Name = "Quanitity";
            this.Quanitity.Size = new System.Drawing.Size(132, 36);
            this.Quanitity.TabIndex = 21;
            this.Quanitity.Text = "Quanitity";
            // 
            // Updatebtn
            // 
            this.Updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebtn.Location = new System.Drawing.Point(640, 506);
            this.Updatebtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(251, 58);
            this.Updatebtn.TabIndex = 71;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // TypecomboBox
            // 
            this.TypecomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypecomboBox.FormattingEnabled = true;
            this.TypecomboBox.Items.AddRange(new object[] {
            "Vitamin",
            "Antibiotic",
            "Painkiller"});
            this.TypecomboBox.Location = new System.Drawing.Point(607, 263);
            this.TypecomboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TypecomboBox.Name = "TypecomboBox";
            this.TypecomboBox.Size = new System.Drawing.Size(340, 37);
            this.TypecomboBox.TabIndex = 72;
            this.TypecomboBox.SelectedIndexChanged += new System.EventHandler(this.TypecomboBox_SelectedIndexChanged);
            // 
            // NamecomboBox
            // 
            this.NamecomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamecomboBox.FormattingEnabled = true;
            this.NamecomboBox.ItemHeight = 29;
            this.NamecomboBox.Location = new System.Drawing.Point(607, 324);
            this.NamecomboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NamecomboBox.MaxDropDownItems = 10;
            this.NamecomboBox.Name = "NamecomboBox";
            this.NamecomboBox.Size = new System.Drawing.Size(340, 37);
            this.NamecomboBox.TabIndex = 73;
            this.NamecomboBox.SelectedIndexChanged += new System.EventHandler(this.NamecomboBox_SelectedIndexChanged);
            // 
            // Backbtn
            // 
            this.Backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.Location = new System.Drawing.Point(275, 506);
            this.Backbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(251, 58);
            this.Backbtn.TabIndex = 75;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // QuantitytextBox
            // 
            this.QuantitytextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantitytextBox.Location = new System.Drawing.Point(607, 383);
            this.QuantitytextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QuantitytextBox.Name = "QuantitytextBox";
            this.QuantitytextBox.Size = new System.Drawing.Size(340, 34);
            this.QuantitytextBox.TabIndex = 76;
            // 
            // UpdateStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1240, 634);
            this.Controls.Add(this.QuantitytextBox);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.NamecomboBox);
            this.Controls.Add(this.TypecomboBox);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.MedicineType);
            this.Controls.Add(this.MedicineName);
            this.Controls.Add(this.Quanitity);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.title);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UpdateStock";
            this.Text = "UpdateStock";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label MedicineType;
        private System.Windows.Forms.Label MedicineName;
        private System.Windows.Forms.Label Quanitity;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.ComboBox TypecomboBox;
        private System.Windows.Forms.ComboBox NamecomboBox;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.TextBox QuantitytextBox;
    }
}