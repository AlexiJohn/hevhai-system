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
    public partial class homeIndex : Form
    {
        public homeIndex()
        {
            InitializeComponent();
            ReallyCenterToScreen();
        }

        public accountsView accountsView = hevhai_system.accountsView.getForm;
        public paymentsView paymentsView = hevhai_system.paymentsView.getForm;
        public summaryView summaryView = hevhai_system.summaryView.getForm;

        public CreateA CreateA = hevhai_system.CreateA.getForm;
        public CreateP CreateP = hevhai_system.CreateP.getForm;
        public outstandingForm outstandingForm = hevhai_system.outstandingForm.getForm;
        

        public static homeIndex getForm
        {
            get
            {
                if (_homeIndex == null)
                {
                    _homeIndex = new homeIndex();
                }
                return _homeIndex;
            }
        }

        private static homeIndex _homeIndex;

        private void accountsButton_Click(object sender, EventArgs e)
        {
            hevhai_system.accountsView.getForm.Show();
            this.Hide();
        }

        private void paymentsButton_Click(object sender, EventArgs e)
        {
            hevhai_system.paymentsView.getForm.populateComboBox();
            hevhai_system.paymentsView.getForm.Show();
            this.Hide();
        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            hevhai_system.summaryView.getForm.populateComboBox();
            hevhai_system.summaryView.getForm.Show();
            this.Hide();
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

        private void homeIndex_FormClosed(object sender, FormClosingEventArgs e)
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
                hevhai_system.outstandingForm.getForm.Close();
            }
            catch
            {

            }    
                
        }
    }
}
