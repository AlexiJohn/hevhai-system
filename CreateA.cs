using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hevhai_system.account;
using MySql.Data.MySqlClient;

namespace hevhai_system
{
    public partial class CreateA : Form
    {

        accountCRUD crud = new accountCRUD();

        public CreateA()
        {
            InitializeComponent();
            crud.DB();
            ReallyCenterToScreen();
        }

        public static string NameA = "";
        public static string AddressA = "";
        public static string FBAcc = "";
        public static string EmailA = "";
        public static string ConType = "Cellphone";
        public static string ConA = "";
        public static string MIdate = "";

        public static Boolean addMode = true;

        public static CreateA getForm
        {
            get
            {
                if (_createa == null)
                {
                    _createa = new CreateA();
                    return _createa;
                }
                return _createa;
            }
        }

        private static CreateA _createa;

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
                CREATE_ACCOUNT();

                hevhai_system.accountsView.getForm.READ_ACCOUNT();
                hevhai_system.accountsView.getForm.Show();
                this.Hide();
            }
            else
            {
                UPDATE_ACCOUNT();

                checkEdit();


                hevhai_system.accountsView.getForm.READ_ACCOUNT();
                hevhai_system.accountsView.getForm.Show();
                this.Hide();
            }
        }

        public void setFields()
        {
            // SET FIELDS OF FORM BASED FROM DATA GRID
            LastNameTB.Text = hevhai_system.accountsView.getForm.row_last_name;
            spouse_fname_1_TB.Text = hevhai_system.accountsView.getForm.row_spouse_fname_1;
            spouse_fname_2_TB.Text = hevhai_system.accountsView.getForm.row_spouse_fname_2;
            AddTB.Text = hevhai_system.accountsView.getForm.row_address;
            FBTB.Text = hevhai_system.accountsView.getForm.row_fb_account;
            EmailTB.Text = hevhai_system.accountsView.getForm.row_email;
            CnumTB.Text = hevhai_system.accountsView.getForm.row_contact;
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

        public void CREATE_ACCOUNT()
        {
            crud.last_name = LastNameTB.Text;
            crud.spouse_fname_1 = spouse_fname_1_TB.Text;
            crud.spouse_fname_2 = spouse_fname_2_TB.Text;
            crud.address = AddTB.Text;
            crud.fb_account = FBTB.Text;
            crud.email = EmailTB.Text;
            crud.contact = CnumTB.Text;
            crud.moved_in_date = MoveInD.Value.ToString("yyyy-MM-dd");
            crud.Create_account();
        }

        public void UPDATE_ACCOUNT()
        {
            crud.account_id = hevhai_system.accountsView.getForm.row_account_id;

            crud.last_name = LastNameTB.Text;
            crud.spouse_fname_1 = spouse_fname_1_TB.Text;
            crud.spouse_fname_2 = spouse_fname_2_TB.Text;
            crud.address = AddTB.Text;
            crud.fb_account = FBTB.Text;
            crud.email = EmailTB.Text;
            crud.contact = CnumTB.Text;
            crud.moved_in_date = MoveInD.Value.ToString("yyyy-MM-dd");

            crud.Update_account();
        }

        protected void ReallyCenterToScreen()
        {
            Screen screen = Screen.FromControl(this);

            Rectangle workingArea = screen.WorkingArea;
            this.Location = new Point()
            {
                X = Math.Max(workingArea.X, workingArea.X + (workingArea.Width - this.Width) / 2),
                Y = Math.Max(workingArea.Y, workingArea.Y + (workingArea.Height - this.Height) / 2)
            };
        }
    }
}
