using DO;
using DalApi;
namespace DalList;


internal class CustomerImplementation : ICustomer
{
    public int Create(Customer item)
    {
        int newId = DataSource.Config.productNext;
        for (int i = 0; i < DataSource.customers.Count; i++)
        {
            if (DataSource.customers[i] != null && DataSource.customers[i]!.id == item.id)
            {
                throw new Exception("This customer exists in the customers list");
            }
        }

        Customer newCustomer = item with { id = newId };
        DataSource.customers.Add(newCustomer);
        return newId;
    }

    public Customer? Read(int id)
    {
        foreach (Customer? customer in DataSource.customers)
        {
            if (customer != null && customer!.id == id)
                return customer;
        }
        return null;
    }


    public List<Customer?> ReadAll()
    {
        return DataSource.customers!;
    }

    public void Update(Customer item)
    {
        bool found = false;
        for (int i = 0; i < DataSource.customers.Count; i++)
        {
            if (DataSource.customers[i] != null && DataSource.customers[i]!.id == item.id)
            {
                DataSource.customers[i] = item;
                found = true;
                break;

            }
        }
        if (!found)
            throw new Exception("This customer is not exists in the customers list");
    }

    public void Delete(int id)
    {
        bool found = false;
        for (int i = 0; i < DataSource.customers.Count; i++)
        {
            if (DataSource.customers[i] != null && DataSource.customers[i]!.id == id)
            {
                DataSource.customers.RemoveAt(i);
                found = true;
                break;

            }
        }

        if (!found)

            throw new Exception("The customer is not exist to delete");

    }
}
    

  
