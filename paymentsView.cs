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

        private string Value;

        public paymentsView()
        {
            InitializeComponent();

            // DATABASE FUNCTIONS
            accCRUD.DB();
            crud.DB();
            READ_PAYMENT();

            //FORM FUNCTIONS
            ReallyCenterToScreen();
            addTotal();
            hideAllFilters();
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
            hevhai_system.CreateP.getForm.formLabel = "Create New Payment";
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
                hevhai_system.CreateP.getForm.formLabel = "Edit Payment";
                hevhai_system.CreateP.getForm.Show();
                this.Hide();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DELETE_PAYMENT();
            READ_PAYMENT();
            addTotal();
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
            // FOR ACCOUNT COMBO BOX
            accCRUD.Read_account_name();
            DataRow new_row = accCRUD.dt.NewRow();
            new_row["account_id"] = DBNull.Value;
            new_row["name"] = "ALL ACCOUNTS";
            accCRUD.dt.Rows.InsertAt(new_row, 0);
            accountComboBox.DataSource = accCRUD.dt;
            accountComboBox.DisplayMember = "name";
            accountComboBox.ValueMember = "account_id";

            // FOR MODE OF PAYMENT COMBOBOX

            MoPComboBox.Items.Clear();
            MoPComboBox.Items.Add("ALL");
            MoPComboBox.Items.Add("Cash");
            MoPComboBox.Items.Add("Gcash");
            MoPComboBox.Items.Add("Check");

            // FOR FILTER BY COMBOBOX
            filterByCB.Items.Clear();
            filterByCB.Items.Add("NONE");
            filterByCB.Items.Add("Accounts");
            filterByCB.Items.Add("Mode of Payment");
            filterByCB.Items.Add("OR#");

            // Choices: "Accounts", "Mode of Payment", "OR#"

        }

        private void paymentsView_Shown(object sender, EventArgs e)
        {
            populateComboBox();
            addTotal();
        }

        public void addTotal()
        {
            int total = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                total += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }
            totalLabel.Text = "Total: PHP " + total.ToString();
        }

        public void getFilteredTotal()
        {
            if ((string)filterByCB.SelectedItem == "NONE")
            {
                addTotal();
            }
            else if ((string)filterByCB.SelectedItem == "Accounts")
            {
                Value = accountComboBox.SelectedValue.ToString();
                var datasource = dataGridView1.DataSource as DataTable;
                var copyDT = datasource.Copy();
                
                var dtFiltered = copyDT.AsEnumerable()
                                .Where(x => x.Field<Int32>("account_id") == Int32.Parse(Value))
                                .CopyToDataTable();
                var filteredTotal = dtFiltered.AsEnumerable()
                                .Sum(x => x.Field<Int32>("amount"));
                totalLabel.Text = "Total: PHP " + filteredTotal;
                

            }
            else if ((string)filterByCB.SelectedItem == "Mode of Payment")
            {
                Value = MoPComboBox.SelectedItem.ToString();
                var datasource = dataGridView1.DataSource as DataTable;
                var copyDT = datasource.Copy();
                var dtFiltered = copyDT.AsEnumerable()
                                .Where(x => x.Field<String>("mode_of_payment") == Value)
                                .CopyToDataTable();
                var filteredTotal = dtFiltered.AsEnumerable()
                                .Sum(x => x.Field<Int32>("amount"));
                totalLabel.Text = "Total: PHP " + filteredTotal;
            }
            else if ((string)filterByCB.SelectedItem == "OR#")
            {
                Int32 firstFilter = Int32.Parse(fromORTB.Text);
                Int32 secondFilter = Int32.Parse(toORTB.Text);
                
                var datasource = dataGridView1.DataSource as DataTable;
                var copyDT = datasource.Copy();
                var dtFiltered = copyDT.AsEnumerable()
                                .Where(x => x.Field<Int32>("or_no") >= firstFilter & x.Field<Int32>("or_no") <= secondFilter)
                                .CopyToDataTable();
                var filteredTotal = dtFiltered.AsEnumerable()
                                .Sum(x => x.Field<Int32>("amount"));
                totalLabel.Text = "Total: PHP " + filteredTotal;
            }
        }

        private void filterByCB_SelectedIndexChanged(object sender, EventArgs e)
        {

            if ((string)filterByCB.SelectedItem == "Accounts")
            {
                accountLabel.Visible = true;
                accountComboBox.Visible = true;

                MoPLabel.Visible = false;
                MoPComboBox.Visible = false;

                fromORLabel.Visible = false;
                fromORTB.Visible = false;
                toORLabel.Visible = false;
                toORTB.Visible = false;
            }
            else if ((string)filterByCB.SelectedItem == "Mode of Payment")
            {
                accountLabel.Visible = false;
                accountComboBox.Visible = false;

                MoPLabel.Visible = true;
                MoPComboBox.Visible = true;

                fromORLabel.Visible = false;
                fromORTB.Visible = false;
                toORLabel.Visible = false;
                toORTB.Visible = false;
            }
            else if ((string)filterByCB.SelectedItem == "OR#")
            {
                accountLabel.Visible = false;
                accountComboBox.Visible = false;

                MoPLabel.Visible = false;
                MoPComboBox.Visible = false;

                fromORLabel.Visible = true;
                fromORTB.Visible = true;
                toORLabel.Visible = true;
                toORTB.Visible = true;
            }
            else if ((string)filterByCB.SelectedItem == "NONE")
            {
                accountLabel.Visible = false;
                accountComboBox.Visible = false;

                MoPLabel.Visible = false;
                MoPComboBox.Visible = false;

                fromORLabel.Visible = false;
                fromORTB.Visible = false;
                toORLabel.Visible = false;
                toORTB.Visible = false;

                try
                {

                    ComboBox comboBox = (ComboBox)sender;
                    Value = (string)comboBox.SelectedItem.ToString();
                    
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "";

                    addTotal();
                }
                catch
                {

                }
            }
        }

        private void hideAllFilters()
        {
            accountLabel.Visible = false;
            accountComboBox.Visible = false;

            MoPLabel.Visible = false;
            MoPComboBox.Visible = false;

            fromORLabel.Visible = false;
            fromORTB.Visible = false;
            toORLabel.Visible = false;
            toORTB.Visible = false;
        }

        private void accountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if ((string)filterByCB.SelectedItem == "Accounts")
                {
                    ComboBox comboBox = (ComboBox)sender;
                    Value = (string)comboBox.SelectedValue.ToString();

                    if (Value == "")
                    {
                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = null;
                        addTotal();
                    }
                    else
                    {
                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("account_id = '{0}'", Int32.Parse(Value));
                        getFilteredTotal();
                    }
                }
            }
            catch
            {

            }
        }

        private void MoPComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if ((string)filterByCB.SelectedItem == "Mode of Payment")
                {
                    ComboBox comboBox = (ComboBox)sender;
                    Value = (string)comboBox.SelectedItem.ToString();

                    if (Value == "ALL")
                    {
                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = null;
                        addTotal();
                    }
                    else
                    {
                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("mode_of_payment = '{0}'", Value);
                        getFilteredTotal();
                    }
                    
                }
            }
            catch
            {

            }
        }

        private void fromORTB_TextChanged(object sender, EventArgs e)
        {
            ORFilter();
        }

        private void toORTB_TextChanged(object sender, EventArgs e)
        {
            ORFilter();
        }

        private void ORFilter()
        {
            try
            {
                if ((string)filterByCB.SelectedItem == "OR#")
                {

                    string firstFilter = fromORTB.Text;
                    string secondFilter = toORTB.Text;

                    if ((firstFilter == "") | (secondFilter == ""))
                    {
                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = null;
                        addTotal();
                    }
                    else
                    {
                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("or_no >= {0} AND or_no <= {1}", firstFilter, secondFilter);
                        getFilteredTotal();
                    }

                    
                }
            }
            catch
            {

            }
        }

        
    }
}
