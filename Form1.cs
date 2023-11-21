using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Finance
{
    public partial class Form1 : Form
    {
        // Connection string to your SQL Server instance
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Uni(worst)y\\7th Semester\\Enterprise System\\Project\\EAD-Project\\samiullahsaleem\\EAD-Project\\Finance\\DB\\Database1.mdf\"";


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usernametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private bool CheckUserCredentials(string username, string password, string tableName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT COUNT(*) FROM {tableName} WHERE Username = @Username AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private int GetUserIdByUsername(string username)
        {
            int userId = -1; // Default value in case the user is not found

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT user_id FROM Users WHERE Username = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    // Execute the query and get the user ID
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        userId = Convert.ToInt32(result);
                    }
                }
            }

            return userId;
        }


        private void loginButton_Click_1(object sender, EventArgs e)
        {
            string username = usernametextBox.Text;
            string password = passwordtextBox.Text;
            bool isAdmin = CheckUserCredentials(username, password, "Admin");
            bool isUser = CheckUserCredentials(username, password, "Users");


            if (isAdmin)
            {

                this.Hide();
                AdminScreen adminScreen = new AdminScreen();
                // Show Form2
                adminScreen.Show();
            }
            else if (isUser)
            {
                this.Hide();
                int userId = GetUserIdByUsername(username);

                if (userId != -1)
                {
                    UserScreen userscreen = new UserScreen(userId,username);
                    userscreen.Show();
                    
                }
                else
                {
                    // User not found or an error occurred.
                    MessageBox.Show("Login failed. Please check your credentials.");
                }
               

            }
            else
            {
                MessageBox.Show("Login failed. Please check your credentials.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
