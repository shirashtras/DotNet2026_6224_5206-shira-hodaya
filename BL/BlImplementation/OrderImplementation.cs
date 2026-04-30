using BIApi;
using BL.BO;
using BO;
using DO;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    public class OrderImplementation:IOrder

    {
        public OrderImplementation()
        {

        }
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
        public void CalcTotalPriceForProduct(BO.ProductInOrder productForCalc)
        {
            int count = productForCalc.amountProductInOrder;
            List<SaleInProduct> usedProducts = new List<SaleInProduct>();
            double totalPrice = 0;
            foreach (var p in productForCalc.listSaleToProductInOrder)
            {
                if (count < p.amountSaleInProduct)
                    continue;
                int amount = count / p.amountSaleInProduct;
                totalPrice += amount * p.priceSaleInProduct;
                count -= amount * p.amountSaleInProduct;
                usedProducts.Add(p);
                if (count == 0)
                    break;
            }
            totalPrice += count * productForCalc.basePriceProductInOrder;
            productForCalc.finalPriceProductInOrder = totalPrice;
            productForCalc.listSaleToProductInOrder = usedProducts;
        }
        public List<SaleInProduct> AddProductToOrder(Order order, int amountProductInOrder, int idProductInOrder)
        {
            var product = _dal.Product.Read(idProductInOrder);
            if (product == null)
                throw new Exception("לא נמצא מוצר עם מזהה כזה");
            var existingProductInOrder = order.listProductInOrder.FirstOrDefault(p => p.idProductInOrder == idProductInOrder);
            if (existingProductInOrder != null)
            {
                if (existingProductInOrder.amountProductInOrder + amountProductInOrder > product.count)
                    throw new Exception("אין מספיק במלאי");
                existingProductInOrder.amountProductInOrder += amountProductInOrder;
            }
            else
            {
                if (amountProductInOrder > product.count)
                    throw new Exception("אין מספיק במלאי עבור מוצר זה");
                else
                {
                    var newProductInOrder = new BO.ProductInOrder
                    {
                        idProductInOrder = product.id,
                        amountProductInOrder = amountProductInOrder,
                        basePriceProductInOrder = product.price,
                        nameProductInOrder = product.name

                    };

                    order.listProductInOrder.Add(newProductInOrder);
                    existingProductInOrder = newProductInOrder;
                    SearchSaleForProduct(existingProductInOrder, true);
                    CalcTotalPriceForProduct(existingProductInOrder);
                    CalcTotalPrice(order);


                }


            }
            return existingProductInOrder.listSaleToProductInOrder;

        }
        public void DoOrder(Order order)
        {
            foreach (var item in order.listProductInOrder)
            {
                var product = _dal.Product.Read(item.idProductInOrder);
                if (product?.count < item.amountProductInOrder)
                    throw new Exception("אין מספיק במלאי");
                var updatedProduct = product with { count = product.count - item.amountProductInOrder };
                _dal.Product.Update(product);

            }
        }
    }
}