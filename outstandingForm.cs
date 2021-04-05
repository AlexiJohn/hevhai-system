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
using hevhai_system.summary;
using MySql.Data.MySqlClient;

namespace hevhai_system
{
    public partial class outstandingForm : Form
    {

        // VARIABLES HERE

        accountCRUD accCRUD = new accountCRUD();
        summaryCRUD crud = new summaryCRUD();
        

        public Boolean addMode { get; set; }

        public string formLabel
        {
            set { CAlabel.Text = value; }
        }


        public outstandingForm()
        {
            InitializeComponent();
            ReallyCenterToScreen();
            accCRUD.DB();
            crud.DB();
        }

        public static outstandingForm getForm
        {
            get
            {
                if (_outstandingForm == null)
                {
                    _outstandingForm = new outstandingForm();
                }
                return _outstandingForm;
            }
        }

        private static outstandingForm _outstandingForm;

        // SET FIELDS OF FORM BASED FROM DATA GRID
        public void setFields()
        {
            accountComboBox.SelectedValue = hevhai_system.summaryView.getForm.row_account_id;
            descriptionTB.Text = hevhai_system.summaryView.getForm.row_descript;
            amountTB.Text = hevhai_system.summaryView.getForm.row_amount;
        }

        public void clearFields()
        {
            descriptionTB.Text = "";
            amountTB.Text = "";
        }

        public void CREATE_SUMMARY()
        {
            crud.account_id = accountComboBox.SelectedValue.ToString();
            crud.descript = descriptionTB.Text;
            crud.amount = amountTB.Text;
            crud.Create_summary();
        }

        public void UPDATE_SUMMARY()
        {
            crud.outstanding_id = hevhai_system.summaryView.getForm.row_outstanding_id;
            crud.account_id = accountComboBox.SelectedValue.ToString();
            crud.descript = descriptionTB.Text;
            crud.amount = amountTB.Text;
            crud.Update_summary();
        }

        public void populateComboBox()
        {
            accCRUD.Read_account_name();
            accountComboBox.DataSource = accCRUD.dt;
            accountComboBox.DisplayMember = "name";
            accountComboBox.ValueMember = "account_id";
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

        private void SubSum_Click(object sender, EventArgs e)
        {
            if (addMode == true)
            {
                CREATE_SUMMARY();

                hevhai_system.summaryView.getForm.READ_SUMMARY();
                hevhai_system.summaryView.getForm.Show();
                this.Hide();
            }
            else
            {
                UPDATE_SUMMARY();

                hevhai_system.summaryView.getForm.READ_SUMMARY();
                hevhai_system.summaryView.getForm.Show();
                this.Hide();
            }
        }

        private void CanSum_Click(object sender, EventArgs e)
        {
            
            hevhai_system.summaryView.getForm.Show();
            this.Hide();
        }

        private void outstandingForm_FormClosed(object sender, FormClosingEventArgs e)
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
                hevhai_system.CreateA.getForm.Close();
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
                hevhai_system.homeIndex.getForm.Close();
            }
            catch
            {

            }
        }
    }
}
