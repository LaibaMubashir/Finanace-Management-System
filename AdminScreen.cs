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
    
    public partial class AdminScreen : Form
    {

        // Connection string to your SQL Server instance
        //string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Uni(worst)y\\7th Semester\\Enterprise System\\Project\\EAD-Project\\samiullahsaleem\\EAD-Project\\Finance\\DB\\Database1.mdf\"";
        public AdminScreen()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DisplayUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowAllUsers user = new ShowAllUsers();
            //Show Create Form
            user.Show();
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteUser user = new DeleteUser();
            //Show Create Form
            user.Show();
        }

        private void UpadateUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateUser user = new UpdateUser();
            //Show Create Form
            user.Show();
        }

        private void CreateUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateUser user= new CreateUser();
            //Show Create Form
            user.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AllocateBudget_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllocateBudget budget = new AllocateBudget();
            //Show Create Form
            budget.Show();
        }

        private void UpdateBudget_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateBudget budget = new UpdateBudget();
            //Show Create Form
            budget.Show();
        }

        private void ShowBudget_Click(object sender, EventArgs e)
        {
            this.Hide();
            transactions form= new transactions();
            form.Show();
           
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
            transactions form1 = new transactions();
            form1.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            budgets form = new budgets();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReturnLoan rl=new ReturnLoan ();    
            rl.Show();
        }
    }
}
