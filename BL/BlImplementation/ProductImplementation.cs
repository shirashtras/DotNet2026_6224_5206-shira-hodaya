using BL.BO;
using BO;
using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Tools;
using static BO.Tools;


namespace BlImplementation
{
    internal class ProductImplementation : BIApi.IProduct
    {
        public ProductImplementation()
        {
            
        }
        private DalApi.IDal _dal = DalApi.Factory.Get;

       
        public int Create(BO.Product item)
        {
            try
            {
                LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
                , MethodBase.GetCurrentMethod().Name
                , "create sale");
                return _dal.Product.Create(item.ConvertBoProductToDoProduct());
            }
            catch (Exception ex)
            {
                Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Create {item} Product Exeption: {ex.Message}");
                throw new BlIdExistsException("The Product is  Exist!");
            }
        }

        public void Delete(int id)
        {
            try
            {
                Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Delete {id} Product");
                _dal.Product.Delete(id);
            }
            catch (Exception ex)
            {
                Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Delete {id} Product  Exception: {ex.Message}");
                throw new BlIdNotExistsException("The product is not  Exist!");
            }
        }

        public BO.Product? Read(int id)
        {
            try
            {
                Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read {id} Product");
                return _dal.Product.Read(id).ConvertDoProductToBoProduct();
            }
            catch
            {
                Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read {id} Product  null");
                throw new BlIdNotExistsException("The product is not Exist!");
            }
        }

        public BO.Product? Read(Func<BO.Product, bool> filter)
        {
            try
            {
                Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read Product");
                return _dal.Product.Read(s => filter(s.ConvertDoProductToBoProduct())).ConvertDoProductToBoProduct();
            }
            catch
            {
                Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read Product  null");
                throw new BlIdNotExistsException("The product is not Exist!");
            }

        }

        public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null)
        {
            try
            {
                if (filter == null)
                {
                    Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"ReadAll Product");
                    return _dal.Product.ReadAll().Select(s => s.ConvertDoProductToBoProduct()).ToList();
                }
                return _dal.Product.ReadAll(s => filter(s.ConvertDoProductToBoProduct())).Select(s => s.ConvertDoProductToBoProduct()).ToList();
            }
            catch
            {
                throw new BlIdNotExistsException("The products are not  Exist!");
            }

        
        }
        



        public void Update(BO.Product item)
        {
            try
            {
                Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Update {item} Product");
                _dal.Product.Update(item.ConvertBoProductToDoProduct());
            }
            catch (Exception ex)
            {
                Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Update {item} Product  Exeption: {ex.Message}");
                throw new BlIdNotExistsException("The product is not Exist!");
            }
        }


        public void AllSalesInDate(BO.ProductInOrder product, bool isPreferedCus)
        {
            try
            {
                var sales = _dal.Sale.ReadAll(s =>
                    s.id == product.idProductInOrder &&
                    s.startDate <= DateTime.Now &&
                    s.endDate >= DateTime.Now &&
                    (isPreferedCus || s.isSaleToAll));

                product.listSaleToProductInOrder = sales
                    .Select(s => new SaleInProduct
                    {
                        idSaleInProduct = s.id,
                        isSaleInProductSpecialToAll = s.isSaleToAll,
                        priceSaleInProduct = s.price
                    })
                    .OrderBy(s => s.priceSaleInProduct)
                    .ToList();
            }
            catch (Exception ex)
            {
                
            }
        }

    }
}

