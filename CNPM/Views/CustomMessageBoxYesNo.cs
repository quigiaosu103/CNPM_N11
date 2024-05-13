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
    public partial class CustomMessageBoxYesNo : Form
    {
        public CustomMessageBoxYesNo()
        {
            InitializeComponent();
        }

        public void SetMess(string mess)
        {
            guna2HtmlLabel2.Text = mess;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            this.Close();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();
        }

        private void CustomMessageBoxYesNo_Load(object sender, EventArgs e)
        {

        }
    }
}
