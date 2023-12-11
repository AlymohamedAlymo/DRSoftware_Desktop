using DRSoftware_lib.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DRSoftware_lib.Utilities
{
    internal class DataMapper
    {

        /// <summary>
        /// Get Data from Source Object and Set into Target Object //SAME SOURCE OBJECT//
        /// </summary>
        /// <typeparam name="SourceObject">Source Object Without Data</typeparam>
        /// <typeparam name="TargetObject">Target Object Without Data</typeparam>
        /// <param name="DataSourceObject">Source Object With Data</param>
        /// <param name="DesitnationObject">Target Object With Data</param>
        /// <param name="Excluded">Excluded Coulmns</param>
        public static void Mapping<SourceObject, TargetObject>(SourceObject DataSourceObject, TargetObject DesitnationObject, params string[] Excluded)
        {
            foreach (PropertyInfo Info in DesitnationObject.GetType().GetProperties().ToList())
            {
                try
                {
                    if (!Excluded.Contains(Info.Name))
                    {
                        if (DataSourceObject.GetType().GetProperties().Any((PropertyInfo Object) => Object.Name == Info.Name))
                        {
                            PropertyInfo SourceData = DataSourceObject.GetType().GetProperties().FirstOrDefault(u => u.Name == Info.Name);
                            object SourceDataValue = SourceData.GetValue(DataSourceObject);
                            Info.SetValue(DesitnationObject, SourceDataValue);
                        }
                    }

                }
                catch { continue; }
            }
        }





    }
}
