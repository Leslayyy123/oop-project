using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Xml.Linq;

namespace oop_project
{
    public partial class RequestRetrieval : Form
    {
        private string StudID;
        public RequestRetrieval(string enteredID)
        {
            InitializeComponent();
            StudID = enteredID;

            string studentName = GetStudentName(StudID);
            tbxName.Text = studentName;
        }

        OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Leslie\\OneDrive - Cebu Institute of Technology University\\Desktop\\Database2.mdb");
        OleDbCommand cmd = new OleDbCommand();
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private string GetStudentName(string studentID)
        {
            string studentName = "";
            try
            {
                string query = "SELECT StudentName FROM StudentInfo WHERE StudentID = @studentID";
                cmd = new OleDbCommand(query, myConn);
                cmd.Parameters.AddWithValue("@studentID", studentID);

                myConn.Open();
                studentName = cmd.ExecuteScalar()?.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myConn.Close();
            }
            return studentName;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string studName, itemName, itemType, itemDescription, dateLost, location,
                   contactNum, course, yearLevel;
            byte[] imageBytes = null;

            studName = tbxName.Text;
            itemName = lblItemName.Text;
            itemDescription = lblDescrip.Text;
            itemType = lblType.Text;
            location = tbxLocation.Text;
            contactNum = tbxContact.Text;

            course = tbxCourse.Text;
            yearLevel = cbxYear.SelectedItem?.ToString();

            dateLost = dtpLost.Value.ToString("dd/MM/yyyy");

            if (string.IsNullOrWhiteSpace(studName) || string.IsNullOrWhiteSpace(itemName) ||
                string.IsNullOrWhiteSpace(itemDescription) || string.IsNullOrWhiteSpace(location) || string.IsNullOrWhiteSpace(itemType))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (!string.IsNullOrEmpty(pictureBox1.ImageLocation))
                {
                    Image img = Image.FromFile(pictureBox1.ImageLocation);
                    ImageConverter converter = new ImageConverter();
                    imageBytes = (byte[])converter.ConvertTo(img, typeof(byte[]));
                }

                using (OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Leslie\\OneDrive - Cebu Institute of Technology University\\Desktop\\Database2.mdb"))
                {
                    myConn.Open();

                    string query = "INSERT INTO LostItem (StudentID, DateLost, LocationLost, StudentName, Course, YearLevel, ContactNumber, ItemName, ItemDescription, ItemType, Status, Photo) " +
                                "VALUES (@studentID, @dateLost, @lost, @owner, @course, @yr, @contact, @itemName, @description, @type, @status, @photo)";
                    using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                    {
                        cmd.Parameters.AddWithValue("@studentID", StudID);
                        cmd.Parameters.AddWithValue("@dateLost", dateLost);
                        cmd.Parameters.AddWithValue("@lost", location);
                        cmd.Parameters.AddWithValue("@owner", studName);
                        cmd.Parameters.AddWithValue("@course", course);
                        cmd.Parameters.AddWithValue("@yr", yearLevel);
                        cmd.Parameters.AddWithValue("@contact", contactNum);
                        cmd.Parameters.AddWithValue("@itemName", itemName);
                        cmd.Parameters.AddWithValue("@description", itemDescription);
                        cmd.Parameters.AddWithValue("@type", itemType);
                        cmd.Parameters.AddWithValue("@status", "PENDING");
                        cmd.Parameters.AddWithValue("@photo", imageBytes);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Submitted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ShowDialogBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ShowDialogBox()
        {
            DialogResult result = MessageBox.Show("Do you want to continue?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                Student studentForm = Application.OpenForms.OfType<Student>().FirstOrDefault();
                if (studentForm != null)
                {
                    studentForm.Close();
                }
                Main main = new Main();
                main.Show();

                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbxName.Text = "";
            lblItemName.Text = "";
            lblDescrip.Text = "";
            lblType.Text = "";
            dtpLost.Value = DateTime.Now;
            tbxCourse.Text = "";
            cbxYear.SelectedIndex = -1;
            tbxContact.Text = "";
            tbxLocation.Text = "";
            tbxName.Focus();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "JPEG files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All Files(*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBox1.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Student studentForm = Application.OpenForms.OfType<Student>().FirstOrDefault();
            if (studentForm != null)
            {
                studentForm.Close();
            }

            Main main = new Main();
            main.Show();

            this.Close();
        }

        public void SetItemDetails(string itemName, string itemDescription, string itemType)
        {
            lblItemName.Text = itemName;
            lblDescrip.Text = itemDescription;
            lblType.Text = itemType;
        }
    }
}
