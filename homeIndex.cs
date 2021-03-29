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
    public partial class homeIndex : Form
    {
        public homeIndex()
        {
            InitializeComponent();
        }

        private void accountsButton_Click(object sender, EventArgs e)
        {
            Form accounts = new accountsView();
            this.Hide();
            accounts.ShowDialog();
            this.Close();
        }

        private void paymentsButton_Click(object sender, EventArgs e)
        {
            Form payments = new paymentsView();
            this.Hide();
            payments.ShowDialog();
            this.Close();
        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            Form summary = new summaryView();
            this.Hide();
            summary.ShowDialog();
            this.Close();
        }
    }
}
