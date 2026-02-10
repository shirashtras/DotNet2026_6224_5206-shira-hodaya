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
        //אופציונלי לעשות select/where
        Sale sale = DataSource.sales.FirstOrDefault(c => c.id == id);
        if (sale == null)
            throw new DalIdNotExists("saleId not exists");
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
        var q = DataSource.sales.FirstOrDefault(s=>filter(s!));
        if (q == null)
            throw new DalFilterNotExists("filter not found");
        return q;
    }
    /// <summary>
    /// פונקציה לקריאת כל פרטי המבצעים
    /// </summary>
    /// <returns>מחזיר העתק של רשימת המבצעים</returns>
    public List<Sale?> ReadAll(Func<Sale, bool>? filter)
    {
        if (filter == null)
            return new List<Sale?>(DataSource.sales);
        var q = DataSource.sales.Where(s => filter(s!));
        return q.ToList();
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
    /// <summary>
    /// פוקנצייה למחיקת מבצע
    /// </summary>
    /// <param name="id">מקבל מזהה מבצע למחיקה</param>
    /// <exception cref="Exception">זורק שגיאה באם המזהה מבצע לא קיים</exception>
    public void Delete(int id)
    {
        Sale s = DataSource.sales.FirstOrDefault(s => s.id == id);
        if (s == null)
            throw new DalIdNotExists("The saleId is not exist to delete");
        DataSource.sales.Remove(s);
    }


}