namespace Project_PRN211
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            label2 = new Label();
            label100 = new Label();
            label343 = new Label();
            label123 = new Label();
            tbFirst = new TextBox();
            tbLast = new TextBox();
            tbUser = new TextBox();
            tbPass = new TextBox();
            btnRegister = new Button();
            btnMale = new RadioButton();
            btnFemale = new RadioButton();
            btnOther = new RadioButton();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 12.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(71, 75);
            label1.Name = "label1";
            label1.Size = new Size(156, 27);
            label1.TabIndex = 0;
            label1.Text = "Nhập Firstname: ";
            // 
            // label2
            // 
            label2.Font = new Font("Yu Mincho", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(262, 9);
            label2.Name = "label2";
            label2.Size = new Size(257, 46);
            label2.TabIndex = 1;
            label2.Text = "Quản Lý Chi Tiêu";
            // 
            // label100
            // 
            label100.Font = new Font("Verdana", 12.75F, FontStyle.Italic, GraphicsUnit.Point);
            label100.Location = new Point(71, 236);
            label100.Name = "label100";
            label100.Size = new Size(156, 27);
            label100.TabIndex = 2;
            label100.Text = "Nhập password: ";
            // 
            // label343
            // 
            label343.Font = new Font("Verdana", 12.75F, FontStyle.Italic, GraphicsUnit.Point);
            label343.Location = new Point(71, 181);
            label343.Name = "label343";
            label343.Size = new Size(156, 27);
            label343.TabIndex = 3;
            label343.Text = "Nhập username: ";
            // 
            // label123
            // 
            label123.Font = new Font("Verdana", 12.75F, FontStyle.Italic, GraphicsUnit.Point);
            label123.Location = new Point(71, 122);
            label123.Name = "label123";
            label123.Size = new Size(156, 27);
            label123.TabIndex = 4;
            label123.Text = "Nhập Lastname: ";
            // 
            // tbFirst
            // 
            tbFirst.Location = new Point(277, 75);
            tbFirst.Name = "tbFirst";
            tbFirst.Size = new Size(179, 23);
            tbFirst.TabIndex = 5;
            // 
            // tbLast
            // 
            tbLast.Location = new Point(277, 124);
            tbLast.Name = "tbLast";
            tbLast.Size = new Size(179, 23);
            tbLast.TabIndex = 6;
            // 
            // tbUser
            // 
            tbUser.Location = new Point(277, 181);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(179, 23);
            tbUser.TabIndex = 7;
            // 
            // tbPass
            // 
            tbPass.Location = new Point(277, 236);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(179, 23);
            tbPass.TabIndex = 8;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.Location = new Point(277, 385);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(155, 41);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnMale
            // 
            btnMale.AutoSize = true;
            btnMale.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btnMale.Location = new Point(163, 331);
            btnMale.Name = "btnMale";
            btnMale.Size = new Size(64, 22);
            btnMale.TabIndex = 10;
            btnMale.TabStop = true;
            btnMale.Text = "Male";
            btnMale.UseVisualStyleBackColor = true;
            // 
            // btnFemale
            // 
            btnFemale.AutoSize = true;
            btnFemale.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btnFemale.Location = new Point(277, 331);
            btnFemale.Name = "btnFemale";
            btnFemale.Size = new Size(85, 22);
            btnFemale.TabIndex = 11;
            btnFemale.TabStop = true;
            btnFemale.Text = "Female";
            btnFemale.UseVisualStyleBackColor = true;
            // 
            // btnOther
            // 
            btnOther.AutoSize = true;
            btnOther.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btnOther.Location = new Point(408, 331);
            btnOther.Name = "btnOther";
            btnOther.Size = new Size(72, 22);
            btnOther.TabIndex = 12;
            btnOther.TabStop = true;
            btnOther.Text = "Other";
            btnOther.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(569, 385);
            button1.Name = "button1";
            button1.Size = new Size(216, 41);
            button1.TabIndex = 13;
            button1.Text = "Already Have Account?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(518, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(393, 309);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.Font = new Font("Verdana", 12.75F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(71, 286);
            label3.Name = "label3";
            label3.Size = new Size(156, 27);
            label3.TabIndex = 15;
            label3.Text = "Nhập gmail: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(277, 286);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 23);
            textBox1.TabIndex = 16;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 450);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(btnOther);
            Controls.Add(btnFemale);
            Controls.Add(btnMale);
            Controls.Add(btnRegister);
            Controls.Add(tbPass);
            Controls.Add(tbUser);
            Controls.Add(tbLast);
            Controls.Add(tbFirst);
            Controls.Add(label123);
            Controls.Add(label343);
            Controls.Add(label100);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Đăng kí tài khoản";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label100;
        private Label label343;
        private Label label123;
        private TextBox tbFirst;
        private TextBox tbLast;
        private TextBox tbUser;
        private TextBox tbPass;
        private Button btnRegister;
        private RadioButton btnMale;
        private RadioButton btnFemale;
        private RadioButton btnOther;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox textBox1;
    }
}