using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hevhai_system.payment;
using hevhai_system.account;
using MySql.Data.MySqlClient;

namespace hevhai_system
{
    public partial class CreateP : Form
    {
        paymentCRUD crud = new paymentCRUD();
        accountCRUD accCRUD = new accountCRUD();

        public CreateP()
        {
            InitializeComponent();
            crud.DB();
            accCRUD.DB();
            ReallyCenterToScreen();
            populateComboBox();
        }

        public Boolean addMode { get; set; }

        private static CreateP _CreateP;

        public static CreateP getForm
        {
            get
            {
                if (_CreateP == null)
                {
                    _CreateP = new CreateP();
                }
                return _CreateP;
            }
        }

        private void CanPay_Click(object sender, EventArgs e)
        {
            hevhai_system.paymentsView.getForm.Show();
            this.Hide();
        }

        private void SubPay_Click(object sender, EventArgs e)
        {
            if (addMode == true)
            {
                CREATE_PAYMENT();

                hevhai_system.paymentsView.getForm.READ_PAYMENT();
                hevhai_system.paymentsView.getForm.Show();
                this.Hide();
            }
            else
            {
                UPDATE_PAYMENT();

                hevhai_system.paymentsView.getForm.READ_PAYMENT();
                hevhai_system.paymentsView.getForm.Show();
                this.Hide();
            }
        }

        // SET FIELDS OF FORM BASED FROM DATA GRID
        public void setFields()
        {
            ORTB.Text = hevhai_system.paymentsView.getForm.row_or_no;
            accountComboBox.SelectedValue = hevhai_system.paymentsView.getForm.row_account_id;
            PaymentD.Value = DateTime.Parse(hevhai_system.paymentsView.getForm.row_date_of_payment);
            AmDueTB.Text = hevhai_system.paymentsView.getForm.row_amount;
            PaymentDD.SelectedItem = hevhai_system.paymentsView.getForm.row_mode_of_payment;
            PayFor.Text = hevhai_system.paymentsView.getForm.row_payment_for;
            DescTB.Text = hevhai_system.paymentsView.getForm.row_description;
        }

        public void clearFields()
        {
            ORTB.Text = "";
            PaymentD.Value = DateTime.Today;
            AmDueTB.Text = "";
            PayFor.Text = "";
            DescTB.Text = "";
        }

        public void CREATE_PAYMENT()
        {
            crud.or_no = ORTB.Text;
            crud.account_id = accountComboBox.SelectedValue.ToString();
            crud.date_of_payment = PaymentD.Value.ToString("yyyy-MM-dd");
            crud.amount = AmDueTB.Text;
            crud.mode_of_payment = PaymentDD.SelectedItem.ToString();
            crud.payment_for = PayFor.Text;
            crud.description = DescTB.Text;
            crud.Create_payment();
        }

        public void UPDATE_PAYMENT()
        {
            crud.or_no = ORTB.Text;
            crud.account_id = accountComboBox.SelectedValue.ToString();
            crud.date_of_payment = PaymentD.Value.ToString("yyyy-MM-dd");
            crud.amount = AmDueTB.Text;
            crud.mode_of_payment = PaymentDD.SelectedItem.ToString();
            crud.payment_for = PayFor.Text;
            crud.description = DescTB.Text;
            crud.Update_payment();
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

        public void populateComboBox()
        {
            accCRUD.Read_account_name();
            accountComboBox.DataSource = accCRUD.dt;
            accountComboBox.DisplayMember = "name";
            accountComboBox.ValueMember = "account_id";

            PaymentDD.Items.Clear();
            PaymentDD.Items.Add("Cash");
            PaymentDD.Items.Add("Gcash");
            PaymentDD.Items.Add("Check");
        }

    }
}

