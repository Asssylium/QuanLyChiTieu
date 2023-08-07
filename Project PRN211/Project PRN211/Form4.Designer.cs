namespace Project_PRN211
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            label1 = new Label();
            tbUser = new TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label2 = new Label();
            label3 = new Label();
            tbFirst = new TextBox();
            tbLast = new TextBox();
            tbGender = new TextBox();
            tbEmail = new TextBox();
            label4 = new Label();
            label5 = new Label();
            bnEdit = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(46, 38);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // tbUser
            // 
            tbUser.Location = new Point(201, 36);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(141, 23);
            tbUser.TabIndex = 1;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(46, 108);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 2;
            label2.Text = "Firstname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(46, 174);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 3;
            label3.Text = "Lastname";
            // 
            // tbFirst
            // 
            tbFirst.Location = new Point(201, 110);
            tbFirst.Name = "tbFirst";
            tbFirst.Size = new Size(141, 23);
            tbFirst.TabIndex = 4;
            // 
            // tbLast
            // 
            tbLast.Location = new Point(201, 176);
            tbLast.Name = "tbLast";
            tbLast.Size = new Size(141, 23);
            tbLast.TabIndex = 5;
            // 
            // tbGender
            // 
            tbGender.Location = new Point(201, 246);
            tbGender.Name = "tbGender";
            tbGender.Size = new Size(141, 23);
            tbGender.TabIndex = 6;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(201, 322);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(141, 23);
            tbEmail.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(46, 322);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 8;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(46, 248);
            label5.Name = "label5";
            label5.Size = new Size(61, 21);
            label5.TabIndex = 9;
            label5.Text = "Gender";
            // 
            // bnEdit
            // 
            bnEdit.Location = new Point(125, 382);
            bnEdit.Name = "bnEdit";
            bnEdit.Size = new Size(112, 37);
            bnEdit.TabIndex = 10;
            bnEdit.Text = "Edit";
            bnEdit.UseVisualStyleBackColor = true;
            bnEdit.Click += bnEdit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(348, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(440, 392);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(bnEdit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbEmail);
            Controls.Add(tbGender);
            Controls.Add(tbLast);
            Controls.Add(tbFirst);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbUser);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbUser;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label2;
        private Label label3;
        private TextBox tbFirst;
        private TextBox tbLast;
        private TextBox tbGender;
        private TextBox tbEmail;
        private Label label4;
        private Label label5;
        private Button bnEdit;
        private PictureBox pictureBox1;
    }
}