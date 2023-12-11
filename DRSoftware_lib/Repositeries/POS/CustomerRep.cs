using DRSoftware_lib.DataBase.DataSet;
using DRSoftware_lib.DataBase.DataSet.CustomerDataSetTableAdapters;
using DRSoftware_lib.DataBase.DataSet.ItemsDataSetTableAdapters;
using DRSoftware_lib.DataBase.Models;
using DRSoftware_lib.Properties;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Reflection;

namespace DRSoftware_lib.Repositeries.POS
{
    public class CustomerRep
    {

        public static List<Customer> GetAllCustomerData()
        {
            CustomerTableAdapter CustomerAdapter = new CustomerTableAdapter();
            CustomerDataSet.CustomerDataTable SourceData = CustomerAdapter.GetData();
            if (SourceData == null) { return null; }
            List<Customer> ReternData = new List<Customer>();
            foreach (CustomerDataSet.CustomerRow SourceRow in SourceData)
            {
                Customer NewRow = new Customer();
                Utilities.DataMapper.Mapping(SourceRow, NewRow, "");
                ReternData.Add(NewRow);
            }

            return ReternData;
        }



        public static CustomerGroup GetCustomerGroupsData(int GroupID)
        {
            CustomerGroupTableAdapter CustomerGroupsAdapter = new CustomerGroupTableAdapter();
            CustomerDataSet.CustomerGroupRow SourceData = CustomerGroupsAdapter.GetData()
                .FirstOrDefault(u => u.ID == GroupID);

            if (SourceData == null) { return null; }

            CustomerGroup ReternData = new CustomerGroup();
            Utilities.DataMapper.Mapping(SourceData, ReternData, "");

            return ReternData;
        }





    }
}
