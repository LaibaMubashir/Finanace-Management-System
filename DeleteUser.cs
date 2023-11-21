using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Finance
{
    public partial class DeleteUser : Form
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Uni(worst)y\\7th Semester\\Enterprise System\\Project\\EAD-Project\\samiullahsaleem\\EAD-Project\\Finance\\DB\\Database1.mdf\"";

        public DeleteUser()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminScreen adminScreen = new AdminScreen();

            // Show Form2
            adminScreen.Show();
        }
        private void RetrieveUserById(int userId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT name, username, password, CATEGORYNAME, phonenumber " +
                                     "FROM Users WHERE user_id = @userId";

                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nameTextBox.Text = reader["name"].ToString();
                            usernameTextBox.Text = reader["username"].ToString();
                            passwordTextBox.Text = reader["password"].ToString();
                            departmentTextBox.Text = reader["department"].ToString();
                            phoneNumberTextBox.Text = reader["phone_number"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("User not found.");
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox4.Text, out int userId))
            {
                RetrieveUserById(userId);
            }
            else
            {
                MessageBox.Show("Invalid user ID. Please enter a valid numeric ID.");
            }
        }
        private void DeleteUserById(int userId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM Users WHERE user_id = @userId";

                using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("User not found.");
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox4.Text, out int userId))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteUserById(userId);
                }
            }
            else
            {
                MessageBox.Show("Invalid user ID. Please enter a valid numeric ID.");
            }
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
