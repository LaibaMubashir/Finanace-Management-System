namespace Finance
{
    partial class UpdateBudget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateBudget));
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.transactionCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet12 = new Finance.Database1DataSet12();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ctext = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAdditionalAmount = new System.Windows.Forms.TextBox();
            this.transactionCategoriesTableAdapter = new Finance.Database1DataSet12TableAdapters.TransactionCategoriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.transactionCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.DataSource = this.transactionCategoriesBindingSource;
            this.comboBoxDepartment.DisplayMember = "CategoryName";
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(352, 241);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(166, 21);
            this.comboBoxDepartment.TabIndex = 53;
            this.comboBoxDepartment.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartment_SelectedIndexChanged);
            // 
            // transactionCategoriesBindingSource
            // 
            this.transactionCategoriesBindingSource.DataMember = "TransactionCategories";
            this.transactionCategoriesBindingSource.DataSource = this.database1DataSet12;
            // 
            // database1DataSet12
            // 
            this.database1DataSet12.DataSetName = "Database1DataSet12";
            this.database1DataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Font = new System.Drawing.Font("PMingLiU-ExtB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 515);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 24);
            this.button2.TabIndex = 52;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("PMingLiU-ExtB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(267, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 29);
            this.button1.TabIndex = 51;
            this.button1.Text = "Update Budget";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 50;
            this.label2.Text = "Current Budget";
            // 
            // ctext
            // 
            this.ctext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctext.Location = new System.Drawing.Point(352, 286);
            this.ctext.Name = "ctext";
            this.ctext.Size = new System.Drawing.Size(166, 26);
            this.ctext.TabIndex = 49;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(179, 241);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(90, 16);
            this.usernameLabel.TabIndex = 48;
            this.usernameLabel.Text = "Department";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(131, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 145);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 55;
            this.label1.Text = "Amount";
            // 
            // textBoxAdditionalAmount
            // 
            this.textBoxAdditionalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdditionalAmount.Location = new System.Drawing.Point(352, 334);
            this.textBoxAdditionalAmount.Name = "textBoxAdditionalAmount";
            this.textBoxAdditionalAmount.Size = new System.Drawing.Size(166, 26);
            this.textBoxAdditionalAmount.TabIndex = 54;
            // 
            // transactionCategoriesTableAdapter
            // 
            this.transactionCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // UpdateBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(657, 551);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAdditionalAmount);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctext);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UpdateBudget";
            this.Text = "UpdateBudget";
            this.Load += new System.EventHandler(this.UpdateBudget_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ctext;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAdditionalAmount;
        private Database1DataSet12 database1DataSet12;
        private System.Windows.Forms.BindingSource transactionCategoriesBindingSource;
        private Database1DataSet12TableAdapters.TransactionCategoriesTableAdapter transactionCategoriesTableAdapter;
    }
}