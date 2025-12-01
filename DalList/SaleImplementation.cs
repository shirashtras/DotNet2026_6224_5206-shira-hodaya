using DalFacade.DO;
using DalFacade.DalApi;

namespace DalList;

internal class SaleImplementation : ISale
{

    public int Create(Sale item)
    {
        DataSource.sales.Add(item);
        return item.id;
    }

    public Sale? Read(int id)
    {
        foreach (Sale sl in DataSource.sales)
        {
            if (sl.id == id)
                return sl;
        }
        return null;
    }

    public List<Sale> ReadAll()
    {
        return DataSource.sales == null ? null : DataSource.sales;
    }

    public void Update(Sale item)
    {
        Sale sale = item;
        foreach (Sale sl in DataSource.sales)
        {
            if (sl.id == item.id)
                DataSource.sales.Remove(sl);

        }
        DataSource.sales.Add(sale);
    }

    public void Delete(int id)
    {
        foreach (Sale sl in DataSource.sales)
        {
            if (sl.id == id)
                DataSource.sales.Remove(sl);
        }
    }
}
