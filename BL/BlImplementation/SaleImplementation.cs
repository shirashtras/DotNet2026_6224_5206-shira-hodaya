using BIApi;
using BO;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Tools;


namespace BlImplementation
{
    internal class SaleImplementation:ISale
    {
        public SaleImplementation()
        {
            
        }
        private DalApi.IDal _dal = DalApi.Factory.Get;

        /// <summary>
        /// פונקציה ליצירת מבצע
        /// </summary>
        /// <param name="item">מקבל ישות מבצע</param>
        /// <returns>מחזיר מזהה מבצע</returns>
        public int Create(BO.Sale item)
        {
            try
            {
                LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName
                , MethodBase.GetCurrentMethod().Name
                , "create sale");
                return _dal.Sale.Create(item.ConvertBoSaleToDoSale());
            }
            catch (Exception ex)
            {
                Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Create {item} Sale Exeption: {ex.Message}");
                throw new BlIdExistsException("The sale is  Exist!");
            }
        }
        /// <summary>
        /// פונקציה למחיקת מבצע 
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="BlIdNotExistsException"></exception>
        public void Delete(int id)
        {
            try
            {
                Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Delete {id} Sale");
                _dal.Sale.Delete(id);
            }
            catch (Exception ex)
            {
                Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Delete {id} Sale Exepion: {ex.Message}");
                throw new BlIdNotExistsException("The sale is not Exist!");
            }
        }
        /// <summary>
        /// פונקציה להחזרת מבצע בודד
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="BlIdNotExistsException"></exception>
        public BO.Sale? Read(int id)
        {

            try
            {
                Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read {id} Sale");
                return _dal.Sale.Read(id).ConvertDoSaleToBoSale();
            }
            catch
            {
                Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read {null} Sale");
                throw new BlIdNotExistsException("The sale is not Exist!");
            }
        }
        /// <summary>
        /// פונקציה להחזרת מצבע בודד לפי תנאי מסוים
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        /// <exception cref="BlIdNotExistsException"></exception>
        public BO.Sale? Read(Func<BO.Sale, bool> filter)
        {
            try
            {
                DO.Sale sale = _dal.Sale.Read(s => filter(s.ConvertDoSaleToBoSale()));
                Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read {sale} Sale");

                return sale.ConvertDoSaleToBoSale();
            }
            catch
            {
                Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Read {null} Sale");
                throw new BlIdNotExistsException("The sale is not Exist!");
            }
        }
        /// <summary>
        /// פונקציה להחזרת כל המבצעים
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        /// <exception cref="BlIdExistsException"></exception>
        public List<BO.Sale?> ReadAll(Func<BO.Sale, bool>? filter = null)
        {
            try
            {
                if (filter == null)
                    return _dal.Sale.ReadAll().Select(s => s.ConvertDoSaleToBoSale()).ToList();
                else
                    return _dal.Sale.ReadAll(s => filter(s.ConvertDoSaleToBoSale())).Select(s => s.ConvertDoSaleToBoSale()).ToList();
            }
            catch
            {
                throw new BlIdExistsException("The sales are not  Exist!");
            }

        }
        /// <summary>
        /// פונקציה לעדכון כל המבצעים
        /// </summary>
        /// <param name="item"></param>
        /// <exception cref="BlIdExistsException"></exception>

        public void Update(BO.Sale item)
        {
            try
            {
                Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Update {item} Sale");
                _dal.Sale.Update(item.ConvertBoSaleToDoSale());
            }
            catch (BlIdExistsException ex)
            {
                Tools.LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Update {item} Sale Exeption: {ex.Message}");
                throw new BlIdExistsException("The sale is  Exist!");
            }
        }
    }




}

