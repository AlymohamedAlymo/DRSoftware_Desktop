using DRSoftware_lib;
using DRSoftware_lib.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DRSoftware_lib.DataModels.ItemsDataSet;

namespace DRSoftware_POS.Controls
{
    public partial class NewInvoice : UserControl
    {
        public NewInvoice()
        {
            InitializeComponent();
        }

        private void NewInvoice_Load(object sender, EventArgs e)
        {

            AddDGV.Rows.Add(new object[] 
            {
                DRSoftware_lib.Manager.Helper.GetURLofImageofName("")
            });


            DRSoftware_lib.DataModels.ItemsDataSetTableAdapters.ItemsTableAdapter ItemAdapter = new DRSoftware_lib.DataModels.ItemsDataSetTableAdapters.ItemsTableAdapter();
            ItemsDataSet.ItemsDataTable ItemsData = ItemAdapter.GetData();


            pictureBox5.BackgroundImage = DRSoftware_lib.Manager.Helper.BinaryToImage(ItemsData.FirstOrDefault().Imag);

            foreach (DataRow ItemRow in ItemsData)
            {
                dataGridView1.Rows.Add(
                    ItemRow.ItemArray[0].ToString(),
                    ItemRow.ItemArray[1].ToString(),
                    DRSoftware_lib.Manager.Helper.BinaryToImage((byte[])ItemRow.ItemArray[2]));

            }

        }




    }
}
