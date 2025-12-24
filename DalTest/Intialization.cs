using DO;
using  DalApi;
namespace DalTest;


public static class Intialization
{
    //private static IProduct s_dalProduct;
    //private static ISale s_dalSale;
    //private static ICustomer s_dalCustomer;
    private static IDal s_dal;


    public static void CreateCustomers()
    {
        s_dal.Customer.Create(new Customer(1, "CustomerA", "Jerusalem", "0589930282"));
        s_dal.Customer.Create(new Customer(2, "CustomerB", "BB", "0528693541"));
        s_dal.Customer.Create(new Customer(3, "CustomerC", "Modiin Ilit", "0547896321"));
        s_dal.Customer.Create(new Customer(4, "CustomerD", "Haifa", "054782136"));
        s_dal.Customer.Create(new Customer(5, "CustomerE", "Elad", "0531248796"));
        s_dal.Customer.Create(new Customer(6, "CustomerF", "Petah Tikva", "0542314594"));
        s_dal.Customer.Create(new Customer(7, "CustomerG", "Ashkelon", "0586352149"));
    }
    public static void CreateSales()
    {
        s_dal.Sale.Create(new Sale(1, 111, 3, 20, true, DateTime.Now, DateTime.Now.AddMonths(2)));
        s_dal.Sale.Create(new Sale(2, 222, 4, 10, false, DateTime.Now, DateTime.Now.AddMonths(3)));
        s_dal.Sale.Create(new Sale(3, 333, 2, 50, true, DateTime.Now, DateTime.Now.AddDays(12)));
        s_dal.Sale.Create(new Sale(4, 444, 3, 30, false, DateTime.Now, DateTime.Now.AddYears(1)));
        s_dal.Sale.Create(new Sale(5, 555, 5, 100, false, DateTime.Now, DateTime.Now.AddMonths(4)));
        s_dal.Sale.Create(new Sale(6, 666, 2, 40, true, DateTime.Now, DateTime.Now.AddDays(40)));
        s_dal.Sale.Create(new Sale(7, 777, 5, 60, false, DateTime.Now, DateTime.Now.AddMonths(6)));

    }
    public static void createProducts()
    {
        s_dal.Product.Create(new Product(11, "Water", Category.SoftDrinks, 7, 50));
        s_dal.Product.Create(new Product(22, "Cola", Category.SoftDrinks, 6, 40));
        s_dal.Product.Create(new Product(33, "Chocolate Cake", Category.Cakes, 20, 100));
        s_dal.Product.Create(new Product(44, "Hot Coffee", Category.HotDrinks, 12, 50));
        s_dal.Product.Create(new Product(55, "Hot Chocolate", Category.HotDrinks, 10, 500));
        s_dal.Product.Create(new Product(66, "American IceCream", Category.IceCream, 6, 90));
        s_dal.Product.Create(new Product(77, "Borax", Category.Pastries, 4, 80));
    }

    //public static void Intialize(IProduct productDal, ICustomer customerDal, ISale saleDal)
    //{
    //    CreateCustomers();
    //    CreateSales();
    //    createProducts();
    //    s_dalProduct = productDal;
    //    s_dalCustomer = customerDal;
    //    s_dalSale = saleDal;
    //}
    public static void Intialize(IDal idal)
    {
        CreateCustomers();
        CreateSales();
        createProducts();
        s_dal=idal;
    }

}