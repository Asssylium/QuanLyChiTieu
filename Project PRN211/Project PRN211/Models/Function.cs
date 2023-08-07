using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Project_PRN211.Models
{
    internal class Function
    {
        projectPRN211Context context = new projectPRN211Context();
        public bool CheckAccount(string username, string password)
        {
            List<Account> accounts = context.Accounts.ToList();
            Account account = accounts.FirstOrDefault(x => x.Username == username && x.Password == password);

            if (account != null)
            {
                return true;
            }
            return false;
        }
        public int getUserID(string username)
        {
            Account account = context.Accounts.FirstOrDefault(x => x.Username == username);

            if (account != null)
            {
                return account.Id;
            }
            return -1;
        }
        public List<ChiTieu> GetChiTieuByUserId(int userId)
        {
            List<ChiTieu> chiTieuList = new List<ChiTieu>();

            foreach (var item in context.ChiTieus)
            {
                if (item.Userid == userId)
                {
                    chiTieuList.Add(item);
                }
            }

            return chiTieuList;
        }

        public void Update(int id, string chude, decimal money, DateTime datetime, string noidung, string group)
        {
            ChiTieu ct = context.ChiTieus.FirstOrDefault(x => x.Id == id);
            ct.group_name = group;
            ct.Chude = chude;
            ct.Money = money;
            ct.Datetime = datetime;
            ct.Noidung = noidung;
            context.ChiTieus.Update(ct);
            context.SaveChanges();
        }
        public void AddNewChiTieu(int userId, string chude, decimal money, DateTime datetime, string noidung, string group)
        {
            using (var context = new projectPRN211Context())
            {
                ChiTieu newChiTieu = new ChiTieu
                {
                    Userid = userId,
                    group_name = group,
                    Chude = chude,
                    Money = money,
                    Datetime = datetime,
                    Noidung = noidung
                };
                context.ChiTieus.Add(newChiTieu);
                context.SaveChanges();
            }
        }
        public void AddNewAccount(string username,string password,string firstname,string lastname,string gender)
        {
            Account newaccount = new Account();
            newaccount.Username = username;
            newaccount.Gender = gender;
            newaccount.Firstname = firstname;
            newaccount.Lastname = lastname;
            newaccount.Password = password;
            context.Accounts.Add(newaccount);
            context.SaveChanges();
            
        }
        public void Delete(int id)
        {
            ChiTieu ct = context.ChiTieus.FirstOrDefault(x => x.Id == id);
            context.ChiTieus.Remove(ct);
            context.SaveChanges();
        }
        public List<ChiTieu> Search(int userid,string title, DateTime start, DateTime end)
        {
                List<ChiTieu> list = context.ChiTieus
                    .Where(x => x.Userid == userid && x.Chude.ToLower().Contains(title.ToLower()) && x.Datetime >= start.Date && x.Datetime <= end.Date)
                    .OrderByDescending(x => x.Datetime)
                    .ThenBy(x => x.Money)
                    .ToList();
                return list;
        }
        public  List<ChiTieu> Get3day(int userid)
        {
                List<ChiTieu> list = context.ChiTieus.Where(x => x.Userid == userid && x.Datetime >= DateTime.Now.Date.AddDays(-3)).OrderByDescending(x => x.Datetime).ThenBy(x => x.Money).ToList();
                return list;
        }
        public  List<ChiTieu> Get1Week(int userid)
        {
                List<ChiTieu> list = context.ChiTieus.Where(x => x.Userid == userid && x.Datetime >= DateTime.Now.Date.AddDays(-7)).OrderByDescending(x => x.Datetime).ThenBy(x => x.Money).ToList();
                return list;
        }
        public  List<ChiTieu> Get1Month(int userid)
        {
                List<ChiTieu> list = context.ChiTieus.Where(x => x.Userid == userid && x.Datetime >= DateTime.Now.Date.AddMonths(-1)).OrderByDescending(x => x.Datetime).ThenBy(x => x.Money).ToList();
                return list;
        }
        public string GetEmail(int userid)
        {
            Account account = context.Accounts.FirstOrDefault(x => x.Id == userid);
            return account.Email;
        }
        public void ChangePassword(int id,string newpass)
        {
            Account acc = context.Accounts.FirstOrDefault(x => x.Id == id);
            acc.Password = newpass;
            context.Accounts.Update(acc);
            context.SaveChanges();
        }
        public List<ChiTieu> DisplayAll()
        {
            List<ChiTieu> ct = context.ChiTieus.ToList();
            return ct;
        }
        public List<Account> getAllAccount()
        {
            List<Account> acc = context.Accounts.ToList();
            return acc;
        }
        public Boolean ChangePass(string oldpass, string newpass)
        {
            List<Account> acc = context.Accounts.ToList();
            foreach (var item in acc)
            {
                if (item.Password.Equals(oldpass))
                {
                    item.Password = newpass;
                    context.Accounts.Update(item);
                    context.SaveChanges();
                    return true;
                    break;
                }
            }
            return false;
        }
        public Account GetAccountByUserID(int userid)
        {
            Account acc = context.Accounts.FirstOrDefault(x => x.Id == userid);
            return acc;

        }
        public void UpdateAccount(string username, string firstname, string lastname, string gender, string email)
        {
            Account account = context.Accounts.FirstOrDefault(x => x.Username.Equals(username));
            account.Username = username;
            account.Gender = gender;
            account.Firstname = firstname;
            account.Lastname = lastname;
            account.Email = email;
            context.Accounts.Update(account);
            context.SaveChanges();

        }
    }
}
