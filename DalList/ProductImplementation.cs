using DalFacade.DO;
using DalFacade.DalApi;

namespace DalList;

internal class ProductImplementation:IProduct
{
    public int Create(Product item)
    {
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
        Product product = item;
        foreach (Product pr in DataSource.products)
        {
            if (pr.id == item.id)
                DataSource.products.Remove(pr);

        }
        DataSource.products.Add(product);
    }

    public void Delete(int id)
    {
        foreach (Product pr in DataSource.products)
        {
            if (pr.id == id)
                DataSource.products.Remove(pr);
        }
    }
}
