using Project_PRN211.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PRN211
{
    public partial class Form3 : Form
    {
        Function func = new Function();
        public Form3()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFirst.Text) || string.IsNullOrEmpty(tbLast.Text) || string.IsNullOrEmpty(tbUser.Text) || string.IsNullOrEmpty(tbPass.Text))
            {
                MessageBox.Show("Mọi thông tin cần điền đấy đủ !!!!");
            }
            else
            {
                if (btnFemale.Checked)
                {
                    string gender = "Female";
                    func.AddNewAccount(tbUser.Text, tbPass.Text, tbFirst.Text, tbLast.Text, gender);
                    this.Hide();
                }
                else if (btnMale.Checked)
                {
                    string gender = "Male";
                    func.AddNewAccount(tbUser.Text, tbPass.Text, tbFirst.Text, tbLast.Text, gender);
                    this.Hide();
                }
                else if (btnOther.Checked)
                {
                    string gender = "Other";
                    func.AddNewAccount(tbUser.Text, tbPass.Text, tbFirst.Text, tbLast.Text, gender);
                    this.Hide();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
