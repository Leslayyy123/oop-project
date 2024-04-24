using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_project
{
    public partial class Guest : Form
    {
        public Guest()
        {
            InitializeComponent();
        }
        public void Loadform(object Form)
        {
            if (this.guestpanel.Controls.Count > 0)
                this.guestpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.guestpanel.Controls.Add(f);
            this.guestpanel.Tag = f;
            f.Show();
        }

        private Button currentButton;
        private void ChangeButtonColor(Button clickedButton)
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.Maroon;
            }

            clickedButton.BackColor = Color.Goldenrod;

            currentButton = clickedButton;
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(btnReport);
            guestpanel.Show();
            GuestReport reportItem = new GuestReport();
            Loadform(reportItem);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(btnSearch);
            guestpanel.Show();
            GuestSearch searchItem = new GuestSearch(this);
            Loadform(searchItem);
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please make a request first before clicking the Request button.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            ChangeButtonColor(btnRequest);

        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbxMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pbxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public void EnableRequestButton()
        {
            btnRequest.Enabled = true;
        }

        public void DisableRequestButton()
        {
            btnRequest.Enabled = false;
        }
    }
}
