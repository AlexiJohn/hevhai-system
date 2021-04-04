using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hevhai_system.summary;
using hevhai_system.account;
using MySql.Data.MySqlClient;

namespace hevhai_system
{
    public partial class summaryView : Form
    {

        // VARIABLES HERE

        private accountCRUD accCRUD = new accountCRUD();
        private summaryCRUD crud = new summaryCRUD();

        private outstandingForm outstandingForm = hevhai_system.outstandingForm.getForm;

        private string Value;

        public string row_outstanding_id { set; get; }
        public string row_account_id { set; get; }
        public string row_descript { set; get; }
        public string row_amount { set; get; }

        public summaryView()
        {
            InitializeComponent();

            // DATABASE FUNCTIONS
            accCRUD.DB();
            crud.DB();
            READ_SUMMARY();

            // FORM FUNCTIONS
            addTotal();
            ReallyCenterToScreen();
            populateComboBox();
        }

        public static summaryView getForm
        {
            get
            {
                if (_summaryView == null)
                {
                    _summaryView = new summaryView();
                }
                return _summaryView;
            }
        }

        private static summaryView _summaryView;

        private void backButton_Click(object sender, EventArgs e)
        {
            hevhai_system.homeIndex.getForm.Show();
            this.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            outstandingForm.addMode = true;
            outstandingForm.clearFields();
            hevhai_system.outstandingForm.getForm.populateComboBox();
            hevhai_system.outstandingForm.getForm.formLabel = "Add Outstanding Balance";
            hevhai_system.outstandingForm.getForm.Show();
            this.Hide();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (checkSelectRow() == true)
            {
                // SET ROW
                getDataGridRow();
                outstandingForm.setFields();
                outstandingForm.addMode = false;
                hevhai_system.outstandingForm.getForm.populateComboBox();
                hevhai_system.outstandingForm.getForm.formLabel = "Edit Balance";
                hevhai_system.outstandingForm.getForm.Show();
                this.Hide();
            }
            else
            {

            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DELETE_SUMMARY();
            READ_SUMMARY();
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

        public void DELETE_SUMMARY()
        {
            getDataGridRow();
            crud.outstanding_id = row_outstanding_id;
            crud.Delete_summary();
        }

        public void READ_SUMMARY()
        {
            dataGridView2.DataSource = null;
            crud.Read_summary();
            dataGridView2.DataSource = crud.dt;
        }

        private void getDataGridRow()
        {
            try
            {
                if (dataGridView2.SelectedRows[0].Cells[0].Value != null)
                {
                    row_outstanding_id = (dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
                    row_account_id = (dataGridView2.SelectedRows[0].Cells[1].Value.ToString());
                    row_descript = (dataGridView2.SelectedRows[0].Cells[2].Value.ToString());
                    row_amount = (dataGridView2.SelectedRows[0].Cells[3].Value.ToString());
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
                if (dataGridView2.SelectedRows[0].Cells[0].Value != null)
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

        public void addTotal()
        {
            int total = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; ++i)
            {
                total += Convert.ToInt32(dataGridView2.Rows[i].Cells[3].Value);
            }
            totalLabel.Text = "Total: PHP " + total.ToString();
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

        }

        private void accountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBox comboBox = (ComboBox)sender;
                Value = (string)comboBox.SelectedValue.ToString();

                if (Value == "")
                {
                    (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = null;
                    addTotal();
                }
                else
                {
                    (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = string.Format("account_id = '{0}'", Int32.Parse(Value));
                    getFilteredTotal();
                }
            }
            catch
            {

            }
        }

        public void getFilteredTotal()
        {
                Value = accountComboBox.SelectedValue.ToString();
                var datasource = dataGridView2.DataSource as DataTable;
                var copyDT = datasource.Copy();
                var dtFiltered = copyDT.AsEnumerable()
                                .Where(x => x.Field<Int32>("account_id") == Int32.Parse(Value));
                var filteredTotal = dtFiltered.AsEnumerable()
                                .Sum(x => x.Field<Int32>("amount"));
                totalLabel.Text = "Total: PHP " + filteredTotal;
        }

    }
}
