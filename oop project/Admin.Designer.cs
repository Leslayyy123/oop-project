namespace oop_project
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            btnRetrieval = new Button();
            btnView = new Button();
            pbxClose = new PictureBox();
            pbxMax = new PictureBox();
            pbxMin = new PictureBox();
            panel1 = new Panel();
            AdminPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxMin).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRetrieval
            // 
            btnRetrieval.Anchor = AnchorStyles.None;
            btnRetrieval.BackColor = Color.Maroon;
            btnRetrieval.FlatStyle = FlatStyle.Popup;
            btnRetrieval.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRetrieval.ForeColor = Color.White;
            btnRetrieval.Image = (Image)resources.GetObject("btnRetrieval.Image");
            btnRetrieval.ImageAlign = ContentAlignment.MiddleLeft;
            btnRetrieval.Location = new Point(845, -21);
            btnRetrieval.Name = "btnRetrieval";
            btnRetrieval.Padding = new Padding(250, 0, 0, 0);
            btnRetrieval.Size = new Size(804, 120);
            btnRetrieval.TabIndex = 3;
            btnRetrieval.Text = "     RETRIEVAL REQUESTS";
            btnRetrieval.TextAlign = ContentAlignment.MiddleLeft;
            btnRetrieval.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRetrieval.UseVisualStyleBackColor = false;
            btnRetrieval.Click += btnRetrieval_Click;
            // 
            // btnView
            // 
            btnView.BackColor = Color.Maroon;
            btnView.Dock = DockStyle.Left;
            btnView.FlatStyle = FlatStyle.Popup;
            btnView.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnView.ForeColor = Color.White;
            btnView.Image = (Image)resources.GetObject("btnView.Image");
            btnView.ImageAlign = ContentAlignment.MiddleLeft;
            btnView.Location = new Point(0, 0);
            btnView.Name = "btnView";
            btnView.Padding = new Padding(350, 0, 0, 0);
            btnView.Size = new Size(847, 78);
            btnView.TabIndex = 20;
            btnView.Text = "        VIEW";
            btnView.TextAlign = ContentAlignment.MiddleLeft;
            btnView.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click_1;
            // 
            // pbxClose
            // 
            pbxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbxClose.BackColor = Color.Transparent;
            pbxClose.BackgroundImage = (Image)resources.GetObject("pbxClose.BackgroundImage");
            pbxClose.BackgroundImageLayout = ImageLayout.Zoom;
            pbxClose.Location = new Point(1595, 12);
            pbxClose.Name = "pbxClose";
            pbxClose.Size = new Size(29, 34);
            pbxClose.TabIndex = 5;
            pbxClose.TabStop = false;
            pbxClose.Click += pbxClose_Click;
            // 
            // pbxMax
            // 
            pbxMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbxMax.BackColor = Color.Transparent;
            pbxMax.BackgroundImage = (Image)resources.GetObject("pbxMax.BackgroundImage");
            pbxMax.BackgroundImageLayout = ImageLayout.Zoom;
            pbxMax.Location = new Point(1547, 12);
            pbxMax.Name = "pbxMax";
            pbxMax.Size = new Size(33, 34);
            pbxMax.TabIndex = 10;
            pbxMax.TabStop = false;
            pbxMax.Click += pbxMax_Click;
            // 
            // pbxMin
            // 
            pbxMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbxMin.BackColor = Color.Transparent;
            pbxMin.BackgroundImage = (Image)resources.GetObject("pbxMin.BackgroundImage");
            pbxMin.BackgroundImageLayout = ImageLayout.Zoom;
            pbxMin.Location = new Point(1496, 12);
            pbxMin.Name = "pbxMin";
            pbxMin.Size = new Size(34, 34);
            pbxMin.TabIndex = 11;
            pbxMin.TabStop = false;
            pbxMin.Click += pbxMin_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(btnView);
            panel1.Controls.Add(btnRetrieval);
            panel1.Location = new Point(0, 225);
            panel1.Name = "panel1";
            panel1.Size = new Size(1637, 78);
            panel1.TabIndex = 21;
            // 
            // AdminPanel
            // 
            AdminPanel.BackColor = Color.Transparent;
            AdminPanel.Dock = DockStyle.Bottom;
            AdminPanel.Location = new Point(0, 309);
            AdminPanel.Name = "AdminPanel";
            AdminPanel.Size = new Size(1636, 746);
            AdminPanel.TabIndex = 22;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1636, 1055);
            Controls.Add(AdminPanel);
            Controls.Add(panel1);
            Controls.Add(pbxMin);
            Controls.Add(pbxMax);
            Controls.Add(pbxClose);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Admin_Load;
            ((System.ComponentModel.ISupportInitialize)pbxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxMin).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnRetrieval;
        private Button btnView;
        private PictureBox pbxClose;
        private PictureBox pbxMax;
        private PictureBox pbxMin;
        private Panel panel1;
        private Panel AdminPanel;
    }
}