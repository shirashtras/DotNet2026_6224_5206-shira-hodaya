using BL.BO;
using BO;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    internal class OrderImplementation
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;

        public void SearchSaleForProduct(BO.ProductInOrder productInOrder, bool isOrderToExistCustomer)
        {
            productInOrder.listSaleToProductInOrder = _dal.Sale.ReadAll(s => s.idSale == productInOrder.idProductInOrder &&
            s.startDate <= DateTime.Now && s.endDate >= DateTime.Now && s.count == productInOrder.amountProductInOrder
            && (isOrderToExistCustomer || s.isSaleToAll))
                 .Select(s => new SaleInProduct() { idSaleInProduct = s.idSale, amountSaleInProduct = s.count, priceSaleInProduct = s.price, isSaleInProductSpecialToAll = s.isSaleToAll })
                 .OrderBy(s => s.priceSaleInProduct)
                    .ToList();

        }
        public void CalcTotalPrice(Order order)
        {
            order.finalPrice += (from product in order.listProductInOrder
                                 select product.basePriceProductInOrder).Sum();

        }
    }
}