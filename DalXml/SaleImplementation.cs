using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using Tools;

namespace Dal
{
    internal class SaleImplementation : ISale
    {
        const string ID = "id";
        const string IDSALE = "idSale";
        const string COUNT = "count";
        const string PRICE = "price";
        const string ISSALETOALL = "isSaleToAll";
        const string STARTDATE = "startDate";
        const string ENDDATE = "endDate";

        const string SALE = "Sale";
        
        const string path = @"..\xml\sales.xml";
        XElement sales;
        private XElement LoadXElement()
        {
            XElement saleXml = XElement.Load(path);
            return saleXml;
        }

        /// <summary>
        /// פונקציה ליצירת מבצע
        /// </summary>
        /// <param name="item">מקבל ישות מבצע</param>
        /// <returns>מחזיר מזהה מבצע</returns>
        public int Create(Sale item)
        {
            sales = LoadXElement();
            int newId = Config.saleSaleId();
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
            , MethodBase.GetCurrentMethod().Name
            , "create sale");
            sales.Add(item);
            return item.id;
        }
        /// <summary>
        /// פונקציה לקריאת מבצע על פי מזהה מבצע
        /// </summary>
        /// <param name="id">מקבל מזהה מבצע</param>
        /// <returns>מחזיר את המבצע המבוקש</returns>

        public Sale? Read(int id)
        {
            sales = LoadList();
            Sale sale = sales.FirstOrDefault(s => s.id == id);
            if (sale == null)
            {
                LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
                 , MethodBase.GetCurrentMethod().Name
                 , "cant Read sale because saleId not exists");
                throw new DalIdNotExists("saleId not exists");
            }
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
              , MethodBase.GetCurrentMethod().Name
              , "Read sale");
            return sale;
        }
        /// <summary>
        /// פונקציה למציאת אובייקט על פי תנאי
        /// וכאשר לא נמצא אובייקט תזרק שגיאה
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns> 
        /// <exception cref="DalFilterNotExists"></exception>
        public Sale? Read(Func<Sale, bool> filter)
        {
            sales=LoadXElement();
            var q = (from s in sales.Elements(SALE)
                     select new Sale()
                     {
                         id = (int)s.Element(ID),
                         idSale = (int)s.Element(PRODUCTID),
                         price = (double)s.Element(SALEPRICE),
                         count = (int)s.Element(QUANTITYREQUIER),
                         isSaleToAll = (bool)s.Element(ISSALETOCUSTOMER),
                         startDate = (DateTime)s.Element(STARTSALE),
                         endDate = (DateTime)s.Element(ENDSALE)
                     }).ToList();
            if (q == null)
            {
                LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
                , MethodBase.GetCurrentMethod().Name
                , "cant Read sale with this filter ");
                throw new DalFilterNotExists("filter not found");
            }

            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
              , MethodBase.GetCurrentMethod().Name
              , "Read sale");
            return q;
        }
        /// <summary>
        /// פונקציה לקריאת כל פרטי המבצעים
        /// </summary>
        /// <returns>מחזיר העתק של רשימת המבצעים</returns>
        public List<Sale?> ReadAll(Func<Sale, bool>? filter)
        {
            if (filter == null)
                return new List<Sale?>(sales);
            var q = sales.Where(s => filter(s!));
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
                , MethodBase.GetCurrentMethod().Name
                , "ReadAll sale");
            return q.ToList();
        }

        /// <summary>
        /// פונקציה לעדכון מבצע על פי מזהה
        /// </summary>
        /// <param name="item">מקבל ישות מבצע</param>
        public void Update(Sale item)
        {
            Delete(item.id);
            sales!.Add(item);
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
            , MethodBase.GetCurrentMethod().Name
            , "Update sale ");

        }
        /// <summary>
        /// פוקנצייה למחיקת מבצע
        /// </summary>
        /// <param name="id">מקבל מזהה מבצע למחיקה</param>
        /// <exception cref="Exception">זורק שגיאה באם המזהה מבצע לא קיים</exception>
        public void Delete(int id)
        {
            Sale s =sales.FirstOrDefault(s => s.id == id);
            if (s == null)
            {
                LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
            , MethodBase.GetCurrentMethod().Name
            , " cant Delete sale because The saleId is not exist to delete");
                throw new DalIdNotExists("The saleId is not exist to delete");
            }
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
            , MethodBase.GetCurrentMethod().Name
            , "Delete sale");
            sales.Remove(s);

        }

    }
}
