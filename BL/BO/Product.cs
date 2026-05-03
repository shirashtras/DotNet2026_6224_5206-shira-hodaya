using BL.BO;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{

    /// <summary>
    /// ישות מוצר
    /// </summary>
    /// <param name="id">מספר מזהה</param>
    /// <param name="name">שם מוצר</param>
    /// <param name="category">קטגוריה</param>
    /// <param name="price">מחיר מוצר</param>
    /// <param name="count">כמות במלאי</param>
    public class Product
    {
        public int Product_Id { get; set; }
        public string Product_Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public BL.BO.Category category { get; set; }
        private List<SaleInProduct> listSaleInProduct { get; set; }

        /// <summary>
        /// בנאי לאתחול שדות / ערכים
        /// </summary>
        public Product(int Product_Id, string Product_Name, double Price, int Count, BL.BO.Category category)
        {
            this.Product_Id = Product_Id;
            this.Product_Name = Product_Name;
            this.Price = Price;
            this.Count = Count;
            this.category = category;
            listSaleInProduct = new List<SaleInProduct>();
        }
        public Product()
        {
            
        }
        public override string ToString() => this.ToStringProperty();

    }

}

