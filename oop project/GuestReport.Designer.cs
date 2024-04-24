namespace oop_project
{
    partial class GuestReport
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
            label9 = new Label();
            btnBack = new Button();
            label8 = new Label();
            btnSubmit = new Button();
            btnUpload = new Button();
            pictureBox1 = new PictureBox();
            btnClear = new Button();
            dtpFound = new DateTimePicker();
            cbxType = new ComboBox();
            tbxLocation = new TextBox();
            tbxDescription = new TextBox();
            tbxItemName = new TextBox();
            tbxName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(1322, 547);
            label9.Name = "label9";
            label9.Size = new Size(162, 25);
            label9.TabIndex = 87;
            label9.Text = "Supports: JPG, PNG";
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBack.BackColor = Color.Maroon;
            btnBack.FlatAppearance.BorderColor = Color.White;
            btnBack.FlatAppearance.BorderSize = 2;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(1245, 671);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(162, 57);
            btnBack.TabIndex = 86;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(48, 39);
            label8.Name = "label8";
            label8.Size = new Size(292, 31);
            label8.TabIndex = 85;
            label8.Text = "REPORT LOST ITEM FORM";
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSubmit.BackColor = Color.Maroon;
            btnSubmit.FlatAppearance.BorderColor = Color.White;
            btnSubmit.FlatAppearance.BorderSize = 2;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(1426, 671);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(162, 57);
            btnSubmit.TabIndex = 84;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnUpload
            // 
            btnUpload.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpload.BackColor = Color.Maroon;
            btnUpload.FlatAppearance.BorderColor = Color.White;
            btnUpload.FlatAppearance.BorderSize = 2;
            btnUpload.FlatStyle = FlatStyle.Flat;
            btnUpload.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpload.ForeColor = Color.White;
            btnUpload.Location = new Point(1278, 487);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(206, 57);
            btnUpload.TabIndex = 83;
            btnUpload.Text = "UPLOAD PHOTO";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.BackColor = Color.LavenderBlush;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(1194, 129);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(353, 316);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 82;
            pictureBox1.TabStop = false;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClear.BackColor = Color.Maroon;
            btnClear.FlatAppearance.BorderColor = Color.White;
            btnClear.FlatAppearance.BorderSize = 2;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(745, 681);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(113, 47);
            btnClear.TabIndex = 81;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dtpFound
            // 
            dtpFound.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dtpFound.Location = new Point(526, 467);
            dtpFound.Name = "dtpFound";
            dtpFound.Size = new Size(332, 27);
            dtpFound.TabIndex = 80;
            // 
            // cbxType
            // 
            cbxType.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbxType.FormattingEnabled = true;
            cbxType.Items.AddRange(new object[] { "SCHOOL", "PERSONAL", "ELECTRONIC", "CLOTHING" });
            cbxType.Location = new Point(526, 388);
            cbxType.Name = "cbxType";
            cbxType.Size = new Size(332, 28);
            cbxType.TabIndex = 79;
            // 
            // tbxLocation
            // 
            tbxLocation.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tbxLocation.Location = new Point(526, 532);
            tbxLocation.Multiline = true;
            tbxLocation.Name = "tbxLocation";
            tbxLocation.Size = new Size(332, 34);
            tbxLocation.TabIndex = 78;
            // 
            // tbxDescription
            // 
            tbxDescription.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tbxDescription.Location = new Point(526, 314);
            tbxDescription.Multiline = true;
            tbxDescription.Name = "tbxDescription";
            tbxDescription.Size = new Size(332, 34);
            tbxDescription.TabIndex = 77;
            // 
            // tbxItemName
            // 
            tbxItemName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tbxItemName.Location = new Point(526, 245);
            tbxItemName.Multiline = true;
            tbxItemName.Name = "tbxItemName";
            tbxItemName.Size = new Size(332, 34);
            tbxItemName.TabIndex = 76;
            // 
            // tbxName
            // 
            tbxName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tbxName.Location = new Point(526, 167);
            tbxName.Multiline = true;
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(332, 34);
            tbxName.TabIndex = 75;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(157, 541);
            label7.Name = "label7";
            label7.Size = new Size(108, 25);
            label7.TabIndex = 74;
            label7.Text = "LOCATION: ";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(157, 463);
            label6.Name = "label6";
            label6.Size = new Size(130, 25);
            label6.TabIndex = 73;
            label6.Text = "DATE FOUND: ";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(157, 391);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 72;
            label5.Text = "ITEM TYPE:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(157, 313);
            label4.Name = "label4";
            label4.Size = new Size(278, 50);
            label4.TabIndex = 71;
            label4.Text = "ITEM DESCRIPTION (Color-Brand-\r\nUnique Feature/Stickers/Size):\r\n";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(157, 254);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 70;
            label3.Text = "ITEM NAME:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(157, 166);
            label2.Name = "label2";
            label2.Size = new Size(292, 50);
            label2.TabIndex = 69;
            label2.Text = "FOUND BY (Last Name, First Name,\r\nMiddle Initial):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(157, 101);
            label1.Name = "label1";
            label1.Size = new Size(453, 25);
            label1.TabIndex = 68;
            label1.Text = "PLEASE FILL OUT DETAILS TO REPORT THE ITEM FOUND";
            // 
            // GuestReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__13_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1654, 849);
            Controls.Add(label9);
            Controls.Add(btnBack);
            Controls.Add(label8);
            Controls.Add(btnSubmit);
            Controls.Add(btnUpload);
            Controls.Add(pictureBox1);
            Controls.Add(btnClear);
            Controls.Add(dtpFound);
            Controls.Add(cbxType);
            Controls.Add(tbxLocation);
            Controls.Add(tbxDescription);
            Controls.Add(tbxItemName);
            Controls.Add(tbxName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "GuestReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GuestReport";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Button btnBack;
        private Label label8;
        private Button btnSubmit;
        private Button btnUpload;
        private PictureBox pictureBox1;
        private Button btnClear;
        private DateTimePicker dtpFound;
        private ComboBox cbxType;
        private TextBox tbxLocation;
        private TextBox tbxDescription;
        private TextBox tbxItemName;
        private TextBox tbxName;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}