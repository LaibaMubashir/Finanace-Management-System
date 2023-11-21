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

namespace Finance
{
    public partial class ShowAllUsers : Form
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Uni(worst)y\\7th Semester\\Enterprise System\\Project\\EAD-Project\\samiullahsaleem\\EAD-Project\\Finance\\DB\\Database1.mdf\"";

        public ShowAllUsers()
        {
            InitializeComponent();
            // Load initial data when the form is loaded
            RefreshUserData();
        }
        private void RefreshUserData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM Users";

                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Bind the data to your user interface controls (e.g., DataGridView, ListBox, etc.)
                    dataGridView1.DataSource = dataTable; // Example for DataGridView
                }
            }
        }
        private void ShowAllUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet17.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.database1DataSet17.Users);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminScreen adminScreen = new AdminScreen();

            // Show Form2
            adminScreen.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
