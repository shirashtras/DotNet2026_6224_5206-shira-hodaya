
namespace DalFacade.DalApi;
using DO;
public interface ISale
{
    /// <summary>
    /// פונקציה ליצירת אובייקט
    /// </summary>
    /// <param name="item">מקבל את שם המבצע אותו יש להוסיף</param>
    /// <returns>מחזירה את קוד המבצע של המבצע שנוצר</returns>
    int Create(Sale item);
    /// <summary>
    /// פונקצייה לקריאת המבצע / האובייקט על פי ה - id שהתקבל
    /// </summary>
    /// <param name="id">מקבל מזהה לקריאה</param>
    /// <returns>מחזיר את האובייקט/המבצע הרצוי </returns>
    Sale? Read(int id);
    /// <summary>
    /// פונקציה לקריאת כל המבצעים/אובייקטים
    /// </summary>
    /// <returns>מחזירה רשימה עם כל המבצעים הרצויים</returns>
    List<Sale> ReadAll();
    /// <summary>
    /// פונקציה לעדכון המבצע / אובייקט 
    /// </summary>
    /// <param name="item">מקבל את האוייבקט הרצוי לעדכון</param>
    void Update(Sale item);
    /// <summary>
    /// פונקציה למחיקת אובייקט מסוים
    /// </summary>
    /// <param name="id">מקבל מזהה למבצע/אובייקט אותו נרצה למחוק</param>
    void Delete(int id);
}
