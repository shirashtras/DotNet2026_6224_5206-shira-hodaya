using DO;
using DalApi;
namespace DalList;

internal class ProductImplementation : IProduct
{
    public int Create(Product item)
    {
        int newId = DataSource.Config.productNext;
        for (int i = 0; i < DataSource.products.Count; i++)
        {
            if (DataSource.products[i] != null && DataSource.products[i]!.id == item.id)
            {
                throw new Exception("The product exists in the list");
            }
        }
        Product newProduct = item with { id = newId };
        DataSource.products.Add(newProduct);
        return newId;
            
    }

    //public int Create(Product item)
    //{
    //    if (item.id != 0)
    //    {
    //        for (int i = 0; i < DataSource.products.Count; i++)
    //        {
    //            if (DataSource.products[i] != null &&
    //                DataSource.products[i]!.id == item.id)
    //            {
    //                throw new Exception("Product already exists");
    //            }
    //        }
    //    }

    //    int newId = DataSource.s_nextProductId++;

    //    Product newProduct = item with { id = newId };

    //    DataSource.products.Add(newProduct);

    //    return newId;
    //}

    public Product? Read(int id)
    {
        foreach (Product? pr in DataSource.products)
        {
            if (pr?.id == id)
                return pr;
        }
        return null;
    }

    public List<Product?> ReadAll()
    {
        return DataSource.products!;
    }

    public void Update(Product item)
    {
        bool found = false;
        for (int i = 0; i < DataSource.products.Count; i++)
        {
            if (DataSource.products[i] != null && DataSource.products[i]!.id == item.id)
            {
                DataSource.products[i] = item;
                found = true;
                break;

            }
        }
        if (!found)
            throw new Exception("The product isn't found to update");
    }
    public void Delete(int id)
    {
        bool found = false;
        for (int i = 0; i < DataSource.products.Count; i++)
        {
            if (DataSource.products[i] != null && DataSource.products[i]!.id == id)
            {
                DataSource.products.RemoveAt(i);
                found = true;
                break;
            }
        }

        if (!found)

            throw new Exception("The product isn't found to delete");

    }

}
