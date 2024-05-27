    using Microsoft.VisualBasic.Devices;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Xml.Linq;
    using System.Data.OleDb;

    namespace oop_project
    {
    public partial class ReportFoundItem : Form
    {
        OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Leslie\\OneDrive - Cebu Institute of Technology University\\Desktop\\Database2.mdb");
        OleDbCommand cmd = new OleDbCommand();
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private string StudID;
        public ReportFoundItem(string enteredID)
        {
            InitializeComponent();
            StudID = enteredID;
        }

        private void ReportItem_Load(object sender, EventArgs e)
        {
            try
            {   
                string queryGetStudentName = "SELECT StudentName FROM StudentInfo WHERE StudentID = @studentID";
                cmd = new OleDbCommand(queryGetStudentName, myConn);

                cmd.Parameters.AddWithValue("@studentID", StudID);

                myConn.Open();

                var result = cmd.ExecuteScalar();

                if (result != null)
                {
                    tbxName.Text = result.ToString();
                }
                else
                {
                    throw new Exception("Student name not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myConn.Close();
            }
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
            tbxItemName.Text = "";
            tbxDescription.Text = "";
            cbxType.SelectedIndex = -1;
            dtpFound.Value = DateTime.Now;
            tbxLocation.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string studName, itemName, itemType, itemDescription, dateFound, location;
            byte[] imageBytes = null;
            string studentID = StudID; 

            studName = tbxName.Text;
            itemName = tbxItemName.Text;
            itemDescription = tbxDescription.Text;
            location = tbxLocation.Text;
            itemType = cbxType.SelectedItem?.ToString();
            dateFound = dtpFound.Value.ToString("dd/MM/yyyy");

        
                try
                {
                if (string.IsNullOrWhiteSpace(studName) || string.IsNullOrWhiteSpace(itemName) ||
               string.IsNullOrWhiteSpace(itemDescription) || string.IsNullOrWhiteSpace(location) || string.IsNullOrWhiteSpace(itemType))
                {
                    throw new Exception("Please fill in all required fields.");
                }

                string queryGetStudentID = "SELECT StudentID FROM StudentInfo WHERE StudentName = @studName";
                    cmd = new OleDbCommand(queryGetStudentID, myConn);
                    cmd.Parameters.AddWithValue("@studName", studName);
                    myConn.Open();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        studentID = result.ToString();
                    }
                    else
                    {
                        throw new Exception("Student not found.");
                    }

                    if (!string.IsNullOrEmpty(pictureBox1.ImageLocation))
                    {
                        Image img = Image.FromFile(pictureBox1.ImageLocation);
                        ImageConverter converter = new ImageConverter();
                        imageBytes = (byte[])converter.ConvertTo(img, typeof(byte[]));
                    }

                    string query = "INSERT INTO FoundItem (StudentID, FoundBy, ItemName, ItemDescription, ItemType, DateFound, LocationFound, Status, Photo) " +
                        "VALUES (@studentID, @foundBy, @itemName, @description, @type, @date, @loc, @status, @photo)";
                    cmd = new OleDbCommand(query, myConn);
                    cmd.Parameters.AddWithValue("@studentID", studentID); 
                    cmd.Parameters.AddWithValue("@foundBy", studName);
                    cmd.Parameters.AddWithValue("@itemName", itemName);
                    cmd.Parameters.AddWithValue("@description", itemDescription);
                    cmd.Parameters.AddWithValue("@type", itemType);
                    cmd.Parameters.AddWithValue("@date", dateFound);
                    cmd.Parameters.AddWithValue("@loc", location);
                    cmd.Parameters.AddWithValue("@status", "UNCLAIMED");
                    cmd.Parameters.AddWithValue("@photo", imageBytes);

                    cmd.ExecuteNonQuery();

                    da.SelectCommand = new OleDbCommand("SELECT * FROM FoundItem", myConn);

                    if (ds.Tables["FoundItem"] != null)
                        ds.Tables["FoundItem"].Clear();
                    da.Fill(ds, "FoundItem");


                MessageBox.Show("Submitted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ShowDialogBox();

            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                     myConn.Close();
                }       
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxItemName.Text = "";
            tbxDescription.Text = "";
            cbxType.SelectedIndex = -1;
            dtpFound.Value = DateTime.Now;
            tbxLocation.Text = "";
            tbxName.Focus();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
