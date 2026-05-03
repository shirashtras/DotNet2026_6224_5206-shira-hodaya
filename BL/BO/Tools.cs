using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    internal static class Tools
    {

       /// <summary>
       /// פונקציה להדפסת כל המאפייינים
       /// </summary>
       /// <typeparam name="T"></typeparam>
       /// <param name="t"></param>
       /// <returns></returns>
        public static string ToStringProperty<T>(this T t)
        {
            string str = "";
            Type type = t.GetType();
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                str += string.Format(property.Name, property.GetValue(t));
            }
            return str;
        }
        /// <summary>
        /// פונקציה להמרת לקוח מBO לDO
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public static DO.Customer ConvertBoCustomerToDoCustomer(this BO.Customer customer)
        {
            return new DO.Customer(customer.Customer_Id, customer.Customer_Name, customer.Customer_Phone, customer.Customer_Address);
        }
        /// <summary>
        /// פונקציה להמרת לקוח מDO לBO
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public static BO.Customer ConvertDoCustomerToBoCustomer(this DO.Customer customer)
        {
            return new BO.Customer()
            {
                Customer_Id = customer.id,
                Customer_Name = customer.nameCustomer,
                Customer_Address = customer.adress,
                Customer_Phone = customer.phoneNumber
            };
        }

        /// <summary>
        /// פונקציה להמרת מוצר מBO לDO
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public static DO.Product ConvertBoProductToDoProduct(this BO.Product product)
        {
            return new DO.Product(product.Product_Id, product.Product_Name, (Category)product.category, product.Price, product.Count);
        }
        /// <summary>
        /// פונקציה להמרת מוצר מDO לBO
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public static BO.Product ConvertDoProductToBoProduct(this DO.Product product)
        {
            try
            {
                if (product == null)
                    return null;
                return new BO.Product() { 
                    Product_Id = product.id,
                    Product_Name = product.name,
                    Price = (double)product.price,
                    Count = (int)product.count,
                    category = (BL.BO.Category)product.category
                };
            }
            catch (Exception ex)
            {
                return null;
            }


        }
        /// <summary>
        /// פונקציה להמרת מבצע מBO לDO  
        /// </summary>
        /// <param name="sale"></param>
        /// <returns></returns>
        public static DO.Sale ConvertBoSaleToDoSale(this BO.Sale sale)
        {
            return new DO.Sale(sale.SaleId, sale.ProductId, sale.Count_Sale, sale.Price_Sale, sale.If_All_Customers, sale.Date_Start_Sale, sale.Date_End_Sale);
        }
        /// <summary>
        /// פונקציה להמרת מבצע מDO לBO
        /// </summary>
        /// <param name="sale"></param>
        /// <returns></returns>

        public static BO.Sale ConvertDoSaleToBoSale(this DO.Sale sale)
        {
            return new BO.Sale()
            {
                SaleId = sale.id,
                ProductId = sale.idSale,
                Price_Sale = (double)sale.price,
                If_All_Customers = (bool)sale.isSaleToAll,
                Date_Start_Sale = (DateTime)sale.startDate,
                Count_Sale = (int)sale.count,
                Date_End_Sale = sale.endDate,
            };
          

        }

    }
}
