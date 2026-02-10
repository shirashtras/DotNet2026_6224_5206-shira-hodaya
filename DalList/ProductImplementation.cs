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
        Product product = DataSource.products.FirstOrDefault(c => c.id == id);
        if (product == null)
            throw new DalIdNotExists("productId not exists");
        return product;
    }
    /// <summary>
    /// פונקציה למציאת אובייקט על פי תנאי
    /// וכאשר לא נמצא אובייקט תזרק שגיאה
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    /// <exception cref="DalFilterNotExists"></exception>
    public Product? Read(Func<Product, bool> filter)
    {
        var p = DataSource.products.FirstOrDefault(p=>filter(p!));
        if ( p == null)
            throw new DalFilterNotExists("filter not found");
        return p;
    }

    /// <summary>
    /// פונקציה שמחזירה את רשימת המוצרים
    /// </summary>
    /// <returns>העתק רשימה ובה כל המוצרים</returns>
    public List<Product?> ReadAll(Func<Product, bool>? filter)
    {
        if (filter == null)
            return new List<Product?>(DataSource.products);
        var product = DataSource.products.Where(p=> filter(p!));
        return product.ToList();

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
        Product p = DataSource.products.FirstOrDefault(p => p.id == id);
        if (p == null)
            throw new DalIdNotExists("The productId is not exist to delete");
        DataSource.products.Remove(p);

    }
}








