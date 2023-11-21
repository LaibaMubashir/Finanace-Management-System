namespace Finance
{
    partial class AllocateBudget
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllocateBudget));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.transactionCategoriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet11 = new Finance.Database1DataSet11();
            this.transactionCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet9 = new Finance.Database1DataSet9();
            this.budgetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet7 = new Finance.Database1DataSet7();
            this.budgetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet6 = new Finance.Database1DataSet6();
            this.database1DataSet5 = new Finance.Database1DataSet5();
            this.budgetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budgetTableAdapter = new Finance.Database1DataSet5TableAdapters.BudgetTableAdapter();
            this.budgetTableAdapter1 = new Finance.Database1DataSet6TableAdapters.BudgetTableAdapter();
            this.budgetTableAdapter2 = new Finance.Database1DataSet7TableAdapters.BudgetTableAdapter();
            this.transactionCategoriesTableAdapter = new Finance.Database1DataSet9TableAdapters.TransactionCategoriesTableAdapter();
            this.transactionCategoriesTableAdapter1 = new Finance.Database1DataSet11TableAdapters.TransactionCategoriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionCategoriesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(132, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 145);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(353, 323);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(166, 26);
            this.txtAmount.TabIndex = 40;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(180, 278);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(90, 16);
            this.usernameLabel.TabIndex = 38;
            this.usernameLabel.Text = "Department";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Sitka Display", 10.75F);
            this.button1.Location = new System.Drawing.Point(274, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 29);
            this.button1.TabIndex = 44;
            this.button1.Text = "Allocate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 549);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 24);
            this.button2.TabIndex = 45;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.DataSource = this.transactionCategoriesBindingSource1;
            this.comboBoxDepartment.DisplayMember = "CategoryName";
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(353, 278);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(166, 21);
            this.comboBoxDepartment.TabIndex = 46;
            this.comboBoxDepartment.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // transactionCategoriesBindingSource1
            // 
            this.transactionCategoriesBindingSource1.DataMember = "TransactionCategories";
            this.transactionCategoriesBindingSource1.DataSource = this.database1DataSet11;
            // 
            // database1DataSet11
            // 
            this.database1DataSet11.DataSetName = "Database1DataSet11";
            this.database1DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionCategoriesBindingSource
            // 
            this.transactionCategoriesBindingSource.DataMember = "TransactionCategories";
            this.transactionCategoriesBindingSource.DataSource = this.database1DataSet9;
            // 
            // database1DataSet9
            // 
            this.database1DataSet9.DataSetName = "Database1DataSet9";
            this.database1DataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // budgetBindingSource2
            // 
            this.budgetBindingSource2.DataMember = "Budget";
            this.budgetBindingSource2.DataSource = this.database1DataSet7;
            // 
            // database1DataSet7
            // 
            this.database1DataSet7.DataSetName = "Database1DataSet7";
            this.database1DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // budgetBindingSource1
            // 
            this.budgetBindingSource1.DataMember = "Budget";
            this.budgetBindingSource1.DataSource = this.database1DataSet6;
            // 
            // database1DataSet6
            // 
            this.database1DataSet6.DataSetName = "Database1DataSet6";
            this.database1DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSet5
            // 
            this.database1DataSet5.DataSetName = "Database1DataSet5";
            this.database1DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // budgetBindingSource
            // 
            this.budgetBindingSource.DataMember = "Budget";
            this.budgetBindingSource.DataSource = this.database1DataSet5;
            // 
            // budgetTableAdapter
            // 
            this.budgetTableAdapter.ClearBeforeFill = true;
            // 
            // budgetTableAdapter1
            // 
            this.budgetTableAdapter1.ClearBeforeFill = true;
            // 
            // budgetTableAdapter2
            // 
            this.budgetTableAdapter2.ClearBeforeFill = true;
            // 
            // transactionCategoriesTableAdapter
            // 
            this.transactionCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // transactionCategoriesTableAdapter1
            // 
            this.transactionCategoriesTableAdapter1.ClearBeforeFill = true;
            // 
            // AllocateBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(693, 585);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AllocateBudget";
            this.Text = "AllocateBudget";
            this.Load += new System.EventHandler(this.AllocateBudget_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionCategoriesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private Database1DataSet5 database1DataSet5;
        private System.Windows.Forms.BindingSource budgetBindingSource;
        private Database1DataSet5TableAdapters.BudgetTableAdapter budgetTableAdapter;
        private Database1DataSet6 database1DataSet6;
        private System.Windows.Forms.BindingSource budgetBindingSource1;
        private Database1DataSet6TableAdapters.BudgetTableAdapter budgetTableAdapter1;
        private Database1DataSet7 database1DataSet7;
        private System.Windows.Forms.BindingSource budgetBindingSource2;
        private Database1DataSet7TableAdapters.BudgetTableAdapter budgetTableAdapter2;
        private Database1DataSet9 database1DataSet9;
        private System.Windows.Forms.BindingSource transactionCategoriesBindingSource;
        private Database1DataSet9TableAdapters.TransactionCategoriesTableAdapter transactionCategoriesTableAdapter;
        private Database1DataSet11 database1DataSet11;
        private System.Windows.Forms.BindingSource transactionCategoriesBindingSource1;
        private Database1DataSet11TableAdapters.TransactionCategoriesTableAdapter transactionCategoriesTableAdapter1;
    }
}