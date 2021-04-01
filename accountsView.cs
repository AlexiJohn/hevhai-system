using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hevhai_system
{
    public partial class accountsView : Form
    {
        public accountsView()
        {
            InitializeComponent();
        }

        private CreateA account = hevhai_system.CreateA.getForm;
        public static DataGridViewRow selectedRow;

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

        private static accountsView _aView;

        //GET SET STATEMENTS HERE
        public DataGridViewRow datagridrow
        {
            get
            {
                return selectedRow;
            }
        }


        //GET SET STATEMENTS END HERE

        private void backButton_Click(object sender, EventArgs e)
        {
            hevhai_system.homeIndex.getForm.Show();
            this.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            hevhai_system.CreateA.getForm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*foreach (string acc in AccList)
            {
                dataGridView1.Rows.Add(acc.Name);
            }*/
        }
        

        // ADD NEW ROW
        public void addRowDatagrid()
        {
                CreateA a = new CreateA();
                List<string> Alist = a.getAccount;
                dataGridView1.Rows.Add(
                    Alist[0],
                    Alist[1],
                    Alist[2], 
                    Alist[3],
                    Alist[4],
                    Alist[5]
                    );

        }

        // DELETE BUTTON

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*dataGridView1.SelectedRows[0]*/
            selectedRow = dataGridView1.SelectedRows[0];
            hevhai_system.CreateA.getForm.setFields();
            hevhai_system.CreateA.getForm.checkEdit();
            hevhai_system.CreateA.getForm.Show();
        }
    }
}
