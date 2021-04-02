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
            // SET ROW
            getDataGridRow();
            account.setFields();
            account.addMode = false;
            hevhai_system.CreateA.getForm.Show();
            this.Hide();
           
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
                MessageBox.Show("Don't Click the header!");
            }
        }

        private void upload_button_Click(object sender, EventArgs e)
        {

            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            openfiledialog1.ShowDialog();
            openfiledialog1.Filter = "Text files | *.csv";
            txtfilepath = openfiledialog1.FileName;

            crud.Bulk_create_account();
            MessageBox.Show("File Uploaded");
            READ_ACCOUNT();
        }
    }
}
