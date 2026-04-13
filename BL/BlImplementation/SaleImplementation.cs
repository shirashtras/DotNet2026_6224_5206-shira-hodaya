using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Tools;


namespace BlImplementation
{
    internal class SaleImplementation
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;

        /// <summary>
        /// פונקציה ליצירת מבצע
        /// </summary>
        /// <param name="item">מקבל ישות מבצע</param>
        /// <returns>מחזיר מזהה מבצע</returns>
        public int Create(BO.Sale item)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
            , MethodBase.GetCurrentMethod().Name
            , "create sale");
            _dal.Sale.Create(item);
            return item.id;
        }
       

    }
}
