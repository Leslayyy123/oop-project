namespace oop_project
{
    partial class SearchItem
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
            dgvLostItem = new DataGridView();
            tbxSearch = new TextBox();
            btnBack = new Button();
            btnRequest = new Button();
            lblItemName = new Label();
            lblItemDescription = new Label();
            lblItemType = new Label();
            lblLocationFound = new Label();
            label9 = new Label();
            label13 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLostItem).BeginInit();
            SuspendLayout();
            // 
            // dgvLostItem
            // 
            dgvLostItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLostItem.BackgroundColor = Color.MistyRose;
            dgvLostItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLostItem.Location = new Point(448, 120);
            dgvLostItem.Name = "dgvLostItem";
            dgvLostItem.RowHeadersWidth = 51;
            dgvLostItem.Size = new Size(1135, 468);
            dgvLostItem.TabIndex = 37;
            // 
            // tbxSearch
            // 
            tbxSearch.BackColor = Color.Maroon;
            tbxSearch.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxSearch.ForeColor = Color.White;
            tbxSearch.Location = new Point(24, 42);
            tbxSearch.Multiline = true;
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(1559, 54);
            tbxSearch.TabIndex = 38;
            tbxSearch.Text = "Search";
            tbxSearch.TextChanged += tbxSearch_TextChanged;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Maroon;
            btnBack.FlatAppearance.BorderColor = Color.White;
            btnBack.FlatAppearance.BorderSize = 2;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(1421, 644);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(162, 57);
            btnBack.TabIndex = 67;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click_1;
            // 
            // btnRequest
            // 
            btnRequest.BackColor = Color.Maroon;
            btnRequest.FlatAppearance.BorderColor = Color.White;
            btnRequest.FlatAppearance.BorderSize = 2;
            btnRequest.FlatStyle = FlatStyle.Flat;
            btnRequest.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRequest.ForeColor = Color.White;
            btnRequest.Location = new Point(192, 531);
            btnRequest.Name = "btnRequest";
            btnRequest.Size = new Size(225, 57);
            btnRequest.TabIndex = 73;
            btnRequest.Text = "REQUEST RETRIEVAL";
            btnRequest.UseVisualStyleBackColor = false;
            btnRequest.Click += btnRequest_Click_1;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.BackColor = Color.Transparent;
            lblItemName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblItemName.ForeColor = Color.White;
            lblItemName.Location = new Point(144, 221);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(0, 25);
            lblItemName.TabIndex = 74;
            // 
            // lblItemDescription
            // 
            lblItemDescription.AutoSize = true;
            lblItemDescription.BackColor = Color.Transparent;
            lblItemDescription.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblItemDescription.ForeColor = Color.White;
            lblItemDescription.Location = new Point(205, 293);
            lblItemDescription.Name = "lblItemDescription";
            lblItemDescription.Size = new Size(0, 25);
            lblItemDescription.TabIndex = 75;
            // 
            // lblItemType
            // 
            lblItemType.AutoSize = true;
            lblItemType.BackColor = Color.Transparent;
            lblItemType.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblItemType.ForeColor = Color.White;
            lblItemType.Location = new Point(138, 367);
            lblItemType.Name = "lblItemType";
            lblItemType.Size = new Size(0, 25);
            lblItemType.TabIndex = 76;
            // 
            // lblLocationFound
            // 
            lblLocationFound.AutoSize = true;
            lblLocationFound.BackColor = Color.Transparent;
            lblLocationFound.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLocationFound.ForeColor = Color.White;
            lblLocationFound.Location = new Point(205, 444);
            lblLocationFound.Name = "lblLocationFound";
            lblLocationFound.Size = new Size(0, 25);
            lblLocationFound.TabIndex = 77;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(24, 418);
            label9.Name = "label9";
            label9.Size = new Size(170, 25);
            label9.TabIndex = 82;
            label9.Text = "LOCATION FOUND:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(24, 142);
            label13.Name = "label13";
            label13.Size = new Size(123, 25);
            label13.TabIndex = 81;
            label13.Text = "ITEM DETAILS:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(24, 358);
            label10.Name = "label10";
            label10.Size = new Size(97, 25);
            label10.TabIndex = 80;
            label10.Text = "ITEM TYPE:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(24, 284);
            label11.Name = "label11";
            label11.Size = new Size(169, 25);
            label11.TabIndex = 79;
            label11.Text = "ITEM DESCRIPTION:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(24, 212);
            label12.Name = "label12";
            label12.Size = new Size(108, 25);
            label12.TabIndex = 78;
            label12.Text = "ITEM NAME:";
            // 
            // SearchItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__13_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1618, 755);
            Controls.Add(label9);
            Controls.Add(label13);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(lblLocationFound);
            Controls.Add(lblItemType);
            Controls.Add(lblItemDescription);
            Controls.Add(lblItemName);
            Controls.Add(btnRequest);
            Controls.Add(btnBack);
            Controls.Add(tbxSearch);
            Controls.Add(dgvLostItem);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchItem";
            Text = "SEARCH FORM";
            Load += SearchItem_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLostItem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvLostItem;
        private TextBox tbxSearch;
        private Button btnBack;
        private Button btnRequest;
        private Label lblItemName;
        private Label lblItemDescription;
        private Label lblItemType;
        private Label lblLocationFound;
        private Label label9;
        private Label label13;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}