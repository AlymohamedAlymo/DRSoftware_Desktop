using DRSoftware_lib.DataBase;
using DRSoftware_lib.DataBase.DataSet;
using DRSoftware_lib.DataBase.DataSet.CustomerDataSetTableAdapters;
using DRSoftware_lib.DataBase.DataSet.ItemsDataSetTableAdapters;
using DRSoftware_lib.DataBase.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;

namespace DRSoftware_lib.Repositeries.POS
{
    public class ItemsRep
    {
        /// <summary>
        /// Get All Items Data
        /// </summary>
        /// <returns>List</returns>
        public static List<Item> GetAllItemsData()
        {
            ItemsTableAdapter ItemAdapter = new ItemsTableAdapter();
            ItemsDataSet.ItemsDataTable SourceData = ItemAdapter.GetData();
            if (SourceData == null) { return null; }
            List<Item> ReternData = new List<Item>();
            foreach (ItemsDataSet.ItemsRow SourceRow in SourceData)
            {
                Item NewRow = new Item();
                Utilities.DataMapper.Mapping(SourceRow, NewRow, "");
                ReternData.Add(NewRow);
            }

            return ReternData;
        }



        /// <summary>
        /// Get Data of ItemGroup Search By ID
        /// </summary>
        /// <param name="GroupID"></param>
        /// <returns>Row</returns>
        public static ItemGroup GetItemGroupsData(int GroupID)
        {

            ItemGroupTableAdapter ItemGroupsAdapter = new ItemGroupTableAdapter();
            ItemsDataSet.ItemGroupRow SourceData = ItemGroupsAdapter.GetData()
                .FirstOrDefault(u => u.ID == GroupID);

            if (SourceData == null) { return null; }

            ItemGroup ReternData = new ItemGroup();
            Utilities.DataMapper.Mapping(SourceData, ReternData, "");

            return ReternData;

        }





    }
}
