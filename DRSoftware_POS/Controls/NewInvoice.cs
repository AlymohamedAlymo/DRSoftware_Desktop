using ComponentFactory.Krypton.Toolkit;
using DRSkin_UI.Controls;
using DRSoftware_lib.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DRSoftware_POS.Controls
{
    public partial class NewInvoice : UserControl
    {
        public NewInvoice()
        {
            InitializeComponent();
        }


        private void FillItemsView(List<Item> itemsData)
        {
            ItemsListView.Items.Clear();
            foreach (Item Row in itemsData)
            {
                Image Icon = null;
                if (Row.Image != null)
                {
                    Icon = DRSoftware_lib.Manager.ImageHelper.ConvertBinaryToImage(Row.Image);
                }
                ItemsImageList.Images.Add(Icon);
                ItemsListView.LargeImageList = ItemsImageList;
                ItemsListView.SmallImageList = ItemsImageList;

                ItemGroup ItemGroupData = new ItemGroup();
                string GroupName = DRSoftware_lib.Repositeries.POS.ItemsRep.GetItemGroupsData(Row.GroupID).GroupName;

                ListViewGroup NewlistViewGroup = new ListViewGroup(GroupName, HorizontalAlignment.Left);
                ListViewGroup Group = ItemsListView.Groups.Cast<ListViewGroup>()
                    .FirstOrDefault(g => g.Header == GroupName.ToString());

                if (Group == null)
                {
                    ItemsListView.Groups.Add(NewlistViewGroup);
                    Group = NewlistViewGroup;
                }

                ListViewItem item = new ListViewItem()
                {
                    Text = Row.ItemName,
                    ImageIndex = ItemsImageList.Images.Count,
                    Group = Group
                };

                item.SubItems.AddRange(new string[] { Row.FileDate.ToString(), Row.Unit.ToString() });
                _ = ItemsListView.Items.Add(item);

            }

        }


        private void FillCustomersView(List<Customer> CustomersData)
        {
            CustomersListView.Items.Clear();
            foreach (Customer Row in CustomersData)
            {
                Image Icon = null;
                if (Row.Image != null)
                {
                    Icon = DRSoftware_lib.Manager.ImageHelper.ConvertBinaryToImage(Row.Image);

                }
                CustomersImageList.Images.Add(Icon);
                CustomersListView.LargeImageList = ItemsImageList;
                CustomersListView.SmallImageList = ItemsImageList;

                CustomerGroup CustomerGroupData = new CustomerGroup();
                string GroupName = DRSoftware_lib.Repositeries.POS.CustomerRep.GetCustomerGroupsData(Row.GroupID).GroupName;

                ListViewGroup NewlistViewGroup = new ListViewGroup(GroupName, HorizontalAlignment.Left);
                ListViewGroup Group = ItemsListView.Groups.Cast<ListViewGroup>()
                    .FirstOrDefault(g => g.Header == GroupName.ToString());

                if (Group == null)
                {
                    CustomersListView.Groups.Add(NewlistViewGroup);
                    Group = NewlistViewGroup;
                }

                ListViewItem Customer = new ListViewItem()
                {
                    Text = Row.CustomerName,
                    ImageIndex = CustomersImageList.Images.Count,
                    Group = Group
                };

                Customer.SubItems.AddRange(new string[] { Row.Phone.ToString(), Row.Address.ToString() });
                _ = CustomersListView.Items.Add(Customer);

            }

        }



        private void NewInvoice_Load(object sender, EventArgs e)
        {

            ///Generate Add Row
            AddDGV.Rows.Add(new object[] 
            {
                DRSoftware_lib.Manager.ImageHelper.GetURLofImageofName("")
            });


            ///Fill Customer ListView
            List<Customer> CustomersData = DRSoftware_lib.Repositeries.POS.CustomerRep.GetAllCustomerData();
            FillCustomersView(CustomersData.Skip(0).Take(50).ToList());

            ///Fill Items ListView
            List<Item> itemsData = DRSoftware_lib.Repositeries.POS.ItemsRep.GetAllItemsData();
            FillItemsView(itemsData.Skip(0).Take(50).ToList());


        }

        private void DetailsRadioItemsListView_CheckedChanged(object sender, EventArgs e)
        {

            //KryptonRadioButton BTN = sender as KryptonRadioButton;
            //switch (BTN.Name)
            //{
            //    case "DetailsRadioItemsListView":
            //        if (DetailsRadioItemsListView.Checked) 
            //        {
            //            ItemsListView.View = View.Details;
            //            ItemsListView.CheckBoxes = true;
            //            ItemsListView.Refresh();
            //        }
            //        break;
            //    case "LargeIconRadioItemsListView":
            //        if (LargeIconRadioItemsListView.Checked) 
            //        {
            //            ItemsListView.View = View.LargeIcon;
            //            ItemsListView.CheckBoxes = true;
            //            ItemsListView.Refresh(); 
            //        }
            //        break;
            //    case "SmallIconRadioItemsListView":
            //        if (SmallIconRadioItemsListView.Checked)
            //        {
            //            ItemsListView.View = View.SmallIcon;
            //            ItemsListView.CheckBoxes = true;
            //            ItemsListView.Refresh();
            //        }
            //        break;
            //    case "TitleRadioItemsListView":
            //        if (TitleRadioItemsListView.Checked) 
            //        { 
            //            ItemsListView.CheckBoxes = false;
            //            ItemsListView.View = View.Tile;
            //            ItemsListView.Refresh();
            //        }
            //        break;
            //    case "ListRadioItemsListView":
            //        if (ListRadioItemsListView.Checked) 
            //        { 
            //            ItemsListView.View = View.List;
            //            ItemsListView.CheckBoxes = true;
            //            ItemsListView.Refresh();
            //        }
            //        break;
            //    default:
            //        break;
            //}

        }

        private void ItemsListView_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (ItemsListView.CheckedItems == null)
            {
                ItemPanel.ValidationButtonEnable = true;
            }
        }

        private void kryptonHeaderGroup3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonHeaderGroup3_Click(object sender, EventArgs e)
        {

            var SecendHeaderLocation = new Point(SearchItemsPanel.Panel.Bounds.X, SearchItemsPanel.Panel.Bounds.Y);
            
            var ttt = SearchItemsPanel.Location.X;
            if (MousePosition.X > ttt) 
            {
                MessageBox.Show("in");
            }

            int OldHeight = 0;
            if (SearchItemsPanel.Collapsed) 
            {
                SearchItemsPanel.Collapsed = false;
                SearchItemsPanel.Height = 500;

            }
            else if (!SearchItemsPanel.Collapsed)
            {
                SearchItemsPanel.Collapsed = true;
                OldHeight = SearchItemsPanel.Panel.Height;
                SearchItemsPanel.Height = 53; 
            };

        }

        private void FiltrBTNItemsListView_Click(object sender, EventArgs e)
        {
            if (SearchItemsPanel.Visible) { SearchItemsPanel.Visible = false; }
            else if (!SearchItemsPanel.Visible) { SearchItemsPanel.Visible = true; }

        }

        private void FiltrBTNItemsListView_MouseHover(object sender, EventArgs e)
        {
           var yyy = sender.GetType().GetProperty("Name");


            ToolTipBar SnackBarMessage = new ToolTipBar("بحث في سجلات الاصناف", "تم", false);
            SnackBarMessage.Show(this);

        }

        private void SortBTNItemsListView_MouseHover(object sender, EventArgs e)
        {
            ToolTipBar SnackBarMessage = new ToolTipBar("ترتيب النتائج", "تم", false);
            SnackBarMessage.Show(this);

        }
    }
}
