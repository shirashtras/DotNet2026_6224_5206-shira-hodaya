

namespace DalFacade.DalApi;
using DO;
public interface ICustomer
{
    /// <summary>
    /// פונקציה ליצירת אובייקט
    /// </summary>
    /// <param name="item">מקבל את שם הלקוח אותו יש להוסיף</param>
    /// <returns>מחזירה את קוד הלקוח של הלקוח שנוצר</returns>
    int Create(Customer item);
    /// <summary>
    /// פונקצייה לקריאת הלקוח / האובייקט על פי ה - id שהתקבל
    /// </summary>
    /// <param name="id">מקבל מזהה לקריאה</param>
    /// <returns>מחזיר את האובייקט/הלקוח הרצוי </returns>
    Customer? Read(int id);
    /// <summary>
    /// פונקציה לקריאת כל הלקוחוח/אובייקטים
    /// </summary>
    /// <returns>מחזירה רשימה עם כל הלקוחות הרצויים</returns>
    List<Customer> ReadAll();
    /// <summary>
    /// פונקציה לעדכון הלקוח / אובייקט 
    /// </summary>
    /// <param name="item">מקבל את האוייבקט הרצוי לעדכון</param>
    void Update(Customer item);
    /// <summary>
    /// פונקציה למחיקת אובייקט מסוים
    /// </summary>
    /// <param name="id">מקבל מזהה ללקוח/אובייקט אותו נרצה למחוק</param>
    void Delete(int id);

}
