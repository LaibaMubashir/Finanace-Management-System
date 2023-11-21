namespace Finance
{
    partial class AdminScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminScreen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Back = new System.Windows.Forms.Button();
            this.CreateUser = new System.Windows.Forms.Button();
            this.UpadateUser = new System.Windows.Forms.Button();
            this.DisplayUsers = new System.Windows.Forms.Button();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.AllocateBudget = new System.Windows.Forms.Button();
            this.UpdateBudget = new System.Windows.Forms.Button();
            this.database1DataSet1 = new Finance.Database1DataSet();
            this.ShowBudget = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 147);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Back.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(516, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 3;
            this.Back.Text = "Log Out";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // CreateUser
            // 
            this.CreateUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CreateUser.Font = new System.Drawing.Font("PMingLiU-ExtB", 16F);
            this.CreateUser.Location = new System.Drawing.Point(27, 230);
            this.CreateUser.Name = "CreateUser";
            this.CreateUser.Size = new System.Drawing.Size(96, 38);
            this.CreateUser.TabIndex = 4;
            this.CreateUser.Text = "Create";
            this.CreateUser.UseVisualStyleBackColor = false;
            this.CreateUser.Click += new System.EventHandler(this.CreateUser_Click);
            // 
            // UpadateUser
            // 
            this.UpadateUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UpadateUser.Font = new System.Drawing.Font("PMingLiU-ExtB", 16F);
            this.UpadateUser.Location = new System.Drawing.Point(168, 231);
            this.UpadateUser.Name = "UpadateUser";
            this.UpadateUser.Size = new System.Drawing.Size(104, 38);
            this.UpadateUser.TabIndex = 5;
            this.UpadateUser.Text = "Update";
            this.UpadateUser.UseVisualStyleBackColor = false;
            this.UpadateUser.Click += new System.EventHandler(this.UpadateUser_Click);
            // 
            // DisplayUsers
            // 
            this.DisplayUsers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DisplayUsers.Font = new System.Drawing.Font("PMingLiU-ExtB", 16F);
            this.DisplayUsers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DisplayUsers.Location = new System.Drawing.Point(438, 231);
            this.DisplayUsers.Name = "DisplayUsers";
            this.DisplayUsers.Size = new System.Drawing.Size(95, 38);
            this.DisplayUsers.TabIndex = 6;
            this.DisplayUsers.Text = "Display";
            this.DisplayUsers.UseVisualStyleBackColor = false;
            this.DisplayUsers.Click += new System.EventHandler(this.DisplayUsers_Click);
            // 
            // DeleteUser
            // 
            this.DeleteUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteUser.Font = new System.Drawing.Font("PMingLiU-ExtB", 16F);
            this.DeleteUser.Location = new System.Drawing.Point(306, 231);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(95, 38);
            this.DeleteUser.TabIndex = 7;
            this.DeleteUser.Text = "Delete";
            this.DeleteUser.UseVisualStyleBackColor = false;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // AllocateBudget
            // 
            this.AllocateBudget.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AllocateBudget.Font = new System.Drawing.Font("PMingLiU-ExtB", 16F);
            this.AllocateBudget.Location = new System.Drawing.Point(27, 359);
            this.AllocateBudget.Name = "AllocateBudget";
            this.AllocateBudget.Size = new System.Drawing.Size(96, 35);
            this.AllocateBudget.TabIndex = 8;
            this.AllocateBudget.Text = "Allocate";
            this.AllocateBudget.UseVisualStyleBackColor = false;
            this.AllocateBudget.Click += new System.EventHandler(this.AllocateBudget_Click);
            // 
            // UpdateBudget
            // 
            this.UpdateBudget.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UpdateBudget.Font = new System.Drawing.Font("PMingLiU-ExtB", 16F);
            this.UpdateBudget.Location = new System.Drawing.Point(168, 359);
            this.UpdateBudget.Name = "UpdateBudget";
            this.UpdateBudget.Size = new System.Drawing.Size(104, 35);
            this.UpdateBudget.TabIndex = 9;
            this.UpdateBudget.Text = "Update";
            this.UpdateBudget.UseVisualStyleBackColor = false;
            this.UpdateBudget.Click += new System.EventHandler(this.UpdateBudget_Click);
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ShowBudget
            // 
            this.ShowBudget.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ShowBudget.Font = new System.Drawing.Font("PMingLiU-ExtB", 16F);
            this.ShowBudget.Location = new System.Drawing.Point(27, 454);
            this.ShowBudget.Name = "ShowBudget";
            this.ShowBudget.Size = new System.Drawing.Size(181, 35);
            this.ShowBudget.TabIndex = 10;
            this.ShowBudget.Text = "Show Transactions";
            this.ShowBudget.UseVisualStyleBackColor = false;
            this.ShowBudget.Click += new System.EventHandler(this.ShowBudget_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU-ExtB", 20F);
            this.label1.Location = new System.Drawing.Point(22, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "User Operations";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU-ExtB", 20F);
            this.label2.Location = new System.Drawing.Point(22, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 27);
            this.label2.TabIndex = 12;
            this.label2.Text = "Budget Operations";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("PMingLiU-ExtB", 16F);
            this.button1.Location = new System.Drawing.Point(438, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "Display";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Font = new System.Drawing.Font("PMingLiU-ExtB", 16F);
            this.button2.Location = new System.Drawing.Point(306, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 35);
            this.button2.TabIndex = 15;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(27, 539);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Log Out";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(598, 585);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowBudget);
            this.Controls.Add(this.UpdateBudget);
            this.Controls.Add(this.AllocateBudget);
            this.Controls.Add(this.DeleteUser);
            this.Controls.Add(this.DisplayUsers);
            this.Controls.Add(this.UpadateUser);
            this.Controls.Add(this.CreateUser);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("PMingLiU-ExtB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "AdminScreen";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button CreateUser;
        private System.Windows.Forms.Button UpadateUser;
        private System.Windows.Forms.Button DisplayUsers;
        private System.Windows.Forms.Button DeleteUser;
        private System.Windows.Forms.Button AllocateBudget;
        private System.Windows.Forms.Button UpdateBudget;
        private Database1DataSet database1DataSet1;
        private System.Windows.Forms.Button ShowBudget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}