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

namespace oop_project
{
    public partial class GuestReport : Form
    {
        OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Leslie\\OneDrive - Cebu Institute of Technology University\\Desktop\\Database2.mdb");
        OleDbCommand cmd = new OleDbCommand();
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        public GuestReport()
        {
            InitializeComponent();
        }
        private Dictionary<string, int> guestNumbers = new Dictionary<string, int>();

        private string GenerateCustomId(string firstName)
        {
            string firstLetter = firstName.Substring(0, 1).ToUpper();
            if (!guestNumbers.ContainsKey(firstLetter))
            {
                guestNumbers.Add(firstLetter, 1);
            }

            int currentNumber = guestNumbers[firstLetter];
            string customId = $"{firstLetter}{currentNumber:D3}";

            // Increment the guest number for this first letter
            guestNumbers[firstLetter]++;

            return customId;
        }


        private int InsertGuestReport(string foundBy, string itemName, string itemDescription, string itemType, DateTime dateFound, string locationFound, string status, byte[] photo, string customId)
        {
            int generatedId = 0;

            try
            {
                myConn.Open();

                string insertQuery = "INSERT INTO GuestReport (CustomId, FoundBy, ItemName, ItemDescription, ItemType, DateFound, LocationFound, Status, Photo) " +
                                     "VALUES (@CustomId, @FoundBy, @ItemName, @ItemDescription, @ItemType, @DateFound, @LocationFound, @Status, @Photo)";

                cmd = new OleDbCommand(insertQuery, myConn);

                cmd.Parameters.AddWithValue("@CustomId", customId);
                cmd.Parameters.AddWithValue("@FoundBy", foundBy);
                cmd.Parameters.AddWithValue("@ItemName", itemName);
                cmd.Parameters.AddWithValue("@ItemDescription", itemDescription);
                cmd.Parameters.AddWithValue("@ItemType", itemType);
                cmd.Parameters.AddWithValue("@DateFound", dateFound.ToString("dd/MM/yyyy"));
                cmd.Parameters.AddWithValue("@LocationFound", locationFound);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@Photo", photo);

                // Execute the insert command
                cmd.ExecuteNonQuery();

                // Retrieve the auto-generated ID
                cmd.CommandText = "SELECT @@IDENTITY";
                generatedId = Convert.ToInt32(cmd.ExecuteScalar());

                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting record: " + ex.Message);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }

            return generatedId;
        }

        private int guestNumber = 1; 

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string studName, itemName, itemType, itemDescription, location;
            byte[] imageBytes = null;

            studName = tbxName.Text;
            itemName = tbxItemName.Text;
            itemDescription = tbxDescription.Text;
            location = tbxLocation.Text;
            itemType = cbxType.SelectedItem?.ToString();

            try
            {
                if (string.IsNullOrWhiteSpace(studName) || string.IsNullOrWhiteSpace(itemName) ||
                    string.IsNullOrWhiteSpace(itemDescription) || string.IsNullOrWhiteSpace(location) || string.IsNullOrWhiteSpace(itemType))
                {
                    throw new Exception("Please fill in all required fields.");
                }

                if (!string.IsNullOrEmpty(pictureBox1.ImageLocation))
                {
                    Image img = Image.FromFile(pictureBox1.ImageLocation);
                    ImageConverter converter = new ImageConverter();
                    imageBytes = (byte[])converter.ConvertTo(img, typeof(byte[]));
                }

                // Generate the custom ID
                string customId = GenerateCustomId(studName);

                // Call the InsertGuestReport method with the custom ID
                int generatedId = InsertGuestReport(studName, itemName, itemDescription, itemType, dtpFound.Value, location, "UNCLAIMED", imageBytes, customId);

                MessageBox.Show("Submitted Successfully with ID: " + generatedId, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            tbxName.Text = "";
            tbxItemName.Text = "";
            tbxDescription.Text = "";
            cbxType.SelectedIndex = -1;
            dtpFound.Value = DateTime.Now;
            tbxLocation.Text = "";
            pictureBox1.Image = null; 
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
            Guest studentForm = Application.OpenForms.OfType<Guest>().FirstOrDefault();
            if (studentForm != null)
            {
                studentForm.Close();
            }

            Main main = new Main();
            main.Show();

            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxName.Text = "";
            tbxItemName.Text = "";
            tbxDescription.Text = "";
            cbxType.SelectedIndex = -1;
            dtpFound.Value = DateTime.Now;
            tbxLocation.Text = "";
            pictureBox1.Image = null; 
            tbxName.Focus();
        }
    }
}
