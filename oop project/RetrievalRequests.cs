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
    public partial class RetrievalRequests : Form
    {
        private OleDbConnection connection;
        private OleDbDataAdapter dataAdapter;
        private DataTable dataTable;
        private string currentTableName = "";

        public RetrievalRequests()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }

        private void InitializeDatabaseConnection()
        {
            try
            {

                string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Leslie\\OneDrive - Cebu Institute of Technology University\\Desktop\\Database2.mdb";


                connection = new OleDbConnection(connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing database connection: " + ex.Message);
            }
        }


        private void LoadDataIntoDataGridView(string GuestRequest)
        {
            try
            {
                string query = $"SELECT * FROM {GuestRequest}";

                dataAdapter = new OleDbDataAdapter(query, connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dgvRequest.Columns.Clear();

                dgvRequest.DataSource = dataTable;

                dgvRequest.Columns.Remove("ItemType");     
                dgvRequest.Columns.Remove("ContactNumber");

                // Remove existing "Show Photo" button column if it already exists
                if (dgvRequest.Columns.Contains("btnShowPhoto"))
                {
                    dgvRequest.Columns.Remove("btnShowPhoto");
                }

                // Remove "Photo" column
                if (dgvRequest.Columns.Contains("Photo"))
                {
                    dgvRequest.Columns.Remove("Photo");
                }

                // Add "Show Photo" button column
                DataGridViewButtonColumn showPhotoButtonColumn = new DataGridViewButtonColumn();
                showPhotoButtonColumn.HeaderText = "Photo";
                showPhotoButtonColumn.Name = "btnShowPhoto";
                showPhotoButtonColumn.Text = "Show Photo";
                showPhotoButtonColumn.UseColumnTextForButtonValue = true;
                dgvRequest.Columns.Add(showPhotoButtonColumn);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
        private void LoadDataIntoDataGridView()
        {
            try
            {
                string query = $"SELECT * FROM LostItem";

                dataAdapter = new OleDbDataAdapter(query, connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dgvRequest.DataSource = dataTable;
                ;
                dgvRequest.Columns.Remove("Course");
                dgvRequest.Columns.Remove("YearLevel");
                dgvRequest.Columns.Remove("ContactNumber");
                dgvRequest.Columns.Remove("ItemType");

                // Remove existing "Show Photo" button column if it already exists
                if (dgvRequest.Columns.Contains("btnShowPhoto"))
                {
                    dgvRequest.Columns.Remove("btnShowPhoto");
                }

                if (dgvRequest.Columns.Contains("Photo"))
                {
                    dgvRequest.Columns.Remove("Photo");
                }

                // Add "Show Photo" button column
                DataGridViewButtonColumn showPhotoButtonColumn = new DataGridViewButtonColumn();
                showPhotoButtonColumn.HeaderText = "Photo";
                showPhotoButtonColumn.Name = "btnShowPhoto";
                showPhotoButtonColumn.Text = "Show Photo";
                showPhotoButtonColumn.UseColumnTextForButtonValue = true;
                dgvRequest.Columns.Add(showPhotoButtonColumn);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin adminForm = Application.OpenForms.OfType<Admin>().FirstOrDefault();
            if (adminForm != null)
            {
                adminForm.Close();
            }

            Main main = new Main();
            main.Show();

            this.Close();
        }

        private void RetrievalRequests_Load(object sender, EventArgs e)
        {

        }

        private void UpdateLostItemStatus(string itemName, string status)
        {
            try
            {
                connection.Open();

                string updateQuery = "UPDATE FoundItem SET Status = @Status WHERE ItemName = @ItemName";
                OleDbCommand updateCommand = new OleDbCommand(updateQuery, connection);

                updateCommand.Parameters.AddWithValue("@Status", status);
                updateCommand.Parameters.AddWithValue("@ItemName", itemName);

                updateCommand.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating status: " + ex.Message);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (dgvRequest.SelectedRows.Count > 0)
            {
                string itemName = dgvRequest.SelectedRows[0].Cells["ItemName"].Value.ToString();

                UpdateLostItemStatus(itemName, "CLAIMED");

                if (DeleteAcceptedRequestFromRetrievalRequests(itemName))
                {
                    MessageBox.Show("Item has been successfully accepted and removed from the requests.");

                    LoadDataIntoDataGridView();

                    UpdateStatusInViewForm(itemName, "CLAIMED");
                }
                else
                {
                    MessageBox.Show("Failed to delete the request from RetrievalRequests table.");
                }
            }
            else
            {
                MessageBox.Show("Please select a request to accept.");
            }
        }

        private bool DeleteAcceptedRequestFromRetrievalRequests(string itemName)
        {
            try
            {
                connection.Open();

                string deleteQuery = "DELETE FROM LostItem WHERE ItemName = @ItemName";
                OleDbCommand deleteCommand = new OleDbCommand(deleteQuery, connection);
                deleteCommand.Parameters.AddWithValue("@ItemName", itemName);

                int rowsAffected = deleteCommand.ExecuteNonQuery();

                connection.Close();

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting request from RequestRetrieval table: " + ex.Message);
                return false;
            }
        }


        private void UpdateStatusInViewForm(string itemName, string status)
        {
            View viewForm = Application.OpenForms.OfType<View>().FirstOrDefault();
            if (viewForm != null)
            {
                viewForm.UpdateItemStatus(itemName, status);
            }
        }
        private void btnDeny_Click(object sender, EventArgs e)
        {
            if (dgvRequest.SelectedRows.Count > 0)
            {
                string itemName = dgvRequest.SelectedRows[0].Cells["ItemName"].Value.ToString();

                dgvRequest.Rows.RemoveAt(dgvRequest.SelectedRows[0].Index);

                if (DeleteRequestFromRetrievalRequests(itemName))
                {
                    MessageBox.Show("Item has been denied and removed from the requests.");
                }
            }
            else
            {
                MessageBox.Show("Please select a request to deny.");
            }
        }

        private bool DeleteRequestFromRetrievalRequests(string itemName)
        {
            try
            {
                connection.Open();

                string deleteQuery = "DELETE FROM LostItem WHERE ItemName = @ItemName";
                OleDbCommand deleteCommand = new OleDbCommand(deleteQuery, connection);
                deleteCommand.Parameters.AddWithValue("@ItemName", itemName);

                int rowsAffected = deleteCommand.ExecuteNonQuery();

                connection.Close();

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting request from  RequestRetrieval table: " + ex.Message);
                return false;
            }
        }

        private bool isPhotoFormOpen = false;


        private void dgvRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvRequest.Columns["btnShowPhoto"].Index)
            {
                DataRowView selectedRow = (DataRowView)dgvRequest.Rows[e.RowIndex].DataBoundItem;
                byte[] photoBytes = (byte[])selectedRow["Photo"];

                if (photoBytes != null && photoBytes.Length > 0)
                {
                    ShowPhotoPopup(photoBytes);
                }
                else
                {
                    MessageBox.Show("No photo available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ShowPhotoPopup(byte[] photoBytes)
        {
            Form photoForm = new Form();
            photoForm.Text = "Photo";
            photoForm.Size = new Size(400, 400);
            photoForm.StartPosition = FormStartPosition.CenterScreen;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            using (MemoryStream ms = new MemoryStream(photoBytes))
            {
                pictureBox.Image = Image.FromStream(ms);
            }

            photoForm.Controls.Add(pictureBox);

            photoForm.FormClosed += (sender, e) =>
            {
                pictureBox.Dispose();
                photoForm.Dispose();
                isPhotoFormOpen = false;
            };

            photoForm.Show();

            isPhotoFormOpen = true;
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

        private void btnStudent_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(btnStudent);
            LoadDataIntoDataGridView();
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(btnGuest);
            currentTableName = "GuestRequest";
            LoadDataIntoDataGridView(currentTableName);
        }

        private void ApplyFilter()
        {
            try
            {
                if (dgvRequest.DataSource is DataTable dataTable)
                {
                    if (!string.IsNullOrWhiteSpace(tbxSearch.Text) && tbxSearch.Text != "Search")
                    {
                        string keyword = tbxSearch.Text.Trim().ToLower(); // Convert search text to lowercase

                        dataTable.DefaultView.RowFilter =
                            $"ItemName.ToLower() LIKE '%{keyword}%' OR " +
                            $"LocationFound.ToLower() LIKE '%{keyword}%' OR " +
                            $"FoundBy.ToLower() LIKE '%{keyword}%' OR " +
                            $"ItemDescription.ToLower() LIKE '%{keyword}%' OR " +
                            $"ItemType.ToLower() LIKE '%{keyword}%' OR " +
                            $"Status.ToLower() LIKE '%{keyword}%'";
                    }
                    else
                    {
                        dataTable.DefaultView.RowFilter = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearch.Text == "Search")
            {
                tbxSearch.Text = "";
            }

            tbxSearch.ForeColor = Color.White;

            // Call ApplyFilter here
            ApplyFilter();
        }

        private void tbxSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxSearch.Text) || tbxSearch.Text == "Search")
            {
                tbxSearch.Text = "Search";
            }
        }

        private void tbxSearch_Click(object sender, EventArgs e)
        {
            tbxSearch.Text = "";
        }
    }
}