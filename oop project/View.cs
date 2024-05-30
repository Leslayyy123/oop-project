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
    public partial class View : Form
    {
        private OleDbConnection connection;
        private OleDbDataAdapter dataAdapter;
        private DataTable dataTable;
        private string currentTableName = "";
        public View()
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

        private void LoadDataIntoDataGridView(string GuestReport)
        {
            try
            {
                string query = $"SELECT * FROM {GuestReport}";

                dataAdapter = new OleDbDataAdapter(query, connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dgvItems.Columns.Clear();

                dgvItems.DataSource = dataTable;

                // Remove existing "Show Photo" button column if it already exists
                if (dgvItems.Columns.Contains("btnShowPhoto"))
                {
                    dgvItems.Columns.Remove("btnShowPhoto");
                }

                // Remove "Photo" column
                if (dgvItems.Columns.Contains("Photo"))
                {
                    dgvItems.Columns.Remove("Photo");
                }

                // Add "Show Photo" button column
                DataGridViewButtonColumn showPhotoButtonColumn = new DataGridViewButtonColumn();
                showPhotoButtonColumn.HeaderText = "Photo";
                showPhotoButtonColumn.Name = "btnShowPhoto";
                showPhotoButtonColumn.Text = "Show Photo";
                showPhotoButtonColumn.UseColumnTextForButtonValue = true;
                dgvItems.Columns.Add(showPhotoButtonColumn);
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
                string query = "SELECT * FROM FoundItem";

                dataAdapter = new OleDbDataAdapter(query, connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dgvItems.Columns.Clear();

                dgvItems.DataSource = dataTable;

                // Remove existing "Show Photo" button column if it already exists
                if (dgvItems.Columns.Contains("btnShowPhoto"))
                {
                    dgvItems.Columns.Remove("btnShowPhoto");
                }

                // Remove "Photo" column
                if (dgvItems.Columns.Contains("Photo"))
                {
                    dgvItems.Columns.Remove("Photo");
                }

                // Add "Show Photo" button column
                DataGridViewButtonColumn showPhotoButtonColumn = new DataGridViewButtonColumn();
                showPhotoButtonColumn.HeaderText = "Photo";
                showPhotoButtonColumn.Name = "btnShowPhoto";
                showPhotoButtonColumn.Text = "Show Photo";
                showPhotoButtonColumn.UseColumnTextForButtonValue = true;
                dgvItems.Columns.Add(showPhotoButtonColumn);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }


        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvItems.Columns["btnShowPhoto"].Index)
            {
                DataRowView selectedRow = (DataRowView)dgvItems.Rows[e.RowIndex].DataBoundItem;
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

        public void UpdateItemStatus(string itemName, string status)
        {
            DataRow[] foundRows = dataTable.Select($"ItemName = '{itemName}'");

            if (foundRows.Length > 0)
            {
                DataRow row = foundRows[0];
                string currentStatus = row["Status"].ToString();

                if (currentStatus == "UNCLAIMED")
                {
                    row["Status"] = "CLAIMED";


                    OleDbCommandBuilder builder = new OleDbCommandBuilder(dataAdapter);
                    dataAdapter.UpdateCommand = builder.GetUpdateCommand();
                    dataAdapter.Update(dataTable);
                }
                else
                {
                    MessageBox.Show("The status cannot be changed because the item is not in the unclaimed state.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Item not found in the data source.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isPhotoFormOpen = false;


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
            currentTableName = "GuestReport";
            LoadDataIntoDataGridView(currentTableName);
        }

        private void ApplyFilter()
        {
            try
            {
                if (dgvItems.DataSource is DataTable dataTable)
                {
                    if (!string.IsNullOrWhiteSpace(tbxSearch.Text) && tbxSearch.Text != "Search")
                    {
                        dataTable.DefaultView.RowFilter =
                            $"ItemName LIKE '%{tbxSearch.Text}%' OR " +
                            $"LocationFound LIKE '%{tbxSearch.Text}%' OR " +
                            $"FoundBy LIKE '%{tbxSearch.Text}%' OR " +
                            $"ItemDescription LIKE '%{tbxSearch.Text}%' OR " +
                            $"ItemType LIKE '%{tbxSearch.Text}%' OR " +
                            $"Status LIKE '%{tbxSearch.Text}%'";
                    }
                    else
                    {
                        dataTable.DefaultView.RowFilter = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
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

        private void View_Load(object sender, EventArgs e)
        {

        }

        private void LoadDataBySelectedMonth(string selectedMonth)
        {
            try
            {
                if (selectedMonth == "Search by Month")
                {
                    dataTable.DefaultView.RowFilter = string.Empty;
                    dgvItems.DataSource = dataTable;
                }
                else
                {
                    string query = $"SELECT * FROM FoundItem WHERE Format(DateFound, 'mmmm') = '{selectedMonth}'";
                    if (currentTableName == "GuestReport")
                    {
                        query = $"SELECT * FROM GuestReport WHERE Format(DateFound, 'mmmm') = '{selectedMonth}'";
                    }
                    dataAdapter = new OleDbDataAdapter(query, connection);
                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dgvItems.DataSource = dataTable;
                    dgvItems.Columns.Remove("Photo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }


        private void cbxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMonth.SelectedIndex > 0)
            {
                string selectedMonth = cbxMonth.SelectedItem.ToString();
                LoadDataBySelectedMonth(selectedMonth);
            }
        }
    }
}