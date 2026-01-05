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
       
        DataSource.customers.Add(item);
        return item.id;
    }
    /// <summary>
    /// פונקצייה לקריאת לקוח נוכחי על פי מזהה
    /// </summary>
    /// <param name="id">מקבל מזהה לקוח</param>
    /// <returns>מחזיר לקוח, ואם לא נמצא יחזיר ערך null</returns>
    public Customer? Read(int id)
    {
        foreach (Customer? customer in DataSource.customers)
        {
            if (customer != null && customer!.id == id)
                return customer;
        }
        return null;
    }
    /// <summary>
    /// פונקציה שמחזירה את פרטי כל הלקוחות
    /// </summary>
    /// <returns>העתק של פרטי הלקוחות</returns>
    public List<Customer?> ReadAll()
    {
        return new List<Customer?>(DataSource.customers!);
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
        bool found = false;
        foreach (Customer? item in DataSource.customers)
        {
            if (item != null && item.id == id)
            {
                DataSource.customers.Remove(item);
                found = true;
                break;

            }
         }

        if (!found)

            throw new Exception("The customer is not exist to delete");

    }
}
    

  
