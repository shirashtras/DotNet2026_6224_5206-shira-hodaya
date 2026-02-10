using DO;
using DalApi;
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
            throw new DalIdExists("id customer is already exists");
        else
        {
            DataSource.customers.Add(item);
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
            throw new DalIdNotExists("customer not exists");
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
        var q = DataSource.customers.FirstOrDefault(c=>filter(c!));
        if (q == null)
            throw new DalFilterNotExists("filter not found");
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
            throw new DalIdNotExists("The customerId is not exist to delete");
        DataSource.customers.Remove(c);

    }


}



