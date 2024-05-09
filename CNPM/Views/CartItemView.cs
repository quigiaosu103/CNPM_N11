using CNPM.Controller;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM.Views
{
    public partial class CartItemView : UserControl
    {
        public int itemPrice;
        public string itemId;

        public CartItemView()
        {
            InitializeComponent();
        }

        private void CartItemView_Load(object sender, EventArgs e)
        {
           
        }

        private void inputCartItemAmount_ValueChanged(object sender, EventArgs e)
        {
            this.itemAmount = (int)inputCartItemAmount.Value;
            this.totalPrice = this.itemPrice * this.itemAmount;
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if(sender is Guna2ImageButton button)
            {
                var component = button.Parent as CartItemView;
                DialogResult  dr = new CustomMessageBoxYesNo().ShowDialog();
                switch (dr)
                {
                    case DialogResult.Yes:
                        button.Parent.Parent.Controls.Remove(component);
                        break;
                    case DialogResult.No:
                        break;
                }
                
            }
        }

        public string productName
        {
            get { return txtCartItemName.Text; }
            set { txtCartItemName.Text = value; }
        }

        public int totalPrice
        {
            get { return Int32.Parse(txtCartItemTotal.Text); }
            set { txtCartItemTotal.Text = value + ""; }
        }

        public int itemAmount
        {
            get { return (int)inputCartItemAmount.Value; }
            set { inputCartItemAmount.Value = value; }
        }
    }
}
