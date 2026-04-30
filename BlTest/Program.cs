using BIApi;
//using DalTest;
using BO;
using BIApi;
using DO;

namespace BlTest
{
    internal class Program
    {
        static readonly IBl s_bl = BIApi.Factory.Get();

        static void Main(string[] args)
        {
            //Initialization.Initialize();

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
                            Tools.LogManager.DeleteOldFolder();
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
                        ReadProduct();
                        break;
                    case 4:
                        ReadAllProducts();
                        break;
                    case 5:
                        DeleteProduct();
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
                        ReadSale();
                        break;
                    case 4:
                        ReadAllSales();
                        break;
                    case 5:
                        DeleteSale();
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
                        ReadCustomer();
                        break;
                    case 4:
                        ReadAllCustomers();
                        break;
                    case 5:
                        DeleteCustomer();
                        break;
                }
            } while (choice != 0);
        }


        private static void AddProduct()
        {
            var p = AskProduct();
            int id = s_bl.iProduct.Create(p);
            Console.WriteLine($"Product added with id: {id}");
        }

        private static void UpdateProduct()
        {
            Console.WriteLine("Enter product id:");
            int id = int.Parse(Console.ReadLine()!);

            var existing = s_bl.iProduct.Read(id);
            if (existing == null)
            {
                Console.WriteLine("Product not found");
                return;
            }

            var p = AskProduct(id);
            s_bl.iProduct.Update(p);
            Console.WriteLine("Product updated");
        }

        private static void ReadProduct()
        {
            Console.WriteLine("Enter id:");
            int id = int.Parse(Console.ReadLine()!);
            Console.WriteLine(s_bl.iProduct.Read(id));
        }

        private static void ReadAllProducts()
        {
            foreach (var p in s_bl.iProduct.ReadAll())
                Console.WriteLine(p);
        }

        private static void DeleteProduct()
        {
            Console.WriteLine("Enter id:");
            int id = int.Parse(Console.ReadLine()!);
            s_bl.iProduct.Delete(id);
            Console.WriteLine("Product deleted");
        }


        private static void AddSale()
        {
            var s = AskSale();
            int id = s_bl.iSale.Create(s);
            Console.WriteLine($"Sale added with id: {id}");
        }

        private static void UpdateSale()
        {
            Console.WriteLine("Enter sale id:");
            int id = int.Parse(Console.ReadLine()!);

            var existing = s_bl.iSale.Read(id);
            if (existing == null)
            {
                Console.WriteLine("Sale not found");
                return;
            }

            var s = AskSale(id);
            s_bl.iSale.Update(s);
            Console.WriteLine("Sale updated");
        }

        private static void ReadSale()
        {
            Console.WriteLine("Enter id:");
            int id = int.Parse(Console.ReadLine()!);
            Console.WriteLine(s_bl.iSale.Read(id));
        }

        private static void ReadAllSales()
        {
            foreach (var s in s_bl.iSale.ReadAll())
                Console.WriteLine(s);
        }

        private static void DeleteSale()
        {
            Console.WriteLine("Enter id:");
            int id = int.Parse(Console.ReadLine()!);
            s_bl.iSale.Delete(id);
            Console.WriteLine("Sale deleted");
        }


        private static void AddCustomer()
        {
            var c = AskCustomer();
            int id = s_bl.iCustomer.Create(c);
            Console.WriteLine($"Customer added with id: {id}");
        }

        private static void UpdateCustomer()
        {
            Console.WriteLine("Enter customer id:");
            int id = int.Parse(Console.ReadLine()!);

            var existing = s_bl.iCustomer.Read(id);
            if (existing == null)
            {
                Console.WriteLine("Customer not found");
                return;
            }

            var c = AskCustomer(id);
            s_bl.iCustomer.Update(c);
            Console.WriteLine("Customer updated");
        }

        private static void ReadCustomer()
        {
            Console.WriteLine("Enter id:");
            int id = int.Parse(Console.ReadLine()!);
            Console.WriteLine(s_bl.iCustomer.Read(id));
        }

        private static void ReadAllCustomers()
        {
            foreach (var c in s_bl.iCustomer.ReadAll())
                Console.WriteLine(c);
        }

        private static void DeleteCustomer()
        {
            Console.WriteLine("Enter id:");
            int id = int.Parse(Console.ReadLine()!);
            s_bl.iCustomer.Delete(id);
            Console.WriteLine("Customer deleted");
        }


        private static BO.Product AskProduct(int id = 0)
        {
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine()!;

            Console.WriteLine("Enter category (0-3):");
            int cat = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter price:");
            double price = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter stock count:");
            int count = int.Parse(Console.ReadLine()!);

            return new BO.Product(id, name, price, count, (BL.BO.Category)(Category)cat);
        }

        private static BO.Sale AskSale(int id = 0)
        {
            Console.WriteLine("Enter product id:");
            int pid = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter count:");
            int count = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter sale price:");
            double price = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Sale for all customers? (true/false):");
            bool all = bool.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter start date:");
            DateTime start = DateTime.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter end date:");
            DateTime end = DateTime.Parse(Console.ReadLine()!);

            return new BO.Sale(id, pid, price,all, start,count, end);
        }

        private static BO.Customer AskCustomer(int id = 0)
        {
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine()!;

            Console.WriteLine("Enter address:");
            string address = Console.ReadLine()!;

            Console.WriteLine("Enter phone:");
            string phone = Console.ReadLine()!;

            return new BO.Customer(id, name ,phone,true,address);
        }


        public static int PrintMainMenu()
        {
            Console.WriteLine("Main Menu: 1-Product 2-Sale 3-Customer 4-Delete Logs 0-Exit");
            int.TryParse(Console.ReadLine(), out int choice);
            return choice;
        }

        public static int PrintSubMenu(string item)
        {
            Console.WriteLine($"{item} Menu: 1-Add 2-Update 3-Read 4-Read All 5-Delete 0-Back");
            int.TryParse(Console.ReadLine(), out int choice);
            return choice;
        }
    }
}
