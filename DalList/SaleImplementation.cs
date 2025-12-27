using DO;
using DalApi;
namespace DalList;

internal class SaleImplementation : ISale
{
    private int? idProduct;

    public int Create(Sale item)
    {
        for (int i = 0; i < DataSource.sales.Count; i++)
        {
            if (DataSource.sales[i] != null && DataSource.sales[i].idProduct == item.idProduct)
            {
                throw new InvalidOperationException("המבצע כבר קיים ברשימת המבצעים");
            }
        }
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
        bool found = false;
        for (int i = 0; i < DataSource.sales.Count; i++)
        {
            if (DataSource.sales[i] != null && DataSource.sales[i].idProduct == item.idProduct)
            {
                DataSource.sales[i] = item;
                found = true;
            }
           
        }
        if (!found)
            throw new InvalidOperationException("המבצע לא נמצא לעדכון");
    }

    public void Delete(int id)
    {
        bool found = false;
        for (int i = 0; i < DataSource.sales.Count; i++)
        {
            if (DataSource.sales[i] != null && DataSource.sales[i]!.id == id)
            {
                DataSource.sales.Remove(DataSource.sales[i]);
                found = true;
            }
        }
        if (!found)

            throw new InvalidOperationException("המבצע לא נמצא למחיקה");

    }

}