namespace oop_project
{
    partial class View
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
            btnBack = new Button();
            dgvItems = new DataGridView();
            tbxSearch = new TextBox();
            btnStudent = new Button();
            btnGuest = new Button();
            cbxMonth = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderColor = Color.Maroon;
            btnBack.FlatAppearance.BorderSize = 2;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(1474, 650);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(119, 45);
            btnBack.TabIndex = 1;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgvItems
            // 
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.BackgroundColor = Color.MistyRose;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(304, 101);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersWidth = 51;
            dgvItems.Size = new Size(1289, 529);
            dgvItems.TabIndex = 2;
            dgvItems.CellContentClick += dgvItems_CellContentClick;
            // 
            // tbxSearch
            // 
            tbxSearch.BackColor = Color.Maroon;
            tbxSearch.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxSearch.ForeColor = Color.White;
            tbxSearch.Location = new Point(45, 25);
            tbxSearch.Multiline = true;
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(1559, 54);
            tbxSearch.TabIndex = 39;
            tbxSearch.Text = "Search";
            tbxSearch.Click += tbxSearch_Click;
            tbxSearch.TextChanged += tbxSearch_TextChanged;
            tbxSearch.Leave += tbxSearch_Leave;
            // 
            // btnStudent
            // 
            btnStudent.BackColor = Color.Maroon;
            btnStudent.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudent.ForeColor = Color.White;
            btnStudent.Location = new Point(27, 248);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(236, 65);
            btnStudent.TabIndex = 40;
            btnStudent.Text = "STUDENT";
            btnStudent.UseVisualStyleBackColor = false;
            btnStudent.Click += btnStudent_Click;
            // 
            // btnGuest
            // 
            btnGuest.BackColor = Color.Maroon;
            btnGuest.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuest.ForeColor = Color.White;
            btnGuest.Location = new Point(27, 349);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(236, 65);
            btnGuest.TabIndex = 41;
            btnGuest.Text = "GUEST";
            btnGuest.UseVisualStyleBackColor = false;
            btnGuest.Click += btnGuest_Click;
            // 
            // cbxMonth
            // 
            cbxMonth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxMonth.FormattingEnabled = true;
            cbxMonth.Items.AddRange(new object[] { "JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY ", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER ", "NOVEMBER", "DECEMBER" });
            cbxMonth.Location = new Point(27, 128);
            cbxMonth.Name = "cbxMonth";
            cbxMonth.Size = new Size(236, 36);
            cbxMonth.TabIndex = 71;
            cbxMonth.Text = "Search by Month";
            cbxMonth.SelectedIndexChanged += cbxMonth_SelectedIndexChanged;
            // 
            // View
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__13_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1636, 746);
            Controls.Add(cbxMonth);
            Controls.Add(btnGuest);
            Controls.Add(btnStudent);
            Controls.Add(tbxSearch);
            Controls.Add(dgvItems);
            Controls.Add(btnBack);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "View";
            Text = "View";
            Load += View_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBack;
        private DataGridView dgvItems;
        private TextBox tbxSearch;
        private Button btnStudent;
        private Button btnGuest;
        private ComboBox cbxMonth;
    }
}