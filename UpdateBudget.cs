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
    public partial class UpdateBudget : Form
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Uni(worst)y\\7th Semester\\Enterprise System\\Project\\EAD-Project\\samiullahsaleem\\EAD-Project\\Finance\\DB\\Database1.mdf\"";

        public UpdateBudget()
        {
            InitializeComponent();
        }

        private void UpdateBudget_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet12.TransactionCategories' table. You can move, or remove it, as needed.
            this.transactionCategoriesTableAdapter.Fill(this.database1DataSet12.TransactionCategories);

        }
        private decimal GetBudgetAmount(string selectedCategory)
        {
            
            decimal budgetAmount = 0;  // Default value if category is not found

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Amount FROM TransactionCategories WHERE CategoryName = @CategoryName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CategoryName",selectedCategory);

                    // Execute the query and get the budget amount
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        budgetAmount = Convert.ToDecimal(result);
                    }
                }
            }

            return budgetAmount;
        }
        
        public    string department = null;
        
        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDepartment.SelectedItem != null)
            {
                DataRowView selectedRow = comboBoxDepartment.SelectedItem as DataRowView;

                if (selectedRow != null)
                {
                    department = selectedRow["CategoryName"].ToString();

                    // Use the selected value as needed
                }
            }
            // Call a method to retrieve the budget amount for the selected category
            decimal budgetAmount = GetBudgetAmount(department);

            // Display the budget amount in the TextBox
            ctext.Text = budgetAmount.ToString();

           
        }
        private void UpdateBudgetForCategory(string selectedCategory, decimal additionalAmount)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Begin a SQL transaction
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Update the budget for the selected category by adding the additional amount
                    string updateQuery = "UPDATE TransactionCategories SET Amount = @AdditionalAmount WHERE CategoryName = @CategoryName";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@AdditionalAmount", additionalAmount);
                        command.Parameters.AddWithValue("@CategoryName", selectedCategory);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Log the budget update in the Financial Transaction table
                            string logQuery = "INSERT INTO FinancialTransactions (user_id,username,TransactionType, TransactionDate, Amount, Description) " +
                                "VALUES (1,@username,@transactionType, @transactionDate, @amount, @description)";

                            using (SqlCommand logCommand = new SqlCommand(logQuery, connection, transaction))
                            {
                                logCommand.Parameters.AddWithValue("@transactionType", "Budget Update");
                                logCommand.Parameters.AddWithValue("@username", "ADMIN");
                                logCommand.Parameters.AddWithValue("@transactionDate", DateTime.Now);
                                logCommand.Parameters.AddWithValue("@amount", additionalAmount);
                                logCommand.Parameters.AddWithValue("@description", $"Budget updated for {selectedCategory}");

                                logCommand.ExecuteNonQuery();
                            }

                            MessageBox.Show("Budget updated successfully. Log created in Financial Transactions.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the budget.");
                        }
                    }

                    // Commit the transaction if everything succeeded
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // Rollback the transaction if there's an error
                    transaction.Rollback();
                    MessageBox.Show("Error occurred: " + ex.Message);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBoxAdditionalAmount.Text, out decimal additionalAmount))
            {
                // Call the method to update the budget
                UpdateBudgetForCategory(department, additionalAmount);
            }
            else
            {
                MessageBox.Show("Please enter a valid additional amount.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminScreen adminScreen = new AdminScreen();

            // Show Form2
            adminScreen.Show();
        }
    }
}
