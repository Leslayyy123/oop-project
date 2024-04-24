namespace oop_project
{
    partial class RequestRetrieval
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
            pictureBox1 = new PictureBox();
            dtpLost = new DateTimePicker();
            tbxLocation = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label15 = new Label();
            label14 = new Label();
            tbxName = new TextBox();
            tbxCourse = new TextBox();
            tbxContact = new TextBox();
            label13 = new Label();
            cbxYear = new ComboBox();
            label8 = new Label();
            button1 = new Button();
            btnUpload = new Button();
            btnSubmit = new Button();
            btnBack = new Button();
            lblItemName = new Label();
            lblDescrip = new Label();
            lblType = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LavenderBlush;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(1284, 121);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(263, 251);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // dtpLost
            // 
            dtpLost.Location = new Point(292, 131);
            dtpLost.Name = "dtpLost";
            dtpLost.Size = new Size(332, 27);
            dtpLost.TabIndex = 33;
            // 
            // tbxLocation
            // 
            tbxLocation.Location = new Point(290, 210);
            tbxLocation.Multiline = true;
            tbxLocation.Name = "tbxLocation";
            tbxLocation.Size = new Size(332, 34);
            tbxLocation.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(93, 187);
            label7.Name = "label7";
            label7.Size = new Size(186, 75);
            label7.TabIndex = 27;
            label7.Text = "LOCATION\r\n(where item may have\r\n been lost): ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(93, 131);
            label6.Name = "label6";
            label6.Size = new Size(108, 25);
            label6.TabIndex = 26;
            label6.Text = "DATE LOST: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(93, 80);
            label1.Name = "label1";
            label1.Size = new Size(441, 25);
            label1.TabIndex = 21;
            label1.Text = "PLEASE FILL OUT DETAILS TO RETRIEVE THE LOST ITEM";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(736, 347);
            label10.Name = "label10";
            label10.Size = new Size(97, 25);
            label10.TabIndex = 41;
            label10.Text = "ITEM TYPE:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(736, 273);
            label11.Name = "label11";
            label11.Size = new Size(169, 25);
            label11.TabIndex = 40;
            label11.Text = "ITEM DESCRIPTION:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(736, 201);
            label12.Name = "label12";
            label12.Size = new Size(108, 25);
            label12.TabIndex = 39;
            label12.Text = "ITEM NAME:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(44, 311);
            label3.Name = "label3";
            label3.Size = new Size(235, 25);
            label3.TabIndex = 52;
            label3.Text = "OWNER CONTACT DETAILS:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(44, 381);
            label4.Name = "label4";
            label4.Size = new Size(254, 75);
            label4.TabIndex = 53;
            label4.Text = "NAME (Last Name, First Name,\r\nMiddle Initial):\r\n:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(44, 441);
            label5.Name = "label5";
            label5.Size = new Size(82, 25);
            label5.TabIndex = 54;
            label5.Text = "COURSE:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.White;
            label15.Location = new Point(44, 501);
            label15.Name = "label15";
            label15.Size = new Size(106, 25);
            label15.TabIndex = 56;
            label15.Text = "YEAR LEVEL:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(44, 556);
            label14.Name = "label14";
            label14.Size = new Size(172, 25);
            label14.TabIndex = 57;
            label14.Text = "CONTACT NUMBER:";
            // 
            // tbxName
            // 
            tbxName.Location = new Point(304, 382);
            tbxName.Multiline = true;
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(332, 34);
            tbxName.TabIndex = 58;
            // 
            // tbxCourse
            // 
            tbxCourse.Location = new Point(304, 442);
            tbxCourse.Multiline = true;
            tbxCourse.Name = "tbxCourse";
            tbxCourse.Size = new Size(332, 34);
            tbxCourse.TabIndex = 59;
            // 
            // tbxContact
            // 
            tbxContact.Location = new Point(302, 561);
            tbxContact.Multiline = true;
            tbxContact.Name = "tbxContact";
            tbxContact.Size = new Size(332, 34);
            tbxContact.TabIndex = 61;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(736, 131);
            label13.Name = "label13";
            label13.Size = new Size(123, 25);
            label13.TabIndex = 62;
            label13.Text = "ITEM DETAILS:";
            // 
            // cbxYear
            // 
            cbxYear.FormattingEnabled = true;
            cbxYear.Items.AddRange(new object[] { "1ST YEAR", "2ND YEAR", "3RD YEAR", "4TH YEAR" });
            cbxYear.Location = new Point(304, 508);
            cbxYear.Name = "cbxYear";
            cbxYear.Size = new Size(330, 28);
            cbxYear.TabIndex = 63;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(21, 23);
            label8.Name = "label8";
            label8.Size = new Size(307, 31);
            label8.TabIndex = 64;
            label8.Text = "REQUEST RETRIEVAL FORM";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.Maroon;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(1053, 632);
            button1.Name = "button1";
            button1.Size = new Size(113, 47);
            button1.TabIndex = 65;
            button1.Text = "CLEAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.Maroon;
            btnUpload.FlatAppearance.BorderColor = Color.White;
            btnUpload.FlatAppearance.BorderSize = 2;
            btnUpload.FlatStyle = FlatStyle.Flat;
            btnUpload.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpload.ForeColor = Color.White;
            btnUpload.Location = new Point(1311, 407);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(206, 57);
            btnUpload.TabIndex = 66;
            btnUpload.Text = "UPLOAD PHOTO";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Maroon;
            btnSubmit.FlatAppearance.BorderColor = Color.White;
            btnSubmit.FlatAppearance.BorderSize = 2;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(1385, 627);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(162, 57);
            btnSubmit.TabIndex = 67;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Maroon;
            btnBack.FlatAppearance.BorderColor = Color.White;
            btnBack.FlatAppearance.BorderSize = 2;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(1199, 627);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(162, 57);
            btnBack.TabIndex = 68;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.BackColor = Color.Transparent;
            lblItemName.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblItemName.ForeColor = Color.White;
            lblItemName.Location = new Point(850, 203);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(0, 25);
            lblItemName.TabIndex = 70;
            // 
            // lblDescrip
            // 
            lblDescrip.AutoSize = true;
            lblDescrip.BackColor = Color.Transparent;
            lblDescrip.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDescrip.ForeColor = Color.White;
            lblDescrip.Location = new Point(911, 273);
            lblDescrip.Name = "lblDescrip";
            lblDescrip.Size = new Size(0, 25);
            lblDescrip.TabIndex = 71;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.BackColor = Color.Transparent;
            lblType.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblType.ForeColor = Color.White;
            lblType.Location = new Point(839, 347);
            lblType.Name = "lblType";
            lblType.Size = new Size(0, 25);
            lblType.TabIndex = 72;
            // 
            // RequestRetrieval
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            BackgroundImage = Properties.Resources.Untitled_design__13_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1600, 708);
            Controls.Add(lblType);
            Controls.Add(lblDescrip);
            Controls.Add(lblItemName);
            Controls.Add(btnBack);
            Controls.Add(btnSubmit);
            Controls.Add(btnUpload);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(cbxYear);
            Controls.Add(label13);
            Controls.Add(tbxContact);
            Controls.Add(tbxCourse);
            Controls.Add(tbxName);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(pictureBox1);
            Controls.Add(dtpLost);
            Controls.Add(tbxLocation);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label1);
            DoubleBuffered = true;
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "RequestRetrieval";
            Text = "REQUEST FORM";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private DateTimePicker dtpLost;
        private TextBox tbxLocation;
        private Label label7;
        private Label label6;
        private Label label1;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label15;
        private Label label14;
        private TextBox tbxName;
        private TextBox tbxCourse;
        private TextBox tbxContact;
        private Label label13;
        private ComboBox cbxYear;
        private Label label8;
        private Button button1;
        private Button btnUpload;
        private Button btnSubmit;
        private Button btnBack;
        private Label lblItemName;
        private Label lblDescrip;
        private Label lblType;
    }
}