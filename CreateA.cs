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
    public partial class CreateA : Form
    {
        public CreateA()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Cellphone")
            {
                button1.Text = "Landline";
            }
            else
            {
                button1.Text = "Cellphone";
            }
        }

        private void CanAcc_Click(object sender, EventArgs e)
        {
            Form cancelA = new accountsView();
            this.Hide();
            cancelA.ShowDialog();
            this.Close();
        }
    }
}
