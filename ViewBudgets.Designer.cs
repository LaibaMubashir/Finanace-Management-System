
namespace Finance
{
    partial class ViewBudgets
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet = new Finance.Database1DataSet();
            this.budgetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budgetsTableAdapter = new Finance.Database1DataSetTableAdapters.BudgetsTableAdapter();
            this.budgetIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editColumnButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.budgetIDDataGridViewTextBoxColumn,
            this.budgetNameDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.actualAmountDataGridViewTextBoxColumn,
            this.budgetDescriptionDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.editColumnButton,
            this.Delete});
            this.dataGridView1.DataSource = this.budgetsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1044, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // budgetsBindingSource
            // 
            this.budgetsBindingSource.DataMember = "Budgets";
            this.budgetsBindingSource.DataSource = this.database1DataSet;
            // 
            // budgetsTableAdapter
            // 
            this.budgetsTableAdapter.ClearBeforeFill = true;
            // 
            // budgetIDDataGridViewTextBoxColumn
            // 
            this.budgetIDDataGridViewTextBoxColumn.DataPropertyName = "BudgetID";
            this.budgetIDDataGridViewTextBoxColumn.HeaderText = "BudgetID";
            this.budgetIDDataGridViewTextBoxColumn.Name = "budgetIDDataGridViewTextBoxColumn";
            this.budgetIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // budgetNameDataGridViewTextBoxColumn
            // 
            this.budgetNameDataGridViewTextBoxColumn.DataPropertyName = "BudgetName";
            this.budgetNameDataGridViewTextBoxColumn.HeaderText = "BudgetName";
            this.budgetNameDataGridViewTextBoxColumn.Name = "budgetNameDataGridViewTextBoxColumn";
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
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            // 
            // actualAmountDataGridViewTextBoxColumn
            // 
            this.actualAmountDataGridViewTextBoxColumn.DataPropertyName = "ActualAmount";
            this.actualAmountDataGridViewTextBoxColumn.HeaderText = "ActualAmount";
            this.actualAmountDataGridViewTextBoxColumn.Name = "actualAmountDataGridViewTextBoxColumn";
            // 
            // budgetDescriptionDataGridViewTextBoxColumn
            // 
            this.budgetDescriptionDataGridViewTextBoxColumn.DataPropertyName = "BudgetDescription";
            this.budgetDescriptionDataGridViewTextBoxColumn.HeaderText = "BudgetDescription";
            this.budgetDescriptionDataGridViewTextBoxColumn.Name = "budgetDescriptionDataGridViewTextBoxColumn";
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            // 
            // editColumnButton
            // 
            this.editColumnButton.HeaderText = "Edit";
            this.editColumnButton.Name = "editColumnButton";
            this.editColumnButton.ReadOnly = true;
            this.editColumnButton.Text = "Edit";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            // 
            // ViewBudgets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 450);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewBudgets";
            this.Text = "ViewBudgets";
            this.Load += new System.EventHandler(this.ViewBudgets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource budgetsBindingSource;
        private Database1DataSetTableAdapters.BudgetsTableAdapter budgetsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn editColumnButton;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}