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
    public partial class CreateUser : Form
    {
        static private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Uni(worst)y\\7th Semester\\Enterprise System\\Project\\EAD-Project\\samiullahsaleem\\EAD-Project\\Finance\\DB\\Database1.mdf\"";

        static private void InsertUserIntoDatabase(string name, string username, string password, string department, string phoneNumber)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO Users (name, username, password,categoryname , phonenumber) " +
                                     "VALUES (@name, @username, @password, @department, @phone_number)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@department", department);
                    cmd.Parameters.AddWithValue("@phone_number", phoneNumber);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User inserted into the database successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert user into the database.");
                    }
                }
            }
        }
        
        public CreateUser()
        {
            InitializeComponent();
        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminScreen adminScreen = new AdminScreen();

            // Show Form2
            adminScreen.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string department = null;
            if (comboBoxDepartment.SelectedItem != null)
            {
                DataRowView selectedRow = comboBoxDepartment.SelectedItem as DataRowView;

                if (selectedRow != null)
                {
                    department = selectedRow["CategoryName"].ToString();

                    // Use the selected value as needed
                }
            }
            string phoneNumber = phoneNumberTextBox.Text;


            InsertUserIntoDatabase(name, username, password, department, phoneNumber);
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet10.TransactionCategories' table. You can move, or remove it, as needed.
            this.transactionCategoriesTableAdapter.Fill(this.database1DataSet10.TransactionCategories);

        }

        private void department_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
