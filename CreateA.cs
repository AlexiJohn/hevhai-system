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

        public Boolean addMode { get; set; }

        public string formLabel
        {
            set { CAlabel.Text = value; }
        }

        public CreateA()
        {
            InitializeComponent();
            crud.DB();
            ReallyCenterToScreen();
        }

        

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
            }
            else
            {
                button1.Text = "Cellphone";
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
            MoveInD.Value = DateTime.Parse(hevhai_system.accountsView.getForm.row_moved_in_date);
        }

        public void clearFields()
        {

            // SET FIELDS OF FORM BASED FROM DATA GRID
            LastNameTB.Text = "";
            spouse_fname_1_TB.Text = "";
            spouse_fname_2_TB.Text = "";
            AddTB.Text = "";
            FBTB.Text = "";
            EmailTB.Text = "";
            CnumTB.Text = "";
            MoveInD.Value = DateTime.Today;

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

        private void CreateA_FormClosed(object sender, FormClosingEventArgs e)
        {
            try
            {
                hevhai_system.accountsView.getForm.Close();
            }
            catch
            {

            }
            try
            {
                hevhai_system.paymentsView.getForm.Close();
            }
            catch
            {

            }
            try
            {
                hevhai_system.summaryView.getForm.Close();
            }
            catch
            {

            }
            try
            {
                hevhai_system.homeIndex.getForm.Close();
            }
            catch
            {

            }
            try
            {
                hevhai_system.CreateP.getForm.Close();
            }
            catch
            {

            }
            try
            {
                hevhai_system.outstandingForm.getForm.Close();
            }
            catch
            {

            }
        }
    }
}
