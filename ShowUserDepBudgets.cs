using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Finance
{
    public partial class ShowUserDepBudgets : Form
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Uni(worst)y\\7th Semester\\Enterprise System\\Project\\EAD-Project\\samiullahsaleem\\EAD-Project\\Finance\\DB\\Database1.mdf\"";

        public int id = 0;
        public string username = "";
        public string Category = "";
        public ShowUserDepBudgets(int userid, string uname,string c)
        {
            InitializeComponent();
            RefreshBudgetTable();
            id = userid;
            username = uname;
            Category = c;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserScreen us = new UserScreen(id,username);
            us.Show();

        }
        private void RefreshBudgetTable()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Budgets"; // Retrieve all columns

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable budgetTable = new DataTable();
                    adapter.Fill(budgetTable);

                    // Update the DataGridView data source with all columns
                    dataGridView1.DataSource = budgetTable;
                }
            }
        }

        private void ShowUserDepBudgets_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet20.Budgets' table. You can move, or remove it, as needed.
            this.budgetsTableAdapter.Fill(this.database1DataSet20.Budgets);

        }
    }
}
