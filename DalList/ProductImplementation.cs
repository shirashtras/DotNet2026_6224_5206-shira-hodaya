using DO;
using DalApi;
namespace DalList;

internal class ProductImplementation : IProduct
{
    public int Create(Product item)
    {
        for (int i = 0; i < DataSource.products.Count; i++)
        {
            if (DataSource.products[i] != null && DataSource.products[i]!.id == item.id)
            {
                throw new InvalidOperationException("המוצר כבר קיים ברשימה");
            }
        }

        DataSource.products.Add(item);
        return item.id;
    }


    public Product? Read(int id)
    {
        foreach (Product pr in DataSource.products)
        {
            if (pr.id == id)
                return pr;
        }
        return null;
    }

    public List<Product> ReadAll()
    {
        return DataSource.products == null ? null : DataSource.products;
    }

    public void Update(Product item)
    {
        bool found = false;
        for (int i = 0; i < DataSource.products.Count; i++)
        {
            if (DataSource.products[i] != null && DataSource.products[i].id == item.id)
            {
                DataSource.products[i] = item;
                found = true;

            }
        }
        if (!found)
            throw new InvalidOperationException("המוצר לא נמצא לעדכון");
    }
    public void Delete(int id)
    {
        bool found = false;
        for (int i = 0; i < DataSource.products.Count; i++)
        {
            if (DataSource.products[i] != null && DataSource.products[i].id == id)
            {
                DataSource.products.Remove(DataSource.products[i]);
                found = true;
            }
        }

        if (!found)

            throw new InvalidOperationException("המוצר לא נמצא למחיקה");

    }

}
