using CNPM.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNPM.Model;
using Microsoft.VisualBasic.ApplicationServices;
using System.Net;
using Guna.UI2.WinForms;
using System.Globalization;
using System.Windows.Documents;
using System.Collections;
using System.Drawing.Imaging;
namespace CNPM.VIew
{
    public partial class frmTrangChu : Form
    {

        public frmTrangChu()
        {
            InitializeComponent();
            loadData();
            loadUserInfo();

        }

        public void loadData()
        {
            var creatorChart = new TrangChuController();
            creatorChart.ChartBar(gunaChart1, "Doanh thu");
            creatorChart.ChartPie(gunaChart2, "Doanh số sản phẩm", timeStart.Value, timeEnd.Value);
            lbMoneyThisMonth.Text = TrangChuController.getValue(DateTime.Now.Month).ToString("N0");
            lbMoneyMonth.Text = TrangChuController.getValue(DateTime.Now.Month - 1).ToString("N0");
            //var (listId, listAmount) = TrangChuController.getIdOrderItem(timeStart.Value, timeEnd.Value);
            loadBestSeller();

        }

        private void loadUserInfo()
        {
            lbRole.Text = UserAuthen.currentUser.Account.Role;
            lbName.Text = UserAuthen.currentUser.FullName;
            lbEmail.Text = UserAuthen.Email;
            lbPhone.Text = UserAuthen.currentUser.PhoneNumber;
            imgAvatar.Image = MyLib.Base64ToImage(UserAuthen.currentUser.Account.AvatarUrl);
        }

        public void loadBestSeller()
        {
            var a = TrangChuController.sortList(timeStart.Value, timeEnd.Value);
            if (a.Count > 0)
            {
                if (a.Count == 1)
                {
                    lbSp1.Text = TrangChuController.getName(a[0].First).ToString();
                    lbTotal1.Text = a[0].Second.ToString();
                    lbSp3.Visible = lbSp4.Visible = lbSp2.Visible = lbTotal3.Visible = lbTotal4.Visible = lbTotal2.Visible = false;
                }
                if (a.Count == 2)
                {
                    lbSp1.Text = TrangChuController.getName(a[0].First).ToString();
                    lbSp2.Text = TrangChuController.getName(a[1].First).ToString();
                    lbTotal1.Text = a[0].Second.ToString();
                    lbTotal2.Text = a[1].Second.ToString();
                    lbSp3.Visible = lbSp4.Visible = lbTotal3.Visible = lbTotal4.Visible = false;
                }
                else if (a.Count == 3)
                {

                    lbSp1.Text = TrangChuController.getName(a[0].First).ToString();
                    lbSp2.Text = TrangChuController.getName(a[1].First).ToString();
                    lbSp3.Text = TrangChuController.getName(a[2].First).ToString();
                    lbTotal1.Text = a[0].Second.ToString();
                    lbTotal2.Text = a[1].Second.ToString();
                    lbTotal3.Text = a[2].Second.ToString();
                    lbSp4.Visible = lbTotal4.Visible = false;
                }
                else if (a.Count > 4)
                {
                    lbSp1.Text = TrangChuController.getName(a[0].First).ToString();
                    lbSp2.Text = TrangChuController.getName(a[1].First).ToString();
                    lbSp3.Text = TrangChuController.getName(a[2].First).ToString();
                    lbSp4.Text = TrangChuController.getName(a[3].First).ToString();
                    lbTotal1.Text = a[0].Second.ToString();
                    lbTotal2.Text = a[1].Second.ToString();
                    lbTotal3.Text = a[2].Second.ToString();
                    lbTotal4.Text = a[3].Second.ToString();
                }
            }
            else
            {
                lbSp3.Visible = lbSp4.Visible = lbSp2.Visible = lbTotal3.Visible = lbTotal4.Visible = lbTotal2.Visible = lbTotal1.Visible = lbSp1.Visible = false;
            }

        }


        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void lbLocation_Click(object sender, EventArgs e)
        {

        }

        private void gunaChart1_Load(object sender, EventArgs e)
        {

        }

        private void timeStart_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timeStart_ValueChanged(object sender, EventArgs e)
        {
            var creatorChart = new TrangChuController();
            //TrangChuController.dataSetPieChart(timeStart.Value, timeEnd.Value);

            creatorChart.ChartPie(gunaChart2, "Doanh số sản phẩm", timeStart.Value, timeEnd.Value);
        }

        private void timeEnd_ValueChanged(object sender, EventArgs e)
        {
            var creatorChart = new TrangChuController();
            //TrangChuController.dataSetPieChart(timeStart.Value, timeEnd.Value);

            creatorChart.ChartPie(gunaChart2, "Doanh số sản phẩm", timeStart.Value, timeEnd.Value);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //TrangChuController.getOrderItem(timeStart.Value, timeEnd.Value);
            //var creatorChart = new TrangChuController();
            ////TrangChuController.dataSetPieChart(timeStart.Value, timeEnd.Value);

            //creatorChart.ChartPie(gunaChart2, "Doanh số sản phẩm", timeStart.Value, timeEnd.Value);

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbMoneyThisMonth_Click(object sender, EventArgs e)
        {

        }

        private void lbRole_Click(object sender, EventArgs e)
        {

        }

        private void full_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
