using ComponentFactory.Krypton.Toolkit;
using DRSkin_UI.Forms;
using DRSoftware_POS.Controls;
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
    public partial class HomeForm : FormDRSkin
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
        }

        private void buttonDRSkin1_Click(object sender, EventArgs e)
        {
            kryptonHeaderGroup1.Visible = true;

            NewBill newBill = new NewBill();
            kryptonHeaderGroup1.Panel.Controls.Add(newBill);
            newBill.Dock = DockStyle.Fill;

        }
    }
}
