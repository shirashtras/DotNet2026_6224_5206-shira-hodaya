using DO;
using DalApi;
namespace DalList;

internal class SaleImplementation : ISale
{
    public int Create(Sale item)
    {
        int newId = DataSource.Config.saleNext;
        foreach (Sale? sale in DataSource.sales)
        {
            if (sale != null && sale.id == newId)
                throw new Exception("Sale with this id already exists");
        }

        Sale newSale = item with { id = newId };
        DataSource.sales.Add(newSale);
        return newId;
    }


    public Sale? Read(int id)
    {
        foreach (Sale? sl in DataSource.sales)
        {
            if (sl?.id == id)
                return sl;
        }
        return null;
    }

    public List<Sale?> ReadAll()
    {
        return DataSource.sales!;
    }

    public void Update(Sale item)
    {
        bool found = false;
        for (int i = 0; i < DataSource.sales.Count; i++)
        {
            if (DataSource.sales[i] != null && DataSource.sales[i]!.id == item.id)
            {
                DataSource.sales[i] = item;
                found = true;
                break;
            }

        }
        if (!found)
            throw new Exception("The sale isn't exist to update");

    }


    public void Delete(int id)
    {
        bool found = false;
        for (int i = 0; i < DataSource.sales.Count; i++)
        {
            if (DataSource.sales[i] != null && DataSource.sales[i]!.id == id)
            {
                DataSource.sales.RemoveAt(i);
                found = true;
                break;

            }
        }
        if (!found)

            throw new Exception("The id sale isn't fount to delete");

    }

}