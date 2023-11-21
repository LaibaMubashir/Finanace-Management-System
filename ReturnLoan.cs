using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Finance
{
    public partial class ReturnLoan : Form
    {
        static private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Uni(worst)y\\7th Semester\\Enterprise System\\Project\\EAD-Project\\samiullahsaleem\\EAD-Project\\Finance\\DB\\Database1.mdf\"";

        public ReturnLoan()
        {
            InitializeComponent();
            decimal loanBudgetAmount = GetBudgetAmountForLoan();
            clTextBox.Text=loanBudgetAmount.ToString();
        }

        private void ReturnLoan_Load(object sender, EventArgs e)
        {

        }
        private decimal GetBudgetAmountForLoan()
        {
            decimal budgetAmount = 0; // Default value

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT amount FROM transactionCategories  WHERE CategoryName = 'Loan'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
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
        private bool IsLoanPaybackAmountValid(decimal loanPaybackAmount)
        {
            decimal incomeAmount = 0; // Default value

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Retrieve the income amount from the TransactionCategories table
                string incomeQuery = "SELECT Amount FROM TransactionCategories WHERE CategoryName = 'Income'";

                using (SqlCommand incomeCommand = new SqlCommand(incomeQuery, connection))
                {
                    object incomeResult = incomeCommand.ExecuteScalar();

                    if (incomeResult != null && incomeResult != DBNull.Value)
                    {
                        incomeAmount = Convert.ToDecimal(incomeResult);
                    }
                }

                // Check if the loan payback amount is less than the income amount
                if (loanPaybackAmount < incomeAmount)
                {
                    return true; // Loan payback amount is valid
                }
                else
                {
                    return false; // Loan payback amount is not valid
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminScreen adminScreen = new AdminScreen();

            // Show Form2
            adminScreen.Show();
        }
        private bool DeductFromIncomeAndLoanDepartments(decimal amountToDeduct)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Deduct the specified amount from the "Income" category
                    string updateIncomeQuery = "UPDATE TransactionCategories SET Amount = Amount - @AmountToDeduct WHERE CategoryName = 'Income'";

                    using (SqlCommand incomeCommand = new SqlCommand(updateIncomeQuery, connection, transaction))
                    {
                        incomeCommand.Parameters.AddWithValue("@AmountToDeduct", amountToDeduct);
                        int incomeRowsAffected = incomeCommand.ExecuteNonQuery();

                        // Deduct the specified amount from the "Loan" category
                        string updateLoanQuery = "UPDATE TransactionCategories SET Amount = Amount - @AmountToDeduct WHERE CategoryName = 'Loan'";

                        using (SqlCommand loanCommand = new SqlCommand(updateLoanQuery, connection, transaction))
                        {
                            loanCommand.Parameters.AddWithValue("@AmountToDeduct", amountToDeduct);
                            int loanRowsAffected = loanCommand.ExecuteNonQuery();

                            if (incomeRowsAffected > 0 && loanRowsAffected > 0)
                            {
                                // Log the loan payback in the Financial Transaction table
                                string logQuery = "INSERT INTO FinancialTransactions (user_id,username,TransactionType, TransactionDate, Amount, Description) " +
                                "VALUES (1,@username,@transactionType, @transactionDate, @amount, @description)";


                                using (SqlCommand logCommand = new SqlCommand(logQuery, connection, transaction))
                                {
                                    logCommand.Parameters.AddWithValue("@transactionType", "Loan Payback");
                                    logCommand.Parameters.AddWithValue("@username", "ADMIN");                                    logCommand.Parameters.AddWithValue("@transactionDate", DateTime.Now);
                                    logCommand.Parameters.AddWithValue("@amount", amountToDeduct);
                                    logCommand.Parameters.AddWithValue("@description", "Loan payback");

                                    logCommand.ExecuteNonQuery();
                                }

                                // Commit the transaction if everything succeeded
                                transaction.Commit();
                                return true;
                            }
                            else
                            {
                                transaction.Rollback();
                                return false; // Deduction failed for one or both departments
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error occurred: " + ex.Message);
                    return false;
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            decimal amount;
            if (decimal.TryParse(pTextBox.Text, out amount) && amount > 0)
            {
                bool isAmountValid = IsLoanPaybackAmountValid(amount);
                if (isAmountValid)
                {
                    // The loan payback amount is valid
                    bool deductionSuccessful = DeductFromIncomeAndLoanDepartments(amount);

                    if (deductionSuccessful)
                    {
                        decimal loanBudgetAmount = GetBudgetAmountForLoan();
                        MessageBox.Show($"Loan Payback Successful!\n Updated Amount as Loan : {loanBudgetAmount}");

                    }
                    else
                    {
                        MessageBox.Show("Error!");
                    }

                }
                else
                {
                    // The loan payback amount is not valid
                    MessageBox.Show("Accounts don't have this amount to pay!");

                }
            }

           
        }
    }
}
