using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNPM.Controller;
using CNPM.Model;
using Guna.UI2.AnimatorNS;
namespace CNPM.Views
{
    public partial class frmManagerAccount : Form
    {
        Account account = new Account();
        string phone;
        public frmManagerAccount()
        {
            InitializeComponent();
            LoadUserInfo();
            ManagerAccountController.loadDataAccount(accountManager);


        }

        private void LoadUserInfo()
        {
            txtAuthenName.Text = "Hi, " + UserAuthen.currentUser.FullName.ToString();
        }
        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            if (account.UserName == null)
            {

                new CustomMessageBox("Vui lòng chọn dữ liệu muốn thay đổi", "Lỗi").ShowDialog();
                return;
            }
            new MessageBoxUpdateAccount("Cập nhật thông tin", "Lưu", account, phone).ShowDialog();
            accountManager.Rows.Clear();
            ManagerAccountController.loadDataAccount(accountManager);
        }
        int indexRow;
        private string checkValue(string data)
        {

            if (data == null || data == "")
            {
                return "";
            }
            return data;

        }
        private void accountManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new MessageBoxAddEmployee().ShowDialog();
            accountManager.Rows.Clear();
            ManagerAccountController.loadDataAccount(accountManager);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ManagerAccountController.loadDataAccountSearch(accountManager, ManagerAccountController.searchAccount(txtSearch.Text, cbSearch.Text));
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            accountManager.Rows.Clear();
            ManagerAccountController.loadDataAccount(accountManager);
        }

        private void accountManager_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            if(indexRow > 0)
            {
                DataGridViewRow row = accountManager.Rows[indexRow];

                account.UserName = checkValue(row.Cells[0].Value?.ToString());
                phone = checkValue(row.Cells[1].Value?.ToString());
                account.Role = checkValue(row.Cells[2].Value?.ToString());
                account.Email = checkValue(row.Cells[3].Value?.ToString());
            }
           
            
        }
    }
}
