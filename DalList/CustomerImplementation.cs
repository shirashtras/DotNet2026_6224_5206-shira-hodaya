using DalFacade.DO;
using DalFacade.DalApi;
namespace DalList;


internal class CustomerImplementation : ICustomer
{
    public int Create(Customer item)
    {
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
        Customer customer = item;
        foreach (Customer cus in DataSource.customers)
        {
            if (cus.id == item.id)
                DataSource.customers.Remove(cus);

        }
        DataSource.customers.Add(customer);
    }

    public void Delete(int id)
    {
        foreach (Customer cus in DataSource.customers)
        {
            if (cus.id == id)
                DataSource.customers.Remove(cus);
        }
    }
}
