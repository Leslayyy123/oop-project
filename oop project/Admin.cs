using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_project
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            AdminPanel.Hide();
        }

        public void Loadform(object Form)
        {
            if (this.AdminPanel.Controls.Count > 0)
                this.AdminPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.AdminPanel.Controls.Add(f);
            this.AdminPanel.Tag = f;
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

        private void btnRetrieval_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(btnRetrieval);
            AdminPanel.Show();
            RetrievalRequests retrieve = new RetrievalRequests();
            Loadform(retrieve);
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

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void btnView_Click_1(object sender, EventArgs e)
        {
            ChangeButtonColor(btnView);
            AdminPanel.Show();
            View viewForm = new View();
            Loadform(viewForm);
        }
    }
}

