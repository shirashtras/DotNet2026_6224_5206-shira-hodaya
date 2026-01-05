using DO;
using DalApi;
namespace DalList;

internal class ProductImplementation : IProduct
{
    /// <summary>
    /// פונקציה להוספת מוצר
    /// </summary>
    /// <param name="item">מקבל  מוצר</param>
    /// <returns>מחזיר מזהה מוצר</returns>
    public int Create(Product item)
    {

        DataSource.products.Add(item);
        return item.id;

    }

    /// <summary>
    /// פונקציה לקריאת מוצר
    /// </summary>
    /// <param name="id">מקבל מזהה מוצר</param>
    /// <returns>מחזיר את המוצר המבוקש, באם לא יוחזר null</returns>
    public Product? Read(int id)
    {
        foreach (Product? pr in DataSource.products)
        {
            if (pr?.id == id)
                return pr;
        }
        return null;
    }

    /// <summary>
    /// פונקציה שמחזירה את רשימת המוצרים
    /// </summary>
    /// <returns>העתק רשימה ובה כל המוצרים</returns>
    public List<Product?> ReadAll()
    {
        return new List<Product?>(DataSource.products!);
    }
    /// <summary>
    /// פונקציה לעדכון מוצר
    /// </summary>
    /// <param name="item">מקבל את המוצר המבוקש לעדכון</param>
    public void Update(Product item)
    {
        Delete(item.id);
        DataSource.products!.Add(item);
    }
    /// <summary>
    /// פונקציה למחיקת לקוח
    /// </summary>
    /// <param name="id">מקבל מזהה לקוח למחיקה</param>
    /// <exception cref="Exception">שגיאה באם מזהה לקוח לא קיים</exception>
    public void Delete(int id)
    {
        bool found = false;
        foreach (Product? pr in DataSource.products)
        {
            if (pr != null && pr!.id == id)
            {
                DataSource.products.Remove(pr);
                found = true;
                break;
            }
        }

        if (!found)

            throw new Exception("The product isn't found to delete");

    }
}








