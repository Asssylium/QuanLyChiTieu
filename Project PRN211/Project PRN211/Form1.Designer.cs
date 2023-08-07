namespace Project_PRN211
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            tbName = new TextBox();
            tbPass = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            btnReset = new Button();
            btnChange = new Button();
            label3 = new Label();
            label4 = new Label();
            tbOld = new TextBox();
            tbNew = new TextBox();
            btnSubmit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(935, 498);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(333, 58);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 1;
            label1.Text = "Username: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(333, 108);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // tbName
            // 
            tbName.Location = new Point(506, 56);
            tbName.Name = "tbName";
            tbName.Size = new Size(147, 23);
            tbName.TabIndex = 3;
            // 
            // tbPass
            // 
            tbPass.Location = new Point(506, 110);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(148, 23);
            tbPass.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(333, 175);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(96, 25);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(506, 175);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(117, 25);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(506, 227);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(117, 28);
            btnReset.TabIndex = 7;
            btnReset.Text = "Forgot Password";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(333, 227);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(96, 45);
            btnChange.TabIndex = 8;
            btnChange.Text = "Change Password";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(333, 314);
            label3.Name = "label3";
            label3.Size = new Size(108, 21);
            label3.TabIndex = 9;
            label3.Text = "Old Password:";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(333, 365);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(115, 21);
            label4.TabIndex = 10;
            label4.Text = "New Password:";
            label4.Visible = false;
            // 
            // tbOld
            // 
            tbOld.Location = new Point(506, 316);
            tbOld.Name = "tbOld";
            tbOld.Size = new Size(148, 23);
            tbOld.TabIndex = 11;
            tbOld.Visible = false;
            // 
            // tbNew
            // 
            tbNew.Location = new Point(506, 363);
            tbNew.Name = "tbNew";
            tbNew.Size = new Size(148, 23);
            tbNew.TabIndex = 12;
            tbNew.Visible = false;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(408, 416);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(135, 33);
            btnSubmit.TabIndex = 13;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Visible = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 529);
            Controls.Add(btnSubmit);
            Controls.Add(tbNew);
            Controls.Add(tbOld);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnChange);
            Controls.Add(btnReset);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(tbPass);
            Controls.Add(tbName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Log In";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox tbName;
        private TextBox tbPass;
        private Button btnLogin;
        private Button btnRegister;
        private Button btnReset;
        private Button btnChange;
        private Label label3;
        private Label label4;
        private TextBox tbOld;
        private TextBox tbNew;
        private Button btnSubmit;
    }
}