using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalList
{
    /// <summary>
    /// ישות עבור מבצע
    /// </summary>
    /// <param name="id">מספר מזהה ייחודי </param>
    /// <param name="idProduct">מספר מזהה של המוצר</param>
    /// <param name="count">כמות נדרשת לקלבת מבצע</param>
    /// <param name="price">מחיר כולל במבצע</param>
    /// <param name="isSaleToAll">האם המבצע מיועד לכלל הלקוחות או רק ללקוחות מועדון</param>
    /// <param name="startDate">תאריך תחילת מבצע</param>
    /// <param name="endDate">תאריך סיום מבצע</param>
    public record Sale
    (
        int id,
        int ?idProduct,
        int ?count,
        double ?price,
        bool ?isSaleToAll,
        DateTime ?startDate,
        DateTime ?endDate
    )
    {
        /// <summary>
        /// בנאי לאתחול השדות
        /// </summary>
        public Sale():this(0,0,0,0.00,false,new DateTime(1647,0,0),DateTime.Now)
        {
            
        }

    }
}
