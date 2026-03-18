using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Tools;
namespace Dal
{
    internal class ProductImplementation :IProduct
    {
        const string path = @"..\xml\product.xml";
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Product>));
        List<Product>? products;
        private List<Product> LoadList()
        {
            using (StreamReader sr = new StreamReader(path))
            {
                products = xmlSerializer.Deserialize(sr) as List<Product>;

            }
            return products;
        }
        private void SaveList(List<Product> list)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                xmlSerializer.Serialize(sw, list);
            }
        }
        /// <summary>
        /// פונקצייה ליצירת מוצר חדש
        /// </summary>
        /// <param name="item">מקבלת את כל פרטי המוצר</param>
        /// <returns>מחזירה מספר מזהה של המוצר החדש</returns>
        public int Create(Product item)
        {
            products = LoadList();
            var q = products.Any(p =>p?.id == item.id);
            if (q)
            {
                LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
                , MethodBase.GetCurrentMethod().Name
                , "create product didnt succed because  id product is already exists");
                throw new DalIdExists("id product is already exists");
            }
            else
            {
                products.Add(item);
                LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
                    , MethodBase.GetCurrentMethod().Name
                    , "Create Product");
                return item.id;
            }
        }
        /// <summary>
        /// פונקצייה לקריאת מוצר נוכחי על פי מזהה
        /// </summary>
        /// <param name="id">מקבל מזהה מוצר</param>
        /// <returns>מחזיר מוצר, ואם לא נמצא יזרוק שגיאה </returns>
        public Product? Read(int id)
        {
            products = LoadList();
            Product product = products.FirstOrDefault(p => p.id == id);
            if (product == null)
            {
                LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
                , MethodBase.GetCurrentMethod().Name
                , "Read product didnt succed because id product is already exists");
                throw new DalIdNotExists("product not exists");
            }

            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
                    , MethodBase.GetCurrentMethod().Name
                    , "Read Product");
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
            products = LoadList();

            var q = products.FirstOrDefault(p => filter(p!));
            if (q == null)
            {
                LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
                 , MethodBase.GetCurrentMethod().Name
                 , "Read filter product didnt succed because filter not found");
                throw new DalFilterNotExists("filter not found");
            }

            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
                    , MethodBase.GetCurrentMethod().Name
                    , "Read Filter Product");
            return q;
        }
        /// <summary>
        /// פונקציה שמחזירה את פרטי כל המוצרים
        /// </summary>
        /// <returns>העתק של פרטי המוצרים</returns>
        public List<Product?> ReadAll(Func<Product, bool>? filter)
        {
            products = LoadList();
            if (filter == null)
                return new List<Product?>(products);
            var customer = products.Where(c => filter(c!));
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
                    , MethodBase.GetCurrentMethod().Name
                    , "ReadAll Product");
            return products.ToList();

        }

        /// <summary>
        /// פונקציה לעדכון מוצר
        /// </summary>
        /// <param name="item"> יישות מוצר עבור עדכון</param>
        public void Update(Product item)
        {
            products = LoadList();
            Delete(item.id);
            products!.Add(item);
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
            , MethodBase.GetCurrentMethod().Name
            , "Update product");
        }
        /// <summary>
        /// פונקציה למחיקת מוצר עפ"י מזהה
        /// </summary>
        /// <param name="id"> מקבל את המזהה מוצר למחיקה</param>
        /// <exception cref="Exception">אם המזהה מוצר לא קיים</exception>
        public void Delete(int id)
        {
            products = LoadList();  
            Product p = products.FirstOrDefault(p => p.id == id);
            if (p == null)
            {
                LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
                , MethodBase.GetCurrentMethod().Name
                , "Delete product didnt success because The productId is not exist to delete");
                throw new DalIdNotExists("The productId is not exist to delete");
            }

            products.Remove(p);
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
            , MethodBase.GetCurrentMethod().Name
            , "Read product");
        }

    }
}
