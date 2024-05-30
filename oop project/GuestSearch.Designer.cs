namespace oop_project
{
    partial class GuestSearch
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
            lblLocationFound = new Label();
            lblItemType = new Label();
            lblItemDescription = new Label();
            lblItemName = new Label();
            btnRequest = new Button();
            label1 = new Label();
            label13 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            btnBack = new Button();
            tbxSearch = new TextBox();
            dgvLostItem = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLostItem).BeginInit();
            SuspendLayout();
            // 
            // lblLocationFound
            // 
            lblLocationFound.AutoSize = true;
            lblLocationFound.BackColor = Color.Transparent;
            lblLocationFound.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLocationFound.ForeColor = Color.White;
            lblLocationFound.Location = new Point(211, 441);
            lblLocationFound.Name = "lblLocationFound";
            lblLocationFound.Size = new Size(0, 25);
            lblLocationFound.TabIndex = 90;
            // 
            // lblItemType
            // 
            lblItemType.AutoSize = true;
            lblItemType.BackColor = Color.Transparent;
            lblItemType.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblItemType.ForeColor = Color.White;
            lblItemType.Location = new Point(144, 364);
            lblItemType.Name = "lblItemType";
            lblItemType.Size = new Size(0, 25);
            lblItemType.TabIndex = 89;
            // 
            // lblItemDescription
            // 
            lblItemDescription.AutoSize = true;
            lblItemDescription.BackColor = Color.Transparent;
            lblItemDescription.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblItemDescription.ForeColor = Color.White;
            lblItemDescription.Location = new Point(211, 290);
            lblItemDescription.Name = "lblItemDescription";
            lblItemDescription.Size = new Size(0, 25);
            lblItemDescription.TabIndex = 88;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.BackColor = Color.Transparent;
            lblItemName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblItemName.ForeColor = Color.White;
            lblItemName.Location = new Point(150, 218);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(0, 25);
            lblItemName.TabIndex = 87;
            // 
            // btnRequest
            // 
            btnRequest.BackColor = Color.Maroon;
            btnRequest.FlatAppearance.BorderColor = Color.White;
            btnRequest.FlatAppearance.BorderSize = 2;
            btnRequest.FlatStyle = FlatStyle.Flat;
            btnRequest.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRequest.ForeColor = Color.White;
            btnRequest.Location = new Point(216, 576);
            btnRequest.Name = "btnRequest";
            btnRequest.Size = new Size(225, 57);
            btnRequest.TabIndex = 86;
            btnRequest.Text = "REQUEST RETRIEVAL";
            btnRequest.UseVisualStyleBackColor = false;
            btnRequest.Click += btnRequest_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(36, 441);
            label1.Name = "label1";
            label1.Size = new Size(170, 25);
            label1.TabIndex = 85;
            label1.Text = "LOCATION FOUND:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(30, 138);
            label13.Name = "label13";
            label13.Size = new Size(123, 25);
            label13.TabIndex = 84;
            label13.Text = "ITEM DETAILS:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(36, 364);
            label10.Name = "label10";
            label10.Size = new Size(97, 25);
            label10.TabIndex = 83;
            label10.Text = "ITEM TYPE:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(36, 290);
            label11.Name = "label11";
            label11.Size = new Size(169, 25);
            label11.TabIndex = 82;
            label11.Text = "ITEM DESCRIPTION:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(36, 218);
            label12.Name = "label12";
            label12.Size = new Size(108, 25);
            label12.TabIndex = 81;
            label12.Text = "ITEM NAME:";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Maroon;
            btnBack.FlatAppearance.BorderColor = Color.White;
            btnBack.FlatAppearance.BorderSize = 2;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(1427, 659);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(162, 57);
            btnBack.TabIndex = 80;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // tbxSearch
            // 
            tbxSearch.BackColor = Color.Maroon;
            tbxSearch.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxSearch.ForeColor = Color.White;
            tbxSearch.Location = new Point(30, 39);
            tbxSearch.Multiline = true;
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(1559, 54);
            tbxSearch.TabIndex = 79;
            tbxSearch.Text = "Search";
            tbxSearch.Click += tbxSearch_Click;
            tbxSearch.TextChanged += tbxSearch_TextChanged;
            tbxSearch.Leave += tbxSearch_Leave;
            // 
            // dgvLostItem
            // 
            dgvLostItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLostItem.BackgroundColor = Color.MistyRose;
            dgvLostItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLostItem.Location = new Point(486, 138);
            dgvLostItem.Name = "dgvLostItem";
            dgvLostItem.RowHeadersWidth = 51;
            dgvLostItem.Size = new Size(1103, 495);
            dgvLostItem.TabIndex = 78;
            dgvLostItem.SelectionChanged += dgvLostItem_SelectionChanged;
            // 
            // GuestSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__13_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1618, 755);
            Controls.Add(lblLocationFound);
            Controls.Add(lblItemType);
            Controls.Add(lblItemDescription);
            Controls.Add(lblItemName);
            Controls.Add(btnRequest);
            Controls.Add(label1);
            Controls.Add(label13);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(btnBack);
            Controls.Add(tbxSearch);
            Controls.Add(dgvLostItem);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "GuestSearch";
            Text = "GuestSearch";
            Load += GuestSearch_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLostItem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLocationFound;
        private Label lblItemType;
        private Label lblItemDescription;
        private Label lblItemName;
        private Button btnRequest;
        private Label label1;
        private Label label13;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button btnBack;
        private TextBox tbxSearch;
        private DataGridView dgvLostItem;
    }
}