namespace Finance
{
    partial class ReturnLoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnLoan));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Back = new System.Windows.Forms.Button();
            this.paybacklabel = new System.Windows.Forms.Label();
            this.pTextBox = new System.Windows.Forms.TextBox();
            this.clTextBox = new System.Windows.Forms.TextBox();
            this.currentLoan = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(122, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 147);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Back.Location = new System.Drawing.Point(12, 467);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 4;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // paybacklabel
            // 
            this.paybacklabel.AutoSize = true;
            this.paybacklabel.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paybacklabel.Location = new System.Drawing.Point(164, 262);
            this.paybacklabel.Name = "paybacklabel";
            this.paybacklabel.Size = new System.Drawing.Size(67, 16);
            this.paybacklabel.TabIndex = 12;
            this.paybacklabel.Text = "Payback";
            // 
            // pTextBox
            // 
            this.pTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTextBox.Location = new System.Drawing.Point(337, 262);
            this.pTextBox.Name = "pTextBox";
            this.pTextBox.Size = new System.Drawing.Size(166, 26);
            this.pTextBox.TabIndex = 11;
            // 
            // clTextBox
            // 
            this.clTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clTextBox.Location = new System.Drawing.Point(337, 214);
            this.clTextBox.Name = "clTextBox";
            this.clTextBox.Size = new System.Drawing.Size(166, 26);
            this.clTextBox.TabIndex = 10;
            // 
            // currentLoan
            // 
            this.currentLoan.AutoSize = true;
            this.currentLoan.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLoan.Location = new System.Drawing.Point(164, 217);
            this.currentLoan.Name = "currentLoan";
            this.currentLoan.Size = new System.Drawing.Size(102, 16);
            this.currentLoan.TabIndex = 9;
            this.currentLoan.Text = "Current Loan";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(263, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReturnLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(667, 502);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.paybacklabel);
            this.Controls.Add(this.pTextBox);
            this.Controls.Add(this.clTextBox);
            this.Controls.Add(this.currentLoan);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ReturnLoan";
            this.Text = "ReturnLoan";
            this.Load += new System.EventHandler(this.ReturnLoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label paybacklabel;
        private System.Windows.Forms.TextBox pTextBox;
        private System.Windows.Forms.TextBox clTextBox;
        private System.Windows.Forms.Label currentLoan;
        private System.Windows.Forms.Button button1;
    }
}