using DalApi;
using DO;
using Tools;

namespace DalTest
{
    internal class Program
    {
      
        static IDal s_dal =DalApi.Factory.Get;

        static ICustomer dalCustomer = s_dal.Customer;
        static IProduct dalProduct = s_dal.Product;
        static ISale dalSale = s_dal.Sale;
        private static void Main(string[] args)
        {
            Initialization.Initialize();
            int choice;
            try
            {
                while ((choice = PrintMainMenu()) != 0)
                {
                    switch (choice)
                    {
                        case 1:
                            ProductMenu();
                            break;
                        case 2:
                            SaleMenu();
                            break;
                        case 3:
                            CustomerMenu();
                            break;
                        case 4:
<<<<<<< HEAD
                            LogManager.DeleteOldFolder();

=======
                            LogManager.DeleteLastTwoMonthsFolders();
>>>>>>> 0f768fb0cac83c82a0547067e934e76c3ec5f9fe
                            break;
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void ProductMenu()
        {
            int choice;
            do
            {
                choice = PrintSubMenu("Product");
                switch (choice)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        UpdateProduct();
                        break;
                    case 3:
                        Read(s_dal.Product!);
                        break;
                    case 4:
                        ReadAll(s_dal.Product!);
                        break;
                    case 5:
                        Delete(s_dal.Product!);
                        break;
                }
            } while (choice != 0);
        }

        private static void SaleMenu()
        {
            int choice;

            do
            {
                choice = PrintSubMenu("Sale");
                switch (choice)
                {
                    case 1:
                        AddSale();
                        break;
                    case 2:
                        UpdateSale();
                        break;
                    case 3:
                        Read(s_dal.Sale!);
                        break;
                    case 4:
                        ReadAll(s_dal.Sale!);
                        break;
                    case 5:
                        Delete(s_dal.Sale!);
                        break;
                }
            } while (choice != 0);
        }
        private static void CustomerMenu()
        {
            int choice;
            do
            {
                choice = PrintSubMenu("Customer");
                switch (choice)
                {
                    case 1:
                        AddCustomer();
                        break;
                    case 2:
                        UpdateCustomer();
                        break;
                    case 3:
                        Read(s_dal.Customer!);
                        break;
                    case 4:
                        ReadAll(s_dal.Customer!);
                        break;
                    case 5:
                        Delete(s_dal.Customer!);
                        break;
                }
            } while (choice != 0);
        }



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
                price = 0;

            Console.WriteLine("Enter count in stock");
            if (!int.TryParse(Console.ReadLine(), out count))
                count = 0;

            return new Product(id, name, category, price, count);

        }
        private static Sale AskSale(int id = 0)
        {
            int idSale;
            int count;
            double price;
            bool isSaleToAll;
            DateTime start;
            DateTime end;

            Console.WriteLine("Enter Product id:");
            int.TryParse(Console.ReadLine(), out idSale);

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

            return new Sale(id, idSale, count, price, isSaleToAll, start, end);

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
            product = product with { id = id };
            Console.WriteLine("Product add with id:" + id);
        }
        private static void AddSale()
        {
            Sale sale = AskSale();
            int id = s_dal.Sale!.Create(sale);
            sale = sale with { id = id };
            Console.WriteLine("Sale add with id:" + id);
        }
        private static void AddCustomer()
        {
            Customer customer = AskCustomer();
            int id = s_dal.Customer!.Create(customer);
            customer = customer with { id = id };
            Console.WriteLine("Customer add with id:" + id);
        }
        private static void UpdateProduct()
        {
            int id;
            Console.WriteLine("Enter product id to update:");
            if (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid id");
                return;
            }
            Product? existingProduct = s_dal.Product!.Read(id);
            if (existingProduct == null)
            {
                Console.WriteLine("The Product isn't exist to update");
                return;
            }

            Product product = AskProduct(id);
            s_dal.Product!.Update(product);
            Console.WriteLine("Product update");

        }
        private static void UpdateSale()
        {
            int id;
            Console.WriteLine("Enter sale id to update:");

            if (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid id");
                return;
            }
            Sale? existingSale = s_dal.Sale!.Read(id);
            if (existingSale == null)
            {
                Console.WriteLine("The sale isn't exist to update");
                return;
            }


            Sale sale = AskSale(id);
            s_dal.Sale!.Update(sale);
            Console.WriteLine("Sale update");
        }

        private static void UpdateCustomer()
        {
            int id;
            Console.WriteLine("Enter customer id to update");

            if (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid id");
                return;
            }
            Customer? existingCustomer = s_dal.Customer!.Read(id);
            if (existingCustomer == null)
            {
                Console.WriteLine("The Customer isn't exist to update");
                return;
            }

            Customer customer = AskCustomer(id);
            s_dal.Customer!.Update(customer);
            Console.WriteLine("Customer update");
        }

        private static void ReadAll<T>(ICrud<T> icrud)
        {
            foreach (T item in icrud.ReadAll())
                if (item != null)
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
            Console.WriteLine("Main Menu: 1 - Product 2 - Sales 3 - Customers 4-Delete folders 0 - Exit");
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

