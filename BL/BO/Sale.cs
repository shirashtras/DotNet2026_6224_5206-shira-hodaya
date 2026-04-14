using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// ישות עבור מבצע
    /// </summary>
    /// <param name="id">מספר מזהה ייחודי </param>
    /// <param name="idSale">מספר מזהה של המבצע</param>
    /// <param name="count">כמות נדרשת לקבלת מבצע</param>
    /// <param name="price">מחיר כולל במבצע</param>
    /// <param name="isSaleToAll">האם המבצע מיועד לכלל הלקוחות או רק ללקוחות מועדון</param>
    /// <param name="startDate">תאריך תחילת מבצע</param>
    /// <param name="endDate">תאריך סיום מבצע</param>
    public class Sale
    {

        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public double Price_Sale { get; set; }
        public bool If_All_Customers { get; set; }
        public DateTime Date_Start_Sale { get; set; }

        public int Count_Sale { get; set; }
        public DateTime? Date_End_Sale { get; set; }


        /// <summary>
        /// בנאי לאתחול השדות
        /// </summary>
        public Sale(int SaleId, int ProductId, double Price_Sale, bool If_All_Customers, DateTime Date_Start_Sale, int Count_Sale, DateTime? Date_End_Sale)
        {

        }

        public Sale()
        {
        }
    }
}

