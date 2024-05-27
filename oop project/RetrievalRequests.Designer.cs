namespace oop_project
{
    partial class RetrievalRequests
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvRequest = new DataGridView();
            btnAccept = new Button();
            btnDeny = new Button();
            btnBack = new Button();
            btnGuest = new Button();
            btnStudent = new Button();
            tbxSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvRequest).BeginInit();
            SuspendLayout();
            // 
            // dgvRequest
            // 
            dgvRequest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRequest.BackgroundColor = Color.MistyRose;
            dgvRequest.BorderStyle = BorderStyle.None;
            dgvRequest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvRequest.DefaultCellStyle = dataGridViewCellStyle1;
            dgvRequest.GridColor = Color.Black;
            dgvRequest.Location = new Point(297, 102);
            dgvRequest.Name = "dgvRequest";
            dgvRequest.ReadOnly = true;
            dgvRequest.RowHeadersWidth = 51;
            dgvRequest.Size = new Size(1286, 493);
            dgvRequest.TabIndex = 0;
            dgvRequest.CellContentClick += dgvRequest_CellContentClick;
            // 
            // btnAccept
            // 
            btnAccept.FlatAppearance.BorderColor = Color.Maroon;
            btnAccept.FlatAppearance.BorderSize = 2;
            btnAccept.FlatStyle = FlatStyle.Flat;
            btnAccept.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccept.Location = new Point(945, 630);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(197, 62);
            btnAccept.TabIndex = 1;
            btnAccept.Text = "ACCEPT";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnDeny
            // 
            btnDeny.FlatAppearance.BorderColor = Color.Maroon;
            btnDeny.FlatAppearance.BorderSize = 2;
            btnDeny.FlatStyle = FlatStyle.Flat;
            btnDeny.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeny.Location = new Point(1166, 630);
            btnDeny.Name = "btnDeny";
            btnDeny.Size = new Size(197, 62);
            btnDeny.TabIndex = 2;
            btnDeny.Text = "DENY";
            btnDeny.UseVisualStyleBackColor = true;
            btnDeny.Click += btnDeny_Click;
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderColor = Color.Maroon;
            btnBack.FlatAppearance.BorderSize = 2;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(1386, 630);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(197, 62);
            btnBack.TabIndex = 3;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnGuest
            // 
            btnGuest.BackColor = Color.Maroon;
            btnGuest.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuest.ForeColor = Color.White;
            btnGuest.Location = new Point(29, 344);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(236, 65);
            btnGuest.TabIndex = 43;
            btnGuest.Text = "GUEST";
            btnGuest.UseVisualStyleBackColor = false;
            btnGuest.Click += btnGuest_Click;
            // 
            // btnStudent
            // 
            btnStudent.BackColor = Color.Maroon;
            btnStudent.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudent.ForeColor = Color.White;
            btnStudent.Location = new Point(29, 243);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(236, 65);
            btnStudent.TabIndex = 42;
            btnStudent.Text = "STUDENT";
            btnStudent.UseVisualStyleBackColor = false;
            btnStudent.Click += btnStudent_Click;
            // 
            // tbxSearch
            // 
            tbxSearch.BackColor = Color.Maroon;
            tbxSearch.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxSearch.ForeColor = Color.White;
            tbxSearch.Location = new Point(29, 29);
            tbxSearch.Multiline = true;
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(1559, 54);
            tbxSearch.TabIndex = 44;
            tbxSearch.Text = "Search";
            tbxSearch.Click += tbxSearch_Click;
            tbxSearch.TextChanged += tbxSearch_TextChanged;
            tbxSearch.Leave += tbxSearch_Leave;
            // 
            // RetrievalRequests
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design__13_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1636, 746);
            Controls.Add(tbxSearch);
            Controls.Add(btnGuest);
            Controls.Add(btnStudent);
            Controls.Add(btnBack);
            Controls.Add(btnDeny);
            Controls.Add(btnAccept);
            Controls.Add(dgvRequest);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "RetrievalRequests";
            Text = "RetrievalRequests";
       //     Load += RetrievalRequests_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRequest).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRequest;
        private Button btnAccept;
        private Button btnDeny;
        private Button btnBack;
        private Button btnGuest;
        private Button btnStudent;
        private TextBox tbxSearch;
    }
}