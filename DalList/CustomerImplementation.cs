using DO;
using DalApi;
using Tools;
using System.Reflection;
namespace DalList;

internal class CustomerImplementation : ICustomer
{
    /// <summary>
    /// פונקצייה ליצירת לקוח חדש
    /// </summary>
    /// <param name="item">מקבלת את כל פרטי הלקוח</param>
    /// <returns>מחזירה מספר מזהה של הלקוח החדש</returns>
    public int Create(Customer item)
    {
        var q = DataSource.customers.Any(c => c?.id == item.id);
        if (q)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
            , MethodBase.GetCurrentMethod().Name
            , "create customer didnt succed because  id customer is already exists");
            throw new DalIdExists("id customer is already exists");
        }
        else
        {
            DataSource.customers.Add(item);
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
                , MethodBase.GetCurrentMethod().Name
                , "Create Cutomer");
            return item.id;
        }
    }
    /// <summary>
    /// פונקצייה לקריאת לקוח נוכחי על פי מזהה
    /// </summary>
    /// <param name="id">מקבל מזהה לקוח</param>
    /// <returns>מחזיר לקוח, ואם לא נמצא יזרוק שגיאה </returns>
    public Customer? Read(int id)
    {
        Customer customer = DataSource.customers.FirstOrDefault(c => c.id == id);
        if (customer == null)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
            , MethodBase.GetCurrentMethod().Name
            , "Read customer didnt succed because  id customer is already exists");
            throw new DalIdNotExists("customer not exists");
        }

        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
                , MethodBase.GetCurrentMethod().Name
                , "Read Cutomer");
        return customer;

    }
    /// <summary>
    /// פונקציה למציאת אובייקט על פי תנאי
    /// וכאשר לא נמצא אובייקט תזרק שגיאה
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    /// <exception cref="DalFilterNotExists"></exception>
    public Customer? Read(Func<Customer, bool> filter)
    {
        var q = DataSource.customers.FirstOrDefault(c => filter(c!));
        if (q == null)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
             , MethodBase.GetCurrentMethod().Name
             , "Read filter customer didnt succed because filter not found");
            throw new DalFilterNotExists("filter not found");
        }

        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
                , MethodBase.GetCurrentMethod().Name
                , "Read Filter Cutomer");
        return q;
    }
    /// <summary>
    /// פונקציה שמחזירה את פרטי כל הלקוחות
    /// </summary>
    /// <returns>העתק של פרטי הלקוחות</returns>
    public List<Customer?> ReadAll(Func<Customer, bool>? filter)
    {
        if (filter == null)
            return new List<Customer?>(DataSource.customers);
        var customer = DataSource.customers.Where(c => filter(c!));
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
                , MethodBase.GetCurrentMethod().Name
                , "ReadAll Cutomer");
        return customer.ToList();

    }

    /// <summary>
    /// פונקציה לעדכון לקוח
    /// </summary>
    /// <param name="item"> יישות לקוח עבור עדכון</param>
    public void Update(Customer item)
    {
        Delete(item.id);
        DataSource.customers!.Add(item);
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
        , MethodBase.GetCurrentMethod().Name
        , "Update customer");
    }
    /// <summary>
    /// פונקציה למחיקת לקוח עפ"י מזהה
    /// </summary>
    /// <param name="id"> מקבל את המזהה לקוח למחיקה</param>
    /// <exception cref="Exception">אם המזהה לקוח לא קיים</exception>
    public void Delete(int id)
    {
        Customer c = DataSource.customers.FirstOrDefault(c => c.id == id);
        if (c == null)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
            , MethodBase.GetCurrentMethod().Name
            , "Delete customer didnt succed because The customerId is not exist to delete");
            throw new DalIdNotExists("The customerId is not exist to delete");
        }
          
        DataSource.customers.Remove(c);
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
        , MethodBase.GetCurrentMethod().Name
        , "Read customer");
    }


}



