using Project_PRN211.Models;
using System.Net;
using System.Net.Mail;
namespace Project_PRN211
{
    public partial class Form1 : Form
    {
        private static readonly Random random = new Random();
        private const string validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()-_=+";
        Function func = new Function();
        public Form1()
        {
            InitializeComponent();
            tbPass.PasswordChar = '*';
            tbOld.PasswordChar = '*';
            tbNew.PasswordChar = '*';
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbName.Text;
            string password = tbPass.Text;
            if (func.CheckAccount(username, password))
            {
                int userid = func.getUserID(username);
                Form2 chitieuDetailForm = new Form2(userid);
                chitieuDetailForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid information, please enter again");
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
        }
        public static string GenerateRandomPassword(int length)
        {
            char[] password = new char[length];
            for (int i = 0; i < length; i++)
            {
                password[i] = validChars[random.Next(validChars.Length)];
            }

            return new string(password);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string username = tbName.Text;
            int userid = func.getUserID(username);
            string senderEmailAddress = "hanhndhe170885@fpt.edu.vn";
            string appPassword = "zcekalvgugsxumwx";
            string recipientEmail = func.GetEmail(userid);
            string subject = "Reset Password";
            string randomPassword = GenerateRandomPassword(8);
            func.ChangePassword(userid, randomPassword);
            string body = $"Your new password: {randomPassword}";
            try
            {
                using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtpClient.EnableSsl = true;
                    smtpClient.Credentials = new NetworkCredential(senderEmailAddress, appPassword);

                    using (MailMessage mailMessage = new MailMessage(senderEmailAddress, recipientEmail, subject, body))
                    {
                        smtpClient.Send(mailMessage);
                        MessageBox.Show("Email sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            tbOld.Visible = false;
            tbNew.Visible = false;
            btnSubmit.Visible = false;
            List<Account> acc = func.getAllAccount();
            string Name = tbName.Text.ToLower();
            if (!string.IsNullOrEmpty(Name))
            {

                foreach (var item in acc)
                {
                    if (item.Username.Equals(Name))
                    {
                        label3.Visible = true;
                        label4.Visible = true;
                        tbOld.Visible = true;
                        tbNew.Visible = true;
                        btnSubmit.Visible = true;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please input username !!!!!!");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            List<Account> acc = func.getAllAccount();
            string newpass = tbNew.Text;
            string oldpass = tbOld.Text;
            if (func.ChangePass(oldpass, newpass))
            {
                MessageBox.Show("Change password successfully");
            }
            else
            {
                MessageBox.Show("Incorrect password");
            }
        }
    }
}