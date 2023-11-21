using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Finance
{
    public partial class UpdateUser : Form
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Uni(worst)y\\7th Semester\\Enterprise System\\Project\\EAD-Project\\samiullahsaleem\\EAD-Project\\Finance\\DB\\Database1.mdf\"";


        public UpdateUser()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminScreen adminScreen = new AdminScreen();
            adminScreen.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

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
        private void RetrieveUserById(int userId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT name, username, password, phonenumber,categoryname " +
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
                            departmentTextBox.Text = reader["categoryname"].ToString();
                            phoneNumberTextBox.Text = reader["phonenumber"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("User not found.");
                        }
                    }
                }
            }
        }

        private void nametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateUserById(int userId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE Users SET name = @name, username = @username, password = @password, categoryname = @department, phonenumber = @phonenumber " +
                                     "WHERE user_id = @userId";

                using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
                    cmd.Parameters.AddWithValue("@username", usernameTextBox.Text);
                    cmd.Parameters.AddWithValue("@password", passwordTextBox.Text);
                    cmd.Parameters.AddWithValue("@department", departmentTextBox.Text);
                    cmd.Parameters.AddWithValue("@phonenumber", phoneNumberTextBox.Text);
                    cmd.Parameters.AddWithValue("@userId", userId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User updated successfully.");
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
                DialogResult result = MessageBox.Show("Are you sure you want to update this user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    UpdateUserById(userId);
                }
            }
            else
            {
                MessageBox.Show("Invalid user ID. Please enter a valid numeric ID.");
            }
        }

        private void phoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {

        }
    }
}
