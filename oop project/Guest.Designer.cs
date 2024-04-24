namespace oop_project
{
    partial class Guest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guest));
            pbxMin = new PictureBox();
            pbxMax = new PictureBox();
            pbxClose = new PictureBox();
            guestpanel = new Panel();
            btnRequest = new Button();
            btnReport = new Button();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)pbxMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxClose).BeginInit();
            SuspendLayout();
            // 
            // pbxMin
            // 
            pbxMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbxMin.BackColor = Color.Transparent;
            pbxMin.BackgroundImage = (Image)resources.GetObject("pbxMin.BackgroundImage");
            pbxMin.BackgroundImageLayout = ImageLayout.Zoom;
            pbxMin.Location = new Point(1494, 12);
            pbxMin.Name = "pbxMin";
            pbxMin.Size = new Size(34, 34);
            pbxMin.TabIndex = 18;
            pbxMin.TabStop = false;
            pbxMin.Click += pbxMin_Click;
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
            pbxMax.TabIndex = 17;
            pbxMax.TabStop = false;
            pbxMax.Click += pbxMax_Click;
            // 
            // pbxClose
            // 
            pbxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbxClose.BackColor = Color.Transparent;
            pbxClose.BackgroundImage = (Image)resources.GetObject("pbxClose.BackgroundImage");
            pbxClose.BackgroundImageLayout = ImageLayout.Zoom;
            pbxClose.Location = new Point(1596, 12);
            pbxClose.Name = "pbxClose";
            pbxClose.Size = new Size(28, 34);
            pbxClose.TabIndex = 16;
            pbxClose.TabStop = false;
            pbxClose.Click += pbxClose_Click;
            // 
            // guestpanel
            // 
            guestpanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guestpanel.BackgroundImage = Properties.Resources.Untitled_design__14_;
            guestpanel.BackgroundImageLayout = ImageLayout.Stretch;
            guestpanel.Location = new Point(-11, 255);
            guestpanel.Name = "guestpanel";
            guestpanel.Size = new Size(1654, 849);
            guestpanel.TabIndex = 15;
            // 
            // btnRequest
            // 
            btnRequest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRequest.BackColor = Color.Maroon;
            btnRequest.FlatStyle = FlatStyle.Popup;
            btnRequest.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRequest.ForeColor = Color.White;
            btnRequest.Image = Properties.Resources.request;
            btnRequest.ImageAlign = ContentAlignment.MiddleLeft;
            btnRequest.Location = new Point(1097, 142);
            btnRequest.Name = "btnRequest";
            btnRequest.Padding = new Padding(150, 0, 0, 0);
            btnRequest.Size = new Size(546, 115);
            btnRequest.TabIndex = 14;
            btnRequest.Text = "REQUEST";
            btnRequest.UseVisualStyleBackColor = false;
            btnRequest.Click += btnRequest_Click;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.Maroon;
            btnReport.FlatStyle = FlatStyle.Popup;
            btnReport.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReport.ForeColor = Color.White;
            btnReport.Image = Properties.Resources.report__1_;
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(-11, 142);
            btnReport.Name = "btnReport";
            btnReport.Padding = new Padding(100, 0, 0, 0);
            btnReport.Size = new Size(548, 115);
            btnReport.TabIndex = 12;
            btnReport.Text = "    REPORT";
            btnReport.TextAlign = ContentAlignment.MiddleLeft;
            btnReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSearch.BackColor = Color.Maroon;
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Image = Properties.Resources.search__2_;
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(534, 142);
            btnSearch.Name = "btnSearch";
            btnSearch.Padding = new Padding(150, 0, 0, 0);
            btnSearch.Size = new Size(566, 115);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "   SEARCH";
            btnSearch.TextAlign = ContentAlignment.MiddleLeft;
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // Guest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.UI__8_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1636, 1055);
            Controls.Add(pbxMin);
            Controls.Add(pbxMax);
            Controls.Add(pbxClose);
            Controls.Add(guestpanel);
            Controls.Add(btnRequest);
            Controls.Add(btnReport);
            Controls.Add(btnSearch);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Guest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Guest";
            ((System.ComponentModel.ISupportInitialize)pbxMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbxMin;
        private PictureBox pbxMax;
        private PictureBox pbxClose;
        private Panel guestpanel;
        private Button btnRequest;
        private Button btnReport;
        private Button btnSearch;
    }
}