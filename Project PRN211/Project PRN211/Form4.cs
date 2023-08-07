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
    public partial class Form4 : Form
    {
        int userid;
        Function func = new Function();
        public Form4(int userid)
        {
            InitializeComponent();
            this.userid = userid;
            Account acc = func.GetAccountByUserID(userid);
            tbUser.Text = acc.Username;
            tbFirst.Text = acc.Firstname;
            tbLast.Text = acc.Lastname;
            tbGender.Text = acc.Gender;
            tbEmail.Text = acc.Email;
        }

        private void bnEdit_Click(object sender, EventArgs e)
        {
            string Username = tbUser.Text.Trim();
            string Firstname = tbFirst.Text.Trim();
            string Lastname = tbLast.Text.Trim();
            string Gender = tbGender.Text.Trim();
            string Email = tbEmail.Text.Trim();
            if (Username == null && Firstname == null && Lastname == null && Gender == null)
            {
                MessageBox.Show("Null information");
            }
            else
            {
                func.UpdateAccount(Username, Firstname, Lastname, Gender, Email);
                MessageBox.Show("Update succesfully");
            }
        }
    }
}
