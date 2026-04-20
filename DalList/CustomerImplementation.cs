using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml.Serialization;
using Tools;
namespace Dal
{
    internal class CustomerImplementation : ICustomer
    {
        const string path = @"..\customers.xml";
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Customer>));
        List<Customer>? customers;

        private List<Customer> LoadList()
        {
            if (!File.Exists(path))
                return new List<Customer>();

            using (StreamReader sr = new StreamReader(path))
            {
                return xmlSerializer.Deserialize(sr) as List<Customer> ?? new List<Customer>();
            }
        }

        private void SaveList(List<Customer> list)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                xmlSerializer.Serialize(sw, list);
            }
        }

        // יצירת לקוח חדש
        public int Create(Customer item)
        {
            customers = LoadList();

            int newId = item.id;
            Customer newItem = item with { id = newId };

            if (customers.Any(c => c.id == newItem.id))
                throw new DalIdExists("המזהה כבר קיים במערכת");

            customers.Add(newItem);
            SaveList(customers);

            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
                                  MethodBase.GetCurrentMethod().Name,
                                  $"Created Customer with ID: {newItem.id}");

            return newItem.id;
        }

        // קריאה לפי מזהה
        public Customer? Read(int id)
        {
            customers = LoadList();
            Customer? customer = customers.FirstOrDefault(c => c.id == id);

            if (customer == null)
                throw new DalIdNotExists("הלקוח לא קיים");

            return customer;
        }

        // קריאה לפי תנאי
        public Customer? Read(Func<Customer, bool> filter)
        {
            customers = LoadList();
            Customer? c = customers.FirstOrDefault(filter);

            if (c == null)
                throw new DalFilterNotExists("לא נמצא לקוח מתאים");

            return c;
        }

        // קריאה של כל הלקוחות
        public List<Customer?> ReadAll(Func<Customer, bool>? filter)
        {
            customers = LoadList();

            if (filter == null)
                return new List<Customer?>(customers);

            return customers.Where(filter).ToList();
        }

        // עדכון לקוח
        public void Update(Customer item)
        {
            customers = LoadList();

            Customer? existing = customers.FirstOrDefault(c => c.id == item.id);
            if (existing == null)
                throw new DalIdNotExists("לא ניתן לעדכן — הלקוח לא קיים");

            customers.Remove(existing);
            customers.Add(item);

            SaveList(customers);
        }

        // מחיקת לקוח
        public void Delete(int id)
        {
            customers = LoadList();

            Customer? c = customers.FirstOrDefault(c => c.id == id);
            if (c == null)
                throw new DalIdNotExists("לא ניתן למחוק — הלקוח לא קיים");

            customers.Remove(c);
            SaveList(customers);
        }
    }
}
