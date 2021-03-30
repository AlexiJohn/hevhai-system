using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hevhai_system
{
    public partial class CreateP : Form
    {
        public CreateP()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void CanPay_Click(object sender, EventArgs e)
        {
            Form payments = new paymentsView();
            this.Hide();
            payments.ShowDialog();
            this.Close();
        }
    }
}
