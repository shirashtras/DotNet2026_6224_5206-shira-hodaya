
namespace DO
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
    public record Sale
    (
        int id,
        int idSale,
        int count,
        double price,
        bool isSaleToAll,
        DateTime? startDate,
        DateTime? endDate
    )
    {
        /// <summary>
        /// בנאי לאתחול השדות
        /// </summary>
        public Sale() : this(0, 0, 0, 0.00, false, DateTime.MinValue, DateTime.Now)
        {

        }
        

    }
}