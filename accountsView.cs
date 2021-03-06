using System;
using System.IO;
using System.Diagnostics;
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

using ClosedXML.Excel;

namespace hevhai_system
{
    public partial class accountsView : Form
    {

        accountCRUD crud = new accountCRUD();


        //VARIABLES HERE

        //VARIABLES FROM SELECTED ROW
        public string row_last_name { set; get; }
        public string row_spouse_fname_1 { set; get; }
        public string row_spouse_fname_2 { set; get; }
        public string row_address { set; get; }
        public string row_fb_account { set; get; }
        public string row_email { set; get; }
        public string row_contact { set; get; }
        public string row_moved_in_date { set; get; }
        public string row_account_id { set; get; }

        // VARIABLES FOR BULK UPLOAD
        public string txtfilepath { set; get; }

        // VARIABLES FOR FORM WINDOWS
        private CreateA account = hevhai_system.CreateA.getForm;
        private static accountsView _aView;

        //VARIABLES END HERE

        public accountsView()
        {
            InitializeComponent();
            Shown += accountsView_Shown;
            ReallyCenterToScreen();
            crud.DB();
        }

        

        public static accountsView getForm
        {
            get
            {
                if (_aView == null)
                {
                    _aView = new accountsView();
                }
                return _aView;
            }
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            hevhai_system.homeIndex.getForm.Show();
            this.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            account.addMode = true;
            account.clearFields();
            account.formLabel = "Create New Account";
            hevhai_system.CreateA.getForm.Show();
            this.Hide();
        }

        // DELETE BUTTON

        private void button2_Click(object sender, EventArgs e)
        {
            DELETE_ACCOUNT();
            READ_ACCOUNT();
        }

        // EDIT BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkSelectRow() == true)
            {
                // SET ROW
                getDataGridRow();
                account.setFields();
                account.addMode = false;
                account.formLabel = "Edit Account";
                hevhai_system.CreateA.getForm.Show();
                this.Hide();
            }
            else
            {

            }
           
        }

        // FUNCTION TO READ DATA FROM MYSQL AND PUT IT IN DATA GRID
        public void READ_ACCOUNT()
        {
            dataGridView1.DataSource = null;
            crud.Read_account();
            dataGridView1.DataSource = crud.dt;
        }

        public void DELETE_ACCOUNT()
        {
            getDataGridRow();
            crud.account_id = row_account_id;
            crud.Delete_account();
        }

        // RELOAD DATA WHEN SCREEN IS SHOWN
        private void accountsView_Shown(object sender, EventArgs e)
        {
            READ_ACCOUNT();
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
                    row_account_id = (dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    row_last_name = (dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                    row_spouse_fname_1 = (dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                    row_spouse_fname_2 = (dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                    row_address = (dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                    row_fb_account = (dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
                    row_email = (dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
                    row_contact = (dataGridView1.SelectedRows[0].Cells[7].Value.ToString());
                    row_moved_in_date = (dataGridView1.SelectedRows[0].Cells[8].Value.ToString());
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
        private void upload_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Excel File (.csv)|*.csv|Excel Files(.xls)|*.xls|Excel Files(.xlsx)| *.xlsx |Excel Files(*.xlsm) |*.xlsm";
            dialog.ShowDialog();

            txtfilepath = dialog.FileName.Replace(@"\", "/");

            MessageBox.Show("Imported Data into Database");

            crud.Import_account();
            READ_ACCOUNT();
        }


        //EXPORT BUTTON
        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataTable copy = (dataGridView1.DataSource as DataTable).Copy();
            string filesFolder = AppDomain.CurrentDomain.BaseDirectory + "files\\";
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(copy, "Accounts");
                wb.Worksheet(1).Columns().AdjustToContents();
                wb.SaveAs(filesFolder + "AccountsExport.xlsx");
                if (File.Exists(filesFolder + "AccountsExport.xlsx"))
                {
                    Process.Start("explorer.exe", filesFolder);
                }
                MessageBox.Show("Export successful! File at "+ filesFolder + "AccountsExport.xlsx");
            }
        }

        private void accountsView_FormClosed(object sender, FormClosingEventArgs e)
        {
            try
            {
                hevhai_system.homeIndex.getForm.Close();
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
                hevhai_system.outstandingForm.getForm.Close();
            }
            catch
            {

            }
        }
    }
}
