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
    public partial class SearchItem : Form
    {
        private OleDbConnection connection;
        private OleDbDataAdapter dataAdapter;
        private DataTable dataTable;

        private string StudID;
        private Student _studentForm;

        public SearchItem(Student studentForm, string enteredID)
        {
            InitializeComponent();
            StudID = enteredID;
            _studentForm = studentForm;
            InitializeDatabaseConnection();
            LoadDataIntoDataGridView();
            dgvLostItem.SelectionChanged += dgvLostItem_SelectionChanged;
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

        private void LoadDataIntoDataGridView()
        {
            try
            {
                StringBuilder whereClause = new StringBuilder();

                if (!string.IsNullOrEmpty(tbxSearch.Text))
                {
                    whereClause.Append("WHERE ");

                    string keyword = tbxSearch.Text.Trim();

                    whereClause.Append($"(ItemName LIKE '%{keyword}%' OR ");
                    whereClause.Append($"ItemDescription LIKE '%{keyword}%' OR ");
                    whereClause.Append($"ItemType LIKE '%{keyword}%' OR ");
                    whereClause.Append($"LocationFound LIKE '%{keyword}%') ");
                }

                if (whereClause.Length > 0)
                {
                    whereClause.Append(" AND ");
                }
                else
                {
                    whereClause.Append("WHERE ");
                }
                whereClause.Append("(Status <> 'CLAIMED')");

                string query = $"SELECT ItemName, ItemDescription, ItemType, LocationFound FROM FoundItem {whereClause}" +
                               $" UNION " +
                               $"SELECT ItemName, ItemDescription, ItemType, LocationFound FROM GuestReport {whereClause}";

                dataAdapter = new OleDbDataAdapter(query, connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dgvLostItem.DataSource = dataTable;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show($"OleDbException: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            connection.Dispose();
            dataAdapter.Dispose();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearch.Text == "Search")
            {
                tbxSearch.Text = "";
            }

            tbxSearch.ForeColor = Color.White;

            if (tbxSearch.Text.Length >= 3)
            {
                LoadDataIntoDataGridView();

                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Item Not Found!", "No Items Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
          }
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

        private void dgvLostItem_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLostItem.SelectedRows.Count > 0)
            {
                lblItemName.Text = dgvLostItem.SelectedRows[0].Cells["ItemName"].Value.ToString();
                lblItemDescription.Text = dgvLostItem.SelectedRows[0].Cells["ItemDescription"].Value.ToString();
                lblItemType.Text = dgvLostItem.SelectedRows[0].Cells["ItemType"].Value.ToString();
                lblLocationFound.Text = dgvLostItem.SelectedRows[0].Cells["LocationFound"].Value.ToString();
            }
            else
            {
                lblItemName.Text = "";
                lblItemDescription.Text = "";
                lblItemType.Text = "";
                lblLocationFound.Text = "";
            }
        }
        private void SearchItem_Load(object sender, EventArgs e)
        {
            dgvLostItem.ColumnHeadersDefaultCellStyle.Font = new Font(dgvLostItem.Font, FontStyle.Bold);
            dgvLostItem.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnRequest_Click_1(object sender, EventArgs e)
        {
            if (dgvLostItem.SelectedRows.Count > 0)
            {
                string itemName = lblItemName.Text;
                string itemDescription = lblItemDescription.Text;
                string itemType = lblItemType.Text;
                string location = lblLocationFound.Text;

                RequestRetrieval requestRetrievalForm = new RequestRetrieval(StudID); // Pass the selected StudentID

                requestRetrievalForm.SetItemDetails(itemName, itemDescription, itemType);

                _studentForm.Loadform(requestRetrievalForm);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select an item first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
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
}
