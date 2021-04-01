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

        public static List<string> account = new List<string>();
        public static Boolean addMode = true;

        public static CreateA getForm
        {
            get
            {
                if (_createa == null)
                {
                    _createa = new CreateA();
                }
                return _createa;
            }
        }

        private static CreateA _createa;


        public List<string> getAccount
        {
            get
            {
                return account;
            }
        }


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
            hevhai_system.accountsView.getForm.Show();
            this.Hide();
        }

        private void SubAcc_Click(object sender, EventArgs e)
        {
            if (addMode == true)
            {
                addNewAccount();
            }
            else
            {

            }
        }

        public void addNewAccount()
        {
            NameA = NameTB.Text;
            AddressA = AddTB.Text;
            FBAcc = FBTB.Text;
            EmailA = EmailTB.Text;
            ConA = CnumTB.Text;
            MIdate = MoveInD.Value.ToString("yyyy-MM-dd");

            account.Clear();
            account.Add(NameA);
            account.Add(AddressA);
            account.Add(FBAcc);
            account.Add(EmailA);
            account.Add(ConA);
            account.Add(MIdate);

            Form AConfirm = new AddConfirm();
            AConfirm.Show();

            hevhai_system.accountsView.getForm.addRowDatagrid();
        }

        private void MoveInD_ValueChanged(object sender, EventArgs e)
        {
         
        }

        public void setFields()
        {
            DataGridViewRow aRow = new accountsView().datagridrow;

            NameTB.Text = (string)aRow.Cells[0].Value;
            AddTB.Text = (string)aRow.Cells[1].Value;
            FBTB.Text = (string)aRow.Cells[2].Value;
            EmailTB.Text = (string)aRow.Cells[3].Value;
            CnumTB.Text = (string)aRow.Cells[4].Value;
        }

        public void checkEdit()
        {
            if (addMode == false)
            {
                addMode = true;
            }
            else
            {
                addMode = false;
            }
            
        }
    }
}
