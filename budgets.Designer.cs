namespace Finance
{
    partial class budgets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(budgets));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionCategoriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet19 = new Finance.Database1DataSet19();
            this.transactionCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet18 = new Finance.Database1DataSet18();
            this.transactionCategoriesTableAdapter = new Finance.Database1DataSet18TableAdapters.TransactionCategoriesTableAdapter();
            this.Back = new System.Windows.Forms.Button();
            this.transactionCategoriesTableAdapter1 = new Finance.Database1DataSet19TableAdapters.TransactionCategoriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionCategoriesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet18)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(117, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 147);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryIDDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transactionCategoriesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(154, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(342, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // categoryIDDataGridViewTextBoxColumn
            // 
            this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "Category_ID";
            this.categoryIDDataGridViewTextBoxColumn.HeaderText = "Category_ID";
            this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            this.categoryIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // transactionCategoriesBindingSource1
            // 
            this.transactionCategoriesBindingSource1.DataMember = "TransactionCategories";
            this.transactionCategoriesBindingSource1.DataSource = this.database1DataSet19;
            // 
            // database1DataSet19
            // 
            this.database1DataSet19.DataSetName = "Database1DataSet19";
            this.database1DataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionCategoriesBindingSource
            // 
            this.transactionCategoriesBindingSource.DataMember = "TransactionCategories";
            this.transactionCategoriesBindingSource.DataSource = this.database1DataSet18;
            // 
            // database1DataSet18
            // 
            this.database1DataSet18.DataSetName = "Database1DataSet18";
            this.database1DataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionCategoriesTableAdapter
            // 
            this.transactionCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Back.Location = new System.Drawing.Point(12, 402);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 4;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // transactionCategoriesTableAdapter1
            // 
            this.transactionCategoriesTableAdapter1.ClearBeforeFill = true;
            // 
            // budgets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(640, 428);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "budgets";
            this.Text = "budgets";
            this.Load += new System.EventHandler(this.budgets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionCategoriesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet18)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet18 database1DataSet18;
        private System.Windows.Forms.BindingSource transactionCategoriesBindingSource;
        private Database1DataSet18TableAdapters.TransactionCategoriesTableAdapter transactionCategoriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Back;
        private Database1DataSet19 database1DataSet19;
        private System.Windows.Forms.BindingSource transactionCategoriesBindingSource1;
        private Database1DataSet19TableAdapters.TransactionCategoriesTableAdapter transactionCategoriesTableAdapter1;
    }
}