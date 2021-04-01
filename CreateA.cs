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
        public static string NameA = "";
        public static string AddressA = "";
        public static string FBAcc = "";
        public static string EmailA = "";
        public static string ConType = "Cellphone";
        public static string ConA = "";
        public static string MIdate = "";
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Cellphone")
            {
                button1.Text = "Landline";
                ConType = "Landline";
            }
            else
            {
                button1.Text = "Cellphone";
                ConType = "Cellphone";
            }
        }

        private void CanAcc_Click(object sender, EventArgs e)
        {
            Form accounts = new accountsView();
            this.Hide();
            accounts.ShowDialog();
            this.Close();
        }

        private void SubAcc_Click(object sender, EventArgs e)
        {
            NameA = NameTB.Text;
            AddressA = AddTB.Text;
            FBAcc = FBTB.Text;
            EmailA = EmailTB.Text;
            ConA = CnumTB.Text;
            MIdate = MoveInD.Value.ToString("yyyy-MM-dd");
            Form AConfirm = new AddConfirm();
            AConfirm.Show();
        }

        private void MoveInD_ValueChanged(object sender, EventArgs e)
        {
         
        }
    }
}
