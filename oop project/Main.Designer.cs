namespace oop_project
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            tbxID = new TextBox();
            pbxClose = new PictureBox();
            pbxMin = new PictureBox();
            pbxMax = new PictureBox();
            btnGuest = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxMax).BeginInit();
            SuspendLayout();
            // 
            // tbxID
            // 
            tbxID.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tbxID.BackColor = Color.Maroon;
            tbxID.BorderStyle = BorderStyle.FixedSingle;
            tbxID.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbxID.ForeColor = Color.White;
            tbxID.Location = new Point(902, 629);
            tbxID.Multiline = true;
            tbxID.Name = "tbxID";
            tbxID.Size = new Size(628, 81);
            tbxID.TabIndex = 1;
            tbxID.TabStop = false;
            tbxID.Text = "ID NUMBER";
            tbxID.TextAlign = HorizontalAlignment.Center;
            tbxID.Click += tbxID_Click;
            tbxID.TextChanged += tbxID_TextChanged;
            tbxID.KeyDown += tbxID_KeyDown;
            tbxID.Leave += tbxID_Leave;
            // 
            // pbxClose
            // 
            pbxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbxClose.BackColor = Color.Transparent;
            pbxClose.BackgroundImage = (Image)resources.GetObject("pbxClose.BackgroundImage");
            pbxClose.BackgroundImageLayout = ImageLayout.Zoom;
            pbxClose.Location = new Point(1598, 11);
            pbxClose.Name = "pbxClose";
            pbxClose.Size = new Size(28, 35);
            pbxClose.TabIndex = 6;
            pbxClose.TabStop = false;
            pbxClose.Click += pbxClose_Click;
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
            // pbxMax
            // 
            pbxMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbxMax.BackColor = Color.Transparent;
            pbxMax.BackgroundImage = (Image)resources.GetObject("pbxMax.BackgroundImage");
            pbxMax.BackgroundImageLayout = ImageLayout.Zoom;
            pbxMax.Location = new Point(1549, 12);
            pbxMax.Name = "pbxMax";
            pbxMax.Size = new Size(33, 34);
            pbxMax.TabIndex = 10;
            pbxMax.TabStop = false;
            pbxMax.Click += pbxMax_Click;
            // 
            // btnGuest
            // 
            btnGuest.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuest.BackColor = Color.White;
            btnGuest.FlatStyle = FlatStyle.Flat;
            btnGuest.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuest.ForeColor = Color.Maroon;
            btnGuest.Location = new Point(962, 748);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(520, 62);
            btnGuest.TabIndex = 14;
            btnGuest.Text = "GUEST";
            btnGuest.UseVisualStyleBackColor = false;
            btnGuest.Click += btnGuest_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Maroon;
            label1.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1134, 680);
            label1.Name = "label1";
            label1.Size = new Size(148, 23);
            label1.TabIndex = 15;
            label1.Text = "(Student or Admin)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Are_you__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1636, 1055);
            Controls.Add(label1);
            Controls.Add(btnGuest);
            Controls.Add(pbxMin);
            Controls.Add(pbxMax);
            Controls.Add(pbxClose);
            Controls.Add(tbxID);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)pbxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxMax).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxID;
        private PictureBox pbxClose;
        private PictureBox pbxMin;
        private PictureBox pbxMax;
        private Button btnGuest;
        private Label label1;
    }
}