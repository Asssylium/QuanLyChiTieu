using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Project_PRN211
{
    public partial class Form2 : Form
    {

        Function func = new Function();
        public int userid;

        public Form2(int userid)
        {
            InitializeComponent();
            this.userid = userid;
            if (userid == 2)
            {
                btnAll.Visible = true;
            }
        }
        public void Form2_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            List<ChiTieu> list = func.GetChiTieuByUserId(userid);
            LoadData(list);
        }
        public void LoadData(List<ChiTieu> list)
        {
            int duong = 0;
            int am = 0;
            int sodu = 0;
            dgv.Columns.Clear();
            dgv.Columns.Add("ID", "ID");
            dgv.Columns.Add("Chude", "Chude");
            dgv.Columns.Add("Tien", "Tien");
            dgv.Columns.Add("Date", "Date");
            dgv.Columns.Add("NoiDung", "Noi Dung");
            dgv.Columns.Add("Nhom", "Nhom");
            dgv.Rows.Clear();
            foreach (ChiTieu item in list)
            {
                dgv.Rows.Add(item.Id, item.Chude, item.Money, item.Datetime.ToString("dd-MM-yyyy"), item.Noidung, item.group_name);
                if (item.Money >= 0)
                {
                    duong += (int)item.Money;
                }
                else
                {
                    am += (int)item.Money;
                }
            }
            label10.Text = duong + "VND";
            label8.Text = am + "VND";
            label15.Text = (duong + am) + "VND";
        }

        public void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTieu ct = new ChiTieu();
                ct.group_name = tbGroup.Text;
                ct.Chude = tbCD.Text;
                ct.Money = decimal.Parse(tbMoney.Text);
                ct.Datetime = date.Value;
                ct.Noidung = tbContent.Text.Trim();
                func.AddNewChiTieu(userid, ct.Chude, ct.Money, ct.Datetime, ct.Noidung, ct.group_name);
                List<ChiTieu> list = func.GetChiTieuByUserId(userid);
                LoadData(list);
                Refresh();
                MessageBox.Show("Tao moi chi tieu thanh cong");
            }
            catch
            {
                MessageBox.Show("Ban can kiem tra lai thong tin nhap vao");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(tbID.Text);
                func.Update(id, tbCD.Text, decimal.Parse(tbMoney.Text), date.Value, tbContent.Text, tbGroup.Text);
                List<ChiTieu> list = func.GetChiTieuByUserId(userid);
                LoadData(list);
                MessageBox.Show("Cap nhat chi tieu thanh cong");
                Refresh();
            }
            catch
            {
                MessageBox.Show("Ban can kiem tra lai thong tin nhap vao");
            }
        }
        public void Refresh()
        {
            tbID.Text = String.Empty;
            tbCD.Text = String.Empty;
            tbContent.Text = String.Empty;
            tbMoney.Text = String.Empty;
            date.Value = DateTime.Now;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex <= 100)
                {

                    tbID.Text = dgv.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    tbGroup.Text = dgv.Rows[e.RowIndex].Cells["nhom"].Value.ToString();
                    tbCD.Text = dgv.Rows[e.RowIndex].Cells["Chude"].Value.ToString();
                    tbMoney.Text = dgv.Rows[e.RowIndex].Cells["Tien"].Value.ToString();
                    string dateString = dgv.Rows[e.RowIndex].Cells["Date"].Value.ToString();
                    date.Value = DateTime.ParseExact(dateString, "dd-MM-yyyy", null);
                    tbContent.Text = dgv.Rows[e.RowIndex].Cells["NoiDung"].Value.ToString();
                }
                else
                    MessageBox.Show("Nothing here!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nothing here!");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(tbID.Text);
                DialogResult r = MessageBox.Show("Ban co chac muon xoa khong? ", "Thong bao", MessageBoxButtons.OKCancel);
                if (r == DialogResult.OK)
                {
                    func.Delete(id);
                    List<ChiTieu> list = func.GetChiTieuByUserId(userid);
                    LoadData(list);
                    MessageBox.Show($"Xoa chi tieu Id : {id} thanh cong");
                    Refresh();
                }

            }
            catch
            {
                MessageBox.Show("Ban can kiem tra lai thong tin nhap vao");
            }
        }

        private void btn3d_Click(object sender, EventArgs e)
        {
            List<ChiTieu> list = func.Get3day(userid);
            LoadData(list);
        }

        private void btn1w_Click(object sender, EventArgs e)
        {
            List<ChiTieu> list = func.Get1Week(userid);
            LoadData(list);
        }

        private void btn1M_Click(object sender, EventArgs e)
        {
            List<ChiTieu> list = func.Get1Month(userid);
            LoadData(list);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string text = tbSearch.Text;
            DateTime start = date2.Value;
            DateTime end = date.Value;
            List<ChiTieu> list = func.Search(userid, text, start, end);
            LoadData(list);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("No information to save");
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.ShowDialog();
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    for (int i = 0; i < dgv.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dgv.Columns.Count; j++)
                        {

                            if (j == dgv.Columns.Count - 1)
                            {
                                writer.Write(dgv.Rows[i].Cells[j].Value);
                                break;
                            }
                            writer.Write(dgv.Rows[i].Cells[j].Value + ";");

                        }
                        writer.WriteLine();
                    }
                    MessageBox.Show("Save to file success");
                }
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();

            if (string.IsNullOrEmpty(openFileDialog.FileName))
            {
                MessageBox.Show("No file selected");
                return;
            }

            try
            {
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    dgv.Rows.Clear();

                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] values = line.Split(';');

                        if (values.Length == dgv.Columns.Count)
                        {
                            dgv.Rows.Add(values);
                        }
                        else
                        {
                            MessageBox.Show("Invalid data format in the file");
                            return;
                        }
                    }
                    MessageBox.Show("Load from file success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void btnOut_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            List<ChiTieu> list = func.DisplayAll();
            LoadData(list);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(userid);
            form4.Show();
        }
    }
}
