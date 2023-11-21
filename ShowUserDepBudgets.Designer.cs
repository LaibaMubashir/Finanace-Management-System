namespace Finance
{
    partial class ShowUserDepBudgets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowUserDepBudgets));
            this.Back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.budgetIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allocatedAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet20 = new Finance.Database1DataSet20();
            this.budgetsTableAdapter = new Finance.Database1DataSet20TableAdapters.BudgetsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet20)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Back.Location = new System.Drawing.Point(12, 473);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 11;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(273, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 147);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.budgetIDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.budgetNameDataGridViewTextBoxColumn,
            this.allocatedAmountDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.categoryNAMEDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.budgetsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(57, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(839, 253);
            this.dataGridView1.TabIndex = 12;
            // 
            // budgetIDDataGridViewTextBoxColumn
            // 
            this.budgetIDDataGridViewTextBoxColumn.DataPropertyName = "Budget_ID";
            this.budgetIDDataGridViewTextBoxColumn.HeaderText = "Budget_ID";
            this.budgetIDDataGridViewTextBoxColumn.Name = "budgetIDDataGridViewTextBoxColumn";
            this.budgetIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "User_ID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "User_ID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // budgetNameDataGridViewTextBoxColumn
            // 
            this.budgetNameDataGridViewTextBoxColumn.DataPropertyName = "BudgetName";
            this.budgetNameDataGridViewTextBoxColumn.HeaderText = "BudgetName";
            this.budgetNameDataGridViewTextBoxColumn.Name = "budgetNameDataGridViewTextBoxColumn";
            // 
            // allocatedAmountDataGridViewTextBoxColumn
            // 
            this.allocatedAmountDataGridViewTextBoxColumn.DataPropertyName = "AllocatedAmount";
            this.allocatedAmountDataGridViewTextBoxColumn.HeaderText = "AllocatedAmount";
            this.allocatedAmountDataGridViewTextBoxColumn.Name = "allocatedAmountDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            // 
            // categoryNAMEDataGridViewTextBoxColumn
            // 
            this.categoryNAMEDataGridViewTextBoxColumn.DataPropertyName = "Category_NAME";
            this.categoryNAMEDataGridViewTextBoxColumn.HeaderText = "Category_NAME";
            this.categoryNAMEDataGridViewTextBoxColumn.Name = "categoryNAMEDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // budgetsBindingSource
            // 
            this.budgetsBindingSource.DataMember = "Budgets";
            this.budgetsBindingSource.DataSource = this.database1DataSet20;
            // 
            // database1DataSet20
            // 
            this.database1DataSet20.DataSetName = "Database1DataSet20";
            this.database1DataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // budgetsTableAdapter
            // 
            this.budgetsTableAdapter.ClearBeforeFill = true;
            // 
            // ShowUserDepBudgets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(927, 508);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ShowUserDepBudgets";
            this.Text = "ShowUserDepBudgets";
            this.Load += new System.EventHandler(this.ShowUserDepBudgets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet20)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet20 database1DataSet20;
        private System.Windows.Forms.BindingSource budgetsBindingSource;
        private Database1DataSet20TableAdapters.BudgetsTableAdapter budgetsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allocatedAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}