using BL.BO;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIApi
{
    public interface IOrder
    {
        /// <summary>
        /// פונקציה שמוסיפה מוצר להזמנה ומחשב את המחיר שלו לפי המכירות הקיימות
        /// </summary>
        /// <param name="order"></param>
        /// <param name="productId"></param>
        /// <param name="countOrder"></param>
        /// <returns></returns>
        List<SaleInProduct> AddProductToOrder(Order order, int productId, int countOrder);

        /// <summary>
        /// פונקציה שמחשבת את המחיר הסופי של מוצר בהזמנה לפי המכירות הקיימות
        /// </summary>
        /// <param name="productInOrder"></param>
        void CalcTotalPriceForProduct(BO.ProductInOrder productInOrder);
        /// <summary>
        /// פונקציה שמחשבת את המחיר הסופי של ההזמנה לפי המכירות הקיימות
        /// </summary>
        /// <param name="order"></param>
        void CalcTotalPrice(Order order);
        /// <summary>
        /// פונקציה שמבצעת את ההזמנה ומעדכנת את המכירות הקיימות
        /// </summary>
        /// <param name="order"></param>
        void DoOrder(Order order);
        /// <summary>
        /// פוקנציה שמחפשת את המכירות הקיימות למוצר בהזמנה ומעדכנת את המחיר הסופי שלו לפי המכירות הקיימות
        /// </summary>
        /// <param name="productInOrder"></param>
        /// <param name="isFavorite"></param>
        void SearchSaleForProduct(BO.ProductInOrder productInOrder, bool isFavorite);
    }
}
