namespace Project_PRN211
{
    partial class Form2
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
            dgv = new DataGridView();
            label1 = new Label();
            tbID = new TextBox();
            tbCD = new TextBox();
            label2 = new Label();
            tbMoney = new TextBox();
            label3 = new Label();
            date = new DateTimePicker();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label4 = new Label();
            label5 = new Label();
            tbContent = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDel = new Button();
            label6 = new Label();
            date2 = new DateTimePicker();
            btn3d = new Button();
            btn1w = new Button();
            btn1M = new Button();
            btnSearch = new Button();
            tbSearch = new TextBox();
            btnSave = new Button();
            btnRead = new Button();
            btnOut = new Button();
            label7 = new Label();
            tbGroup = new TextBox();
            btnAll = new Button();
            button1 = new Button();
            label15 = new Label();
            label14 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(58, 120);
            dgv.Name = "dgv";
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(611, 293);
            dgv.TabIndex = 0;
            dgv.CellClick += dgv_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(744, 101);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 1;
            label1.Text = "ID";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbID
            // 
            tbID.Location = new Point(827, 93);
            tbID.Name = "tbID";
            tbID.ReadOnly = true;
            tbID.Size = new Size(84, 23);
            tbID.TabIndex = 2;
            // 
            // tbCD
            // 
            tbCD.Location = new Point(826, 177);
            tbCD.Name = "tbCD";
            tbCD.Size = new Size(180, 23);
            tbCD.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(741, 180);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 4;
            label2.Text = "Chủ Đề";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbMoney
            // 
            tbMoney.Location = new Point(826, 223);
            tbMoney.Name = "tbMoney";
            tbMoney.Size = new Size(180, 23);
            tbMoney.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(744, 231);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 6;
            label3.Text = "Số tiền";
            // 
            // date
            // 
            date.Location = new Point(826, 278);
            date.Name = "date";
            date.Size = new Size(200, 23);
            date.TabIndex = 7;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(744, 278);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 8;
            label4.Text = "Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(741, 337);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 9;
            label5.Text = "Nội Dung";
            // 
            // tbContent
            // 
            tbContent.Location = new Point(826, 329);
            tbContent.Name = "tbContent";
            tbContent.Size = new Size(180, 23);
            tbContent.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(741, 390);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(836, 390);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(941, 390);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(75, 23);
            btnDel.TabIndex = 13;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(86, 42);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 14;
            label6.Text = "Date";
            // 
            // date2
            // 
            date2.Location = new Point(158, 38);
            date2.Name = "date2";
            date2.Size = new Size(200, 23);
            date2.TabIndex = 15;
            // 
            // btn3d
            // 
            btn3d.Location = new Point(58, 78);
            btn3d.Name = "btn3d";
            btn3d.Size = new Size(75, 23);
            btn3d.TabIndex = 16;
            btn3d.Text = "3 Days";
            btn3d.UseVisualStyleBackColor = true;
            btn3d.Click += btn3d_Click;
            // 
            // btn1w
            // 
            btn1w.Location = new Point(168, 78);
            btn1w.Name = "btn1w";
            btn1w.Size = new Size(75, 23);
            btn1w.TabIndex = 17;
            btn1w.Text = "1 Week";
            btn1w.UseVisualStyleBackColor = true;
            btn1w.Click += btn1w_Click;
            // 
            // btn1M
            // 
            btn1M.Location = new Point(283, 79);
            btn1M.Name = "btn1M";
            btn1M.Size = new Size(75, 23);
            btn1M.TabIndex = 18;
            btn1M.Text = "1 Month";
            btn1M.UseVisualStyleBackColor = true;
            btn1M.Click += btn1M_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(508, 38);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(386, 38);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(100, 23);
            tbSearch.TabIndex = 20;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(194, 419);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(87, 33);
            btnSave.TabIndex = 21;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(358, 421);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(128, 31);
            btnRead.TabIndex = 22;
            btnRead.Text = "Read Chi Tieu";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnOut
            // 
            btnOut.Location = new Point(58, 419);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(84, 33);
            btnOut.TabIndex = 23;
            btnOut.Text = "Log Out";
            btnOut.UseVisualStyleBackColor = true;
            btnOut.Click += btnOut_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(744, 141);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 24;
            label7.Text = "Group";
            // 
            // tbGroup
            // 
            tbGroup.Location = new Point(827, 133);
            tbGroup.Name = "tbGroup";
            tbGroup.Size = new Size(179, 23);
            tbGroup.TabIndex = 25;
            // 
            // btnAll
            // 
            btnAll.Location = new Point(386, 78);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(75, 23);
            btnAll.TabIndex = 26;
            btnAll.Text = "All users";
            btnAll.UseVisualStyleBackColor = true;
            btnAll.Visible = false;
            btnAll.Click += btnAll_Click;
            // 
            // button1
            // 
            button1.Location = new Point(493, 78);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 27;
            button1.Text = "Profile";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(867, 69);
            label15.Name = "label15";
            label15.Size = new Size(44, 15);
            label15.TabIndex = 33;
            label15.Text = "label15";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(731, 69);
            label14.Name = "label14";
            label14.Size = new Size(100, 15);
            label14.TabIndex = 32;
            label14.Text = "So du                    :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(867, 38);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 31;
            label8.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(731, 38);
            label9.Name = "label9";
            label9.Size = new Size(100, 15);
            label9.TabIndex = 30;
            label9.Text = "So tien bo ra        :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(867, 9);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 29;
            label10.Text = "label10";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(731, 9);
            label11.Name = "label11";
            label11.Size = new Size(101, 15);
            label11.TabIndex = 28;
            label11.Text = "So tien nhan vao :";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 502);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(button1);
            Controls.Add(btnAll);
            Controls.Add(tbGroup);
            Controls.Add(label7);
            Controls.Add(btnOut);
            Controls.Add(btnRead);
            Controls.Add(btnSave);
            Controls.Add(tbSearch);
            Controls.Add(btnSearch);
            Controls.Add(btn1M);
            Controls.Add(btn1w);
            Controls.Add(btn3d);
            Controls.Add(date2);
            Controls.Add(label6);
            Controls.Add(btnDel);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(tbContent);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(date);
            Controls.Add(label3);
            Controls.Add(tbMoney);
            Controls.Add(label2);
            Controls.Add(tbCD);
            Controls.Add(tbID);
            Controls.Add(label1);
            Controls.Add(dgv);
            Name = "Form2";
            Text = "Details";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private Label label1;
        private TextBox tbID;
        private TextBox tbCD;
        private Label label2;
        private TextBox tbMoney;
        private Label label3;
        private DateTimePicker date;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label4;
        private Label label5;
        private TextBox tbContent;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDel;
        private Label label6;
        private DateTimePicker date2;
        private Button btn3d;
        private Button btn1w;
        private Button btn1M;
        private Button btnSearch;
        private TextBox tbSearch;
        private Button btnSave;
        private Button btnRead;
        private Button btnOut;
        private Label label7;
        private TextBox tbGroup;
        private Button btnAll;
        private Button button1;
        private Label label15;
        private Label label14;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}