using ComponentFactory.Krypton.Toolkit;
using DRSkin_UI.Forms;
using DRSoftware_POS.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DRSoftware_lib;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

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


            //var tt = Setting.GetURLofImageofName("علي محمد");

            //pictureBox5.ImageLocation = tt;
            ////    
            //pictureBox5.Load();







        }



        private void buttonDRSkin1_Click(object sender, EventArgs e)
        {
            kryptonHeaderGroup1.Visible = true;

            NewInvoice newBill = new NewInvoice();
            kryptonHeaderGroup1.Panel.Controls.Add(newBill);
            //newBill.Size = kryptonHeaderGroup1.Size;
            //newBill.Location = new Point(0,0);
            newBill.Dock = DockStyle.Fill;

            //panel1.Controls.Add(newBill);


            //newBill.Dock = DockStyle.Fill;

            //newBill.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;



        }

        //System.Drawing.Image img = null;
        //byte[] data = null;
        private void button1_Click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();
            //pictureBox5.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);

            //img = System.Drawing.Image.FromFile(openFileDialog1.FileName);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //using (MemoryStream stream = new MemoryStream())
            //{
            //    img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            //    byte[] ImageinArray = stream.ToArray();
            //    textBox1.Text = ImageinArray.ToString();
            //    data = ImageinArray;
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ////DRSoftware_lib.DataModels.Item item = new DRSoftware_lib.DataModels.Item();
            ////item.



            //using (MemoryStream stream = new MemoryStream(data))
            //{
            //    System.Drawing.Image image = System.Drawing.Image.FromStream(stream);
            //    pictureBox1.Image = image;

            //}

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //DRSoftware_lib.DataModels.Item item = new DRSoftware_lib.DataModels.Item();
            //item.Imag = data;


            //DRSoftware_lib.DataModels.ItemsDataSetTableAdapters.ItemsTableAdapter ItemAdapter = new DRSoftware_lib.DataModels.ItemsDataSetTableAdapters.ItemsTableAdapter();
            //ItemAdapter.Insert(20230712, data, "testnew", 3, 1, 1, null, "", false);
            ////ItemsDataSet.ItemsDataTable ItemsData = ItemAdapter.Insert(20230712,data,"testnew",3,1,1,null,"",false);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //DRSoftware_lib.DataModels.ItemsDataSetTableAdapters.ItemsTableAdapter ItemAdapter = new DRSoftware_lib.DataModels.ItemsDataSetTableAdapters.ItemsTableAdapter();
            //ItemsDataSet.ItemsDataTable ItemsData = ItemAdapter.GetData();

            //var data2 = ItemsData.FirstOrDefault(u => u.IDItem == 106).Imag;

            //using (MemoryStream stream = new MemoryStream(data2))
            //{
            //    System.Drawing.Image image = System.Drawing.Image.FromStream(stream);
            //    pictureBox1.Image = image;

            //}


        }
    }
}
