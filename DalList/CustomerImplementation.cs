using DO;
using DalApi;
namespace DalList;


internal class CustomerImplementation : ICustomer
{
    public int Create(Customer item)
    {

        for (int i = 0; i < DataSource.customers.Count; i++)
        {
            if (DataSource.customers[i] != null && DataSource.customers[i].id == item.id)
            {
                throw new InvalidOperationException("לקוח זה כבר קיים ברשימת הלקוחות");
            }
        }

        DataSource.customers.Add(item);
        return item.id;
    }

    public Customer? Read(int id)
    {
        foreach (Customer customer in DataSource.customers)
        {
            if (customer.id == id)
                return customer;
        }
        return null;
    }

    public List<Customer> ReadAll()
    {
        return DataSource.customers == null ? null : DataSource.customers;
    }

    public void Update(Customer item)
    {
        bool found = false;
        for (int i = 0; i < DataSource.customers.Count; i++)
        {
            if (DataSource.customers[i] != null && DataSource.customers[i].id == item.id)
            {
                DataSource.customers[i] = item;
                found = true;

            }
        }
        if (!found)
            throw new InvalidOperationException("הלקוח לא נמצא לעדכון");
    }

    public void Delete(int id)
    {
        bool found = false;
        for (int i = 0; i < DataSource.customers.Count; i++)
        {
            if (DataSource.customers[i] != null && DataSource.customers[i].id == id)
            {
                DataSource.customers.Remove(DataSource.customers[i]);
                found = true;
            }
        }

        if (!found)

            throw new InvalidOperationException("הלקוח לא נמצא למחיקה");

    }
}
    

  
