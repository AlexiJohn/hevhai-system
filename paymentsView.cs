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
    public partial class paymentsView : Form
    {
        accountCRUD accCRUD = new accountCRUD();
        paymentCRUD crud = new paymentCRUD();

        //VARIABLES HERE

        //VARIABLES FROM SELECTED ROW
        public string row_or_no { set; get; }
        public string row_account_id { set; get; }
        public string row_date_of_payment { set; get; }
        public string row_amount { set; get; }
        public string row_mode_of_payment { set; get; }
        public string row_payment_for { set; get; }
        public string row_description { set; get; }

        public paymentsView()
        {
            InitializeComponent();
            accCRUD.DB();
            crud.DB();
            ReallyCenterToScreen();
            READ_PAYMENT();
            Shown += paymentsView_Shown;
        }

        private static paymentsView _paymentsView;

        public static paymentsView getForm
        {
            get
            {
                if (_paymentsView == null)
                {
                    _paymentsView = new paymentsView();
                }
                return _paymentsView;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            hevhai_system.homeIndex.getForm.Show();
            this.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            hevhai_system.CreateP.getForm.clearFields();
            hevhai_system.CreateP.getForm.populateComboBox();
            hevhai_system.CreateP.getForm.addMode = true;
            hevhai_system.CreateP.getForm.Show();
            this.Hide();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (checkSelectRow() == true)
            {
                getDataGridRow();
                hevhai_system.CreateP.getForm.populateComboBox();
                hevhai_system.CreateP.getForm.setFields();
                hevhai_system.CreateP.getForm.addMode = false;
                hevhai_system.CreateP.getForm.Show();
                this.Hide();
            }
        }

        // FUNCTION TO READ DATA FROM MYSQL AND PUT IT IN DATA GRID
        public void READ_PAYMENT()
        {
            dataGridView1.DataSource = null;
            crud.Read_payment();
            dataGridView1.DataSource = crud.dt;
        }

        public void DELETE_PAYMENT()
        {
            getDataGridRow();
            crud.or_no = row_or_no;
            crud.Delete_payment();
        }

        // CENTER TO SCREEN
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

        private void getDataGridRow()
        {
            try
            {
                if (dataGridView1.SelectedRows[0].Cells[0].Value != null)
                {
                    row_or_no = (dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    row_account_id = (dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                    row_date_of_payment = (dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                    row_amount = (dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                    row_mode_of_payment = (dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                    row_payment_for = (dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
                    row_description = (dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Please select a row!");
            }
        }

        private Boolean checkSelectRow()
        {
            try
            {
                if (dataGridView1.SelectedRows[0].Cells[0].Value != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Please select a row!");
                return false;
            }

        }

        public void populateComboBox()
        {
            accCRUD.Read_account_name();
            DataRow new_row = accCRUD.dt.NewRow();
            new_row["account_id"] = DBNull.Value;
            new_row["name"] = "ALL ACCOUNTS";
            accCRUD.dt.Rows.InsertAt(new_row, 0);
            accountComboBox.DataSource = accCRUD.dt;
            accountComboBox.DisplayMember = "name";
            accountComboBox.ValueMember = "account_id";
        }



        private string accountValue;

        private void accountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBox comboBox = (ComboBox)sender;
                accountValue = (string)comboBox.SelectedValue.ToString();

                if (accountValue == "") {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = null;
                }
                else
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("account_id = '{0}'", Int32.Parse(accountValue));
                }
                
            }
            catch
            {

            }
        }

        private void paymentsView_Shown(object sender, EventArgs e)
        {
            populateComboBox();
        }
    }
}
