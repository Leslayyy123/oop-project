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
    public partial class GuestRequest : Form
    {

        OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Leslie\\OneDrive - Cebu Institute of Technology University\\Desktop\\Database2.mdb");
        OleDbCommand cmd = new OleDbCommand();
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        public GuestRequest()
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

            guestNumbers[firstLetter]++;

            return customId;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string guestName, itemName,itemType, itemDescription, dateLost, location, status;
            string contactNum;
            byte[] imageBytes = null;

            guestName = tbxLName.Text;
            itemName = lblItemName.Text;
            itemDescription = lblDescrip.Text;
            itemType = lblType.Text;
            location = tbxLocation.Text;
            contactNum = tbxContact.Text;
    
            dateLost = dtpLost.Value.ToString("dd/MM/yyyy");
            status = "PENDING"; 

            try
            {
                if (string.IsNullOrWhiteSpace(guestName) || string.IsNullOrWhiteSpace(itemName) || string.IsNullOrWhiteSpace(itemDescription) ||
                    string.IsNullOrWhiteSpace(location) || string.IsNullOrWhiteSpace(itemType))
                {
                    throw new Exception("Please fill in all required fields.");
                }

                if (!string.IsNullOrEmpty(pictureBox1.ImageLocation))
                {
                    Image img = Image.FromFile(pictureBox1.ImageLocation);
                    ImageConverter converter = new ImageConverter();
                    imageBytes = (byte[])converter.ConvertTo(img, typeof(byte[]));
                }

                string customId = GenerateCustomId(guestName);

                string query = "INSERT INTO GuestRequest (CustomId, DateLost, LocationLost, GuestName, ContactNumber, ItemName, ItemDescription, ItemType, LocationFound, Status, Photo) " +
                               "VALUES (@id, @dateLost, @lost, @ownerName, @contact, @itemName, @description, @type, @found, @status, @photo)";
                cmd = new OleDbCommand(query, myConn);
                cmd.Parameters.AddWithValue("@id", customId);
                cmd.Parameters.AddWithValue("@dateLost", dateLost);
                cmd.Parameters.AddWithValue("@lost", location);
                cmd.Parameters.AddWithValue("@ownerName", guestName);
                cmd.Parameters.AddWithValue("@contact", contactNum);
                cmd.Parameters.AddWithValue("@itemName", itemName);
                cmd.Parameters.AddWithValue("@description", itemDescription);
                cmd.Parameters.AddWithValue("@type", itemType);
                cmd.Parameters.AddWithValue("@found", location);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@photo", imageBytes);

                myConn.Open();
                cmd.ExecuteNonQuery();

                da.SelectCommand = new OleDbCommand("SELECT * FROM GuestRequest", myConn);

                if (ds.Tables["GuestRequest"] != null)
                    ds.Tables["GuestRequest"].Clear();
                da.Fill(ds, "GuestRequest");

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myConn.Close();

                MessageBox.Show("Submitted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ShowDialogBox();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxLName.Text = "";
            lblItemName.Text = "";
            lblDescrip.Text = "";
            lblType.Text = "";
            lblLocation.Text = "";
            dtpLost.Value = DateTime.Now;
            tbxContact.Text = "";
            tbxLocation.Text = "";
            tbxLName.Focus();
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
        public void SetItemDetails(string itemName, string itemDescription, string itemType, string location)
        {
            lblItemName.Text = itemName;
            lblDescrip.Text = itemDescription;
            lblType.Text = itemType;
            lblLocation.Text = location;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Guest guestForm = Application.OpenForms.OfType<Guest>().FirstOrDefault();
            if (guestForm != null)
            {
                guestForm.Close();
            }

            Main main = new Main();
            main.Show();

            this.Close();
        }
    }
}
