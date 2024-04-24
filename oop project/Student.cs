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
    public partial class Student : Form
    {
        private string studentId; 
        public Student(string enteredId)
        {
            InitializeComponent();
            studentId = enteredId;
        }

        public void Loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
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
            mainpanel.Show();
            ReportFoundItem reportItemForm = new ReportFoundItem(studentId);
            Loadform(reportItemForm);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(btnSearch);
            mainpanel.Show();
            SearchItem searchItemForm = new SearchItem(this, studentId);
            Loadform(searchItemForm);
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Search for the item first before making a request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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