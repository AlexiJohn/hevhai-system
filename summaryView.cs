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
using MySql.Data.MySqlClient;

namespace hevhai_system
{
    public partial class summaryView : Form
    {

        // VARIABLES HERE

        private summaryCRUD crud = new summaryCRUD();

        private outstandingForm outstandingForm = hevhai_system.outstandingForm.getForm;

        public string row_outstanding_id { set; get; }
        public string row_account_id { set; get; }
        public string row_descript { set; get; }
        public string row_amount { set; get; }
         


        public summaryView()
        {
            InitializeComponent();
            ReallyCenterToScreen();
            crud.DB();
            READ_SUMMARY();
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
    }
}
