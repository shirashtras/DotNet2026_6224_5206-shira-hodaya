using DalApi;
using DO;

namespace DalTest
{
    internal class Program
    {
        //private static IProduct? s_dalProduct;
        //private static ISale? s_dalSale;
        //private static ICustomer? s_dalCustomer;

        private static IDal s_dal;


        private static void Main(string[] args)
        {
            int choice;
            do
            {
                choice = PrintMainMenu();
                switch (choice)
                {
                    case 1:
                        ProductMenu();
                        break;
                    case 2:
                        //SaleMenu();
                        break;
                    case 3:
                        //CustomerMenu();
                        break;
                }
            } while (choice != 0);
        }
        //private static void SubMenu<T>(ICrud<T> crud, string title, Add add, Update update)
        //{
        //    int choice;
        //    do
        //    {
        //        choice = PrintSubMenu(title);
        //        switch (choice)
        //        {
        //            case 1:
        //                add();
        //                break;
        //            case 2:
        //                update();
        //                break;
        //            case 3:
        //                Read(crud);
        //                break;
        //            case 4:
        //                ReadAll(crud);
        //                break;
        //            case 5:
        //                Delete(crud);
        //                break;
        //        }

        //    }
        //    while (choice != 0);
        //}
        private static void ProductMenu()
        {
            //SubMenu(s_dal.Product, "Product", AddProduct, UpdateProduct);
        }
        //private static void SaleMenu()
        //{
        //    SubMenu(s_dal.Sale, "Sale", AddSale, UpdateSale);
        //}
        //private static void CustomerMenu()
        //{
        //    SubMenu(s_dal.Customer, "Customer", AddCustomer, UpdateCustomer);
        //}

        private static Product AskProduct(int id = 0)
        {
            string name;
            Category category;
            double price;
            int count;
            int cat;
            Console.WriteLine("Enter the Name of the product");
            name = Console.ReadLine();

            Console.WriteLine("Enter the category: between 0 to 3 ");
            if (!int.TryParse(Console.ReadLine(), out cat))
                category = 0;
            else
                category = (Category)cat;

            Console.WriteLine("Enter Price");
            if (!double.TryParse(Console.ReadLine(), out price))
                price = 10;

            Console.WriteLine("Enter count in stock");
            if (!int.TryParse(Console.ReadLine(), out count))
                count = 0;

            return new Product(id, name, category, price, count);


        }
        private static Sale AskSale(int id = 0)
        {
            int productId;
            int count;
            double price;
            bool isSaleToAll;
            DateTime start;
            DateTime end;

            Console.WriteLine("Enter Product id:");
            int.TryParse(Console.ReadLine(), out productId);

            Console.WriteLine("Enter count to sale:");
            int.TryParse(Console.ReadLine(), out count);

            Console.WriteLine("Enter price for sale:");
            double.TryParse(Console.ReadLine(), out price);

            Console.WriteLine("Is sale for all customers? true/false:");
            bool.TryParse(Console.ReadLine(), out isSaleToAll);

            Console.WriteLine("Enter start date:");
            DateTime.TryParse(Console.ReadLine(), out start);

            Console.WriteLine("Enter end date:");
            DateTime.TryParse(Console.ReadLine(), out end);

            return new Sale(id, productId, count, price, isSaleToAll, start, end);

        }
        private static Customer AskCustomer(int id = 0)
        {
            string customerName, address, phoneNumber;

            Console.WriteLine("Enter customer name:");
            customerName = Console.ReadLine();

            Console.WriteLine("Enter address of customer :");
            address = Console.ReadLine();

            Console.WriteLine("Enter phone of customer :");

            phoneNumber = Console.ReadLine();


            return new Customer(id, customerName, address, phoneNumber);
        }
        private static void AddProduct()
        {
            Product product = AskProduct();
            int id = s_dal.Product!.Create(product);
            Console.WriteLine("Product add with id:" + id);
        }
        private static void AddSale()
        {
            Sale sale = AskSale();
            int id = s_dal.Sale!.Create(sale);
            Console.WriteLine("Sale add with id:" + id);
        }
        private static void AddCustomer()
        {
            Customer customer = AskCustomer();
            int id = s_dal.Customer!.Create(customer);
            Console.WriteLine("Customer add with id:" + id);
        }
        private static void UpdateProduct()
        {
            int id;
            Console.WriteLine("Enter product id to update:");
            int.TryParse(Console.ReadLine(), out id);
            Product product = AskProduct(id);
            s_dal.Product!.Update(product);
            Console.WriteLine("Product update");

        }
        private static void UpdateSale()
        {
            int id;
            Console.WriteLine("Enter sale id to update:");
            int.TryParse(Console.ReadLine(), out id);
            Sale sale = AskSale(id);
            s_dal.Sale!.Update(sale);
            Console.WriteLine("Sale update");
        }
        private static void UpdateCustomer()
        {
            int id;
            Console.WriteLine("Enter customer id to update");
            int.TryParse(Console.ReadLine(), out id);
            Customer customer = AskCustomer(id);
            s_dal.Customer!.Update(customer);
            Console.WriteLine("Customer update");
        }
        private static void ReadAll<T>(List<T> list)
        {
            foreach (T item in list)
                Console.WriteLine(item);
        }
        private static void ReadAll<T>(ICrud<T> icrud)
        {
            foreach (T item in icrud.ReadAll())
                Console.WriteLine(item);
        }
        private static void Read<T>(ICrud<T> crud)
        {
            try
            {
                Console.WriteLine("Enter id:");
                int id = int.Parse(Console.ReadLine()!);
                Console.WriteLine(crud.Read(id));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        private static void Delete<T>(ICrud<T> crud)
        {
            try
            {
                Console.WriteLine("Enter id:");
                int id = int.Parse(Console.ReadLine()!);
                crud.Delete(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static int PrintMainMenu()
        {
            int choice;
            Console.WriteLine("Main Menu: 1 - Product 2 - Sales 3 - Customers 0 - Exit");
            int.TryParse(Console.ReadLine(), out choice);
            return choice;
        }
        public static int PrintSubMenu(string item)
        {
            int choice;
            Console.WriteLine($"{item} Menu: 1 - Add 2 - Update 3 - Read 4- Read All 5 - Delete 0 - Back");
            int.TryParse(Console.ReadLine(), out choice);
            return choice;
        }
    }
}

