using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    internal class CustomerImplementation : BIApi.ICustomer
    {

        public CustomerImplementation()
        {

        }
        private DalApi.IDal _dal = DalApi.Factory.Get;
        /// <summary>
        /// פונקציה ליצירת לקוח חדש, מחזירה את מספר הלקוח שנוצר
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        /// <exception cref="BlIdExistsException"></exception>
        public int Create(Customer item)
        {
            try
            {
                return _dal.Customer.Create(item.ConvertBoCustomerToDoCustomer());
            }
            catch
            {
                throw new BlIdExistsException("The customer is Exist!");
            }
        }
        /// <summary>
        /// פונקציה למחיקת לקוח, מקבלת את מספר הלקוח ומוחקת אותו
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="BlIdNotExistsException"></exception>

        public void Delete(int id)
        {
            try
            {
                _dal.Customer.Delete(id);
            }
            catch
            {
                throw new BlIdNotExistsException("The customer is not Exist!");
            }
        }
        /// <summary>
        /// פונקציה שמחזירה האם לקוח קיים לפי מספר הלקוח שקיבלה
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public bool IsExist(int id)
        {
            try
            {
                _dal.Customer.Read(id);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// פונקציה לקריאת לקוח לפי מספר הלקוח, מחזירה את הלקוח המבוקש
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="BlIdNotExistsException"></exception>
        public BO.Customer? Read(int id)
        {
            try
            {
                return _dal.Customer.Read(id).ConvertDoCustomerToBoCustomer();
            }
            catch
            {
                throw new BlIdNotExistsException("The customer is not Exist!");
            }
        }
        /// <summary>
        /// פונקציה לקריאת לקוח לפי תנאי מסוים
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        /// <exception cref="BlIdNotExistsException"></exception>

        public BO.Customer? Read(Func<Customer, bool> filter)
        {
            try
            {
                return _dal.Customer.Read(s => filter(s.ConvertDoCustomerToBoCustomer())).ConvertDoCustomerToBoCustomer();
            }
            catch
            {
                throw new BlIdNotExistsException("The customer is not Exist!");
            }

        }
        /// <summary>
        /// פונקציה לקריאת כל הלקוחות 
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        /// <exception cref="BlIdNotExistsException"></exception>

        public List<BO.Customer?> ReadAll(Func<Customer, bool>? filter = null)
        {

            try
            {
                if (filter == null)
                    return _dal.Customer.ReadAll().Select(s => s.ConvertDoCustomerToBoCustomer()).ToList();
                else
                    return _dal.Customer.ReadAll(s => filter(s.ConvertDoCustomerToBoCustomer())).Select(s => s.ConvertDoCustomerToBoCustomer()).ToList();
            }
            catch
            {
                throw new BlIdNotExistsException("The customeres are not Exist!");
            }

        }
        /// <summary>
        /// פונקציה לעדכון לקוח לפי ID מסוים
        /// </summary>
        /// <param name="item"></param>
        /// <exception cref="BlIdNotExistsException"></exception>

        public void Update(Customer item)
        {
            try
            {
                _dal.Customer.Update(item.ConvertBoCustomerToDoCustomer());
            }
            catch
            {
                throw new BlIdNotExistsException("The customer is not Exist!");
            }
        }
    }

}

