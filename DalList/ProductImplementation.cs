using DO;
using DalApi;
using System.Reflection;
using Tools;
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
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
    , MethodBase.GetCurrentMethod().Name
    , "Create Product");
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
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
                MethodBase.GetCurrentMethod().Name,
                "Read Product not success because productId not exists ");
            throw new DalIdNotExists("productId not exists");
        }
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
        MethodBase.GetCurrentMethod().Name,
        "Read Product ");
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
        var p = DataSource.products.FirstOrDefault(p => filter(p!));
        if (p == null)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
            MethodBase.GetCurrentMethod().Name,
            "Read Product not success becouse productId not exists ");
            throw new DalFilterNotExists("filter not found");
        }

        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
        , MethodBase.GetCurrentMethod().Name
        , "Read Product");
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
        var product = DataSource.products.Where(p => filter(p!));
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
    , MethodBase.GetCurrentMethod().Name
    , "ReadAll Product");
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
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
     , MethodBase.GetCurrentMethod().Name
     , "Update Product");
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
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
            , MethodBase.GetCurrentMethod().Name
            , "Delete failed product because filter not found");
            throw new DalIdNotExists("The productId is not exist to delete");

        }
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
        , MethodBase.GetCurrentMethod().Name
        , "Delete succeded in product");
        DataSource.products.Remove(p);

    }
}