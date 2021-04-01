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

        public accountsView accountsView = hevhai_system.accountsView.getForm;
        public CreateA CreateA = hevhai_system.CreateA.getForm;

        public static homeIndex getForm
        {
            get
            {
                if (_homeIndex == null)
                {
                    _homeIndex = new homeIndex();
                }
                return _homeIndex;
            }
        }

        private static homeIndex _homeIndex;

        private void accountsButton_Click(object sender, EventArgs e)
        {
            hevhai_system.accountsView.getForm.Show();
            this.Hide();
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
