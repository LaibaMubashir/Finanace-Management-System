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

    public partial class UserScreen : Form
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Uni(worst)y\\7th Semester\\Enterprise System\\Project\\EAD-Project\\samiullahsaleem\\EAD-Project\\Finance\\DB\\Database1.mdf\"";

        public int id = 0;
        public string username = "";
        public string category = "";
        public UserScreen(int userid, string uname)
        {
            InitializeComponent();
            id = userid;
            username = uname;
            category=GetCategoryNameByUsername(username);
            label4.Text = username;
            label5.Text = category;
        }
        private string GetCategoryNameByUsername(string username)
        {
            string categoryName = ""; // Default value

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT CategoryName FROM Users WHERE username = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    // Execute the query and get the CategoryName
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        categoryName = result.ToString();
                    }
                }
            }

            return categoryName;
        }
        private void CreateUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserCreateBudget form1 = new UserCreateBudget(id,username,category);
            form1.Show();
        }

        private void UserScreen_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowUserDepBudgets form = new ShowUserDepBudgets(id,username,category);
            form.Show();
        }
    }
}
