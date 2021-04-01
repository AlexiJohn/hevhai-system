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
    public partial class AddConfirm : Form
    {
        public AddConfirm()
        {
            InitializeComponent();
        }
       
        private void AddConButton_Click(object sender, EventArgs e)
        {
          this.Close();
        }
    }
}
