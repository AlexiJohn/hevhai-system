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

        List <string> AccList = new List <string>();
         

    private void backButton_Click(object sender, EventArgs e)
        {
            Form home = new homeIndex();
            this.Hide();
            home.ShowDialog();
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Form addA = new CreateA();
            this.Hide();
            addA.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (string acc in AccList)
            {
                dataGridView1.Rows.Add(acc.Name);
            }
        }
    }
}
