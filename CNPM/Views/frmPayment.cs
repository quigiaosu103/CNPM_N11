﻿using CNPM.Model;
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
using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore;
namespace CNPM.Views
{
    public partial class frmPayment : Form
    {
        PaymentController controller = new PaymentController();

        MyDatabaseContext databaseContext = new MyDatabaseContext();
       
        public DataPayment payment = new DataPayment();
        public frmPayment()
        {
            InitializeComponent();
            List<DataPayment> data = UserListProduct.dataPayment;
            if (data != null)
            {
                foreach (DataPayment us in data)
                {
                    handleAddToCart(us);
                    loadDataPayment();
                }
            }
            controller.loadInforBill(txtTotal, txtVAT, txtDiscount, txtFinalTotal);
        }
        private void loadDataPayment()
        {

            using (var context = new MyDatabaseContext())
            {
                txtTotal .Text= controller.totalPriceProduct(flowLayoutPanelPayment).ToString("N0");
            }
        }
        private CartItemPaymentView cartItemPaymentView;

        private void changeUpDownNumberic(object sender, EventArgs e)
        {

        }
        private void handleAddToCart(DataPayment data) 
        {
            CartItemPaymentView cartItemView = new CartItemPaymentView();
            cartItemView.productName = data.nameProduct;
            cartItemView.itemId = data.idProduct;
            cartItemView.itemPrice = int.Parse(data.priceProduct.ToString());
            cartItemView.totalPrice = int.Parse(data.priceProductTotal.ToString());
            cartItemView.itemAmount = data.numberProduct;
            flowLayoutPanelPayment.Controls.Add(cartItemView);
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            txtDiscount.Text = controller.getCodeDiscount(txtCodeDiscount).ToString() + "%";
            controller.getFinalTotal(txtTotal, txtVAT, txtDiscount, txtFinalTotal);
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            var textStatus = lbNamePayment.Text + " " + lbAddressPayment.Text + " " + lbPhonePayment.Text + " " + cbPaymentMethod.Text + " " + cbImportBill.Text;
            List<DataPayment> paymentList = new List<DataPayment>();
            foreach (Control control in flowLayoutPanelPayment.Controls)
            {
                CartItemPaymentView card = (CartItemPaymentView)control;
                paymentList.Add(new DataPayment() { idProduct = card.itemId, nameProduct = card.productName, priceProduct = card.itemPrice, numberProduct = card.itemAmount, priceProductTotal = card.totalPrice });
            }
            if (controller.checkInforCustomer(lbNamePayment, lbPhonePayment, lbAddressPayment))
            {
                controller.insertOder(txtFinalTotal.Text, textStatus, paymentList);
            }
            
        }
    }
}
