namespace oop_project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pbxClose = new PictureBox();
            pbxMax = new PictureBox();
            pbxMin = new PictureBox();
            panel1 = new Panel();
            btnContinue = new Button();
            ((System.ComponentModel.ISupportInitialize)pbxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxMin).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pbxClose
            // 
            pbxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbxClose.BackColor = Color.Transparent;
            pbxClose.BackgroundImage = (Image)resources.GetObject("pbxClose.BackgroundImage");
            pbxClose.BackgroundImageLayout = ImageLayout.Stretch;
            pbxClose.Location = new Point(1614, 12);
            pbxClose.Name = "pbxClose";
            pbxClose.Size = new Size(28, 32);
            pbxClose.TabIndex = 6;
            pbxClose.TabStop = false;
            pbxClose.Click += pbxClose_Click;
            // 
            // pbxMax
            // 
            pbxMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbxMax.BackColor = Color.Transparent;
            pbxMax.BackgroundImage = (Image)resources.GetObject("pbxMax.BackgroundImage");
            pbxMax.BackgroundImageLayout = ImageLayout.Stretch;
            pbxMax.Location = new Point(1566, 12);
            pbxMax.Name = "pbxMax";
            pbxMax.Size = new Size(32, 32);
            pbxMax.TabIndex = 7;
            pbxMax.TabStop = false;
            pbxMax.Click += pbxMax_Click;
            // 
            // pbxMin
            // 
            pbxMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbxMin.BackColor = Color.Transparent;
            pbxMin.BackgroundImage = (Image)resources.GetObject("pbxMin.BackgroundImage");
            pbxMin.BackgroundImageLayout = ImageLayout.Stretch;
            pbxMin.Location = new Point(1517, 12);
            pbxMin.Name = "pbxMin";
            pbxMin.Size = new Size(33, 32);
            pbxMin.TabIndex = 8;
            pbxMin.TabStop = false;
            pbxMin.Click += pbxMin_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnContinue);
            panel1.Location = new Point(645, 830);
            panel1.Name = "panel1";
            panel1.Size = new Size(415, 155);
            panel1.TabIndex = 9;
            // 
            // btnContinue
            // 
            btnContinue.Anchor = AnchorStyles.None;
            btnContinue.BackColor = Color.Maroon;
            btnContinue.FlatStyle = FlatStyle.Flat;
            btnContinue.ForeColor = Color.White;
            btnContinue.Location = new Point(58, 49);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(306, 53);
            btnContinue.TabIndex = 10;
            btnContinue.Text = "CLICK TO CONTINUE";
            btnContinue.UseVisualStyleBackColor = false;
            btnContinue.Click += btnContinue_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.UI__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1654, 1102);
            Controls.Add(pbxMin);
            Controls.Add(pbxMax);
            Controls.Add(pbxClose);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxMin).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pbxClose;
        private PictureBox pbxMax;
        private PictureBox pbxMin;
        private Panel panel1;
        private Button btnContinue;
    }
}
