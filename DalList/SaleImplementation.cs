using DO;
using DalApi;
namespace DalList;

internal class SaleImplementation : ISale
{
    /// <summary>
    /// פונקציה ליצירת מבצע
    /// </summary>
    /// <param name="item">מקבל ישות מבצע</param>
    /// <returns>מחזיר מזהה מבצע</returns>
    public int Create(Sale item)
    {

        DataSource.sales.Add(item);
        return item.id;
    }
    /// <summary>
    /// פונקציה לקריאת מבצע על פי מזהה מבצע
    /// </summary>
    /// <param name="id">מקבל מזהה מבצע</param>
    /// <returns>מחזיר את המבצע המבוקש</returns>

    public Sale? Read(int id)
    {
        foreach (Sale? sl in DataSource.sales)
        {
            if (sl?.id == id)
                return sl;
        }
        return null;
    }
    /// <summary>
    /// פונקציה לקריאת כל פרטי המבצעים
    /// </summary>
    /// <returns>מחזיר העתק של רשימת המבצעים</returns>
    public List<Sale?> ReadAll()
    {
        return new List<Sale?>(DataSource.sales!);
    }
    /// <summary>
    /// פוקנצייה למחיקת מבצע
    /// </summary>
    /// <param name="id">מקבל מזהה מבצע למחיקה</param>
    /// <exception cref="Exception">זורק שגיאה באם המזהה מבצע לא קיים</exception>
    public void Delete(int id)
    {
        bool found = false;
        foreach (Sale? sl in DataSource.sales!)
        {
            if (sl != null && sl!.id == id)
            {
                DataSource.sales.Remove(sl);
                found = true;
                break;

            }
        }
        if (!found)

            throw new Exception("The id sale isn't fount to delete");

    }

    /// <summary>
    /// פונקציה לעדכון מבצע על פי מזהה
    /// </summary>
    /// <param name="item">מקבל ישות מבצע</param>
    public void Update(Sale item)
    {
        Delete(item.id);
        DataSource.sales!.Add(item);
    }



}