using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DRSoftware_POS.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonDRSkin1_Click(object sender, EventArgs e)
        {
            Forms.HomeForm homeForm = new Forms.HomeForm();
            homeForm.Show();
            Hide();
            GC.Collect();
        }
    }
}
