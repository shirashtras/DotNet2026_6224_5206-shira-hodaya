
namespace DalFacade.DalApi;
using DO;
public interface IProduct
{
    /// <summary>
    /// פונקציה ליצירת אובייקט
    /// </summary>
    /// <param name="item">מקבל את שם הפריט אותו יש להוסיף</param>
    /// <returns>מחזירה את קוד הפריט של המוצר שנוצר</returns>
    int Create(Product item);
    /// <summary>
    /// פונקצייה לקריאת הפריט / האובייקט על פי ה - id שהתקבל
    /// </summary>
    /// <param name="id">מקבל מזהה לקריאה</param>
    /// <returns>מחזיר את האובייקט/הפריט הרצוי </returns>
    Product? Read(int id);
    /// <summary>
    /// פונקציה לקריאת כל הפריטים/אובייקטים
    /// </summary>
    /// <returns>מחזירה רשימה עם כל הפריטים הרצויים</returns>
    List<Product> ReadAll();
    /// <summary>
    /// פונקציה לעדכון פריט / אובייקט 
    /// </summary>
    /// <param name="item">מקבל את האוייבקט הרצוי לעדכון</param>
    void Update(Product item);  
    /// <summary>
    /// פונקציה למחיקת אובייקט מסוים
    /// </summary>
    /// <param name="id">מקבל מזהה לפריט/אובייקט אותו נרצה למחוק</param>
    void Delete(int id);    
 
}
