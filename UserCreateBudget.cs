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
using System.Drawing.Design;

namespace Finance
{

    public partial class UserCreateBudget : Form
    {
        public int id = 0;
        public string username = "";
        public string CategoryName="";
        static private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Uni(worst)y\\7th Semester\\Enterprise System\\Project\\EAD-Project\\samiullahsaleem\\EAD-Project\\Finance\\DB\\Database1.mdf\"";
        public UserCreateBudget(int id1, string username1,string c)
        {
            InitializeComponent();
            id = id1;
            username = username1;
            CategoryName = c;
            department.Text = CategoryName;
        }
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UserCreateBudget_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Gather data from form controls
            int userId = id; // Replace with your logic to get the user ID
            string budgetName = textBox2.Text; // Assuming textBox1 contains the budget name
            decimal allocatedAmount = decimal.Parse(textBox3.Text); // Assuming textBox3 contains the allocated amount
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;

            if (endDate <= startDate)
            {
                MessageBox.Show("End Date should be greater than Start Date");
                return; // Exit the method without performing the insertion
            }

            // Retrieve the maximum available amount for the selected category from TransactionCategories
            decimal maxAvailableAmount = GetMaxAvailableAmount(CategoryName);

            if (allocatedAmount > maxAvailableAmount)
            {
                MessageBox.Show($"Allocated amount exceeds the available amount for the selected category. Maximum available amount is {maxAvailableAmount}");
                return;
            }

            string Description = richTextBox1.Text;
            // SQL query to insert data into the "Budgets" table
            string insertQuery = "INSERT INTO Budgets (User_ID, Description, Category_NAME, BudgetName, AllocatedAmount, StartDate, EndDate) " +
                                 "VALUES (@UserID, @Description, @CategoryID, @BudgetName, @AllocatedAmount, @StartDate, @EndDate)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query1 = "UPDATE TransactionCategories SET amount = amount - @amount";
                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    cmd.Parameters.AddWithValue("@Description", Description);
                    cmd.Parameters.AddWithValue("@CategoryID", CategoryName);
                    cmd.Parameters.AddWithValue("@BudgetName", budgetName);
                    cmd.Parameters.AddWithValue("@AllocatedAmount", allocatedAmount);
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    // Execute the query
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"Budget for {budgetName} Allocated Successfully");
                }
                using (SqlCommand cmd = new SqlCommand(query1, connection))
                {
                    cmd.Parameters.AddWithValue("@amount", allocatedAmount);
                    // Execute the query
                    cmd.ExecuteNonQuery();
                }
                string query2 = "INSERT INTO FinancialTransactions VALUES(@uid,@uname,@ttype,@tdate,@amount,@des)";
                using (SqlCommand cmd = new SqlCommand(query2, connection))
                {
                    cmd.Parameters.AddWithValue("@uid", userId);
                    cmd.Parameters.AddWithValue("@uname",username);
                    cmd.Parameters.AddWithValue("@ttype", CategoryName);
                    cmd.Parameters.AddWithValue("@tdate", DateTime.Today);
                    cmd.Parameters.AddWithValue("@amount", allocatedAmount);
                    cmd.Parameters.AddWithValue("@des",Description);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Custom method to get the maximum available amount for the selected category
        private decimal GetMaxAvailableAmount(string categoryName)
        {
            Int32  maxAvailableAmount = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT amount FROM TransactionCategories WHERE CategoryName = @CategoryName";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@CategoryName", categoryName);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            maxAvailableAmount = reader.GetInt32(0);
                        }
                    }
                }
            }
            return maxAvailableAmount;
        }

        private void department_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserScreen us=new UserScreen(id,username);
            us.Show();
        }
    }
}
