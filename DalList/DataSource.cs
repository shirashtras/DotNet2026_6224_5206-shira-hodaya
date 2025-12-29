
using DO;
namespace DalList;

internal static class DataSource
{
    internal static List<Product?> products = new List<Product?>();
    internal static List<Sale?> sales = new List<Sale?>();
    internal static List<Customer?> customers = new List<Customer?>();


    internal static class Config
    {
        internal const int productId = 2000;
        private static int ProductId = productId;
        public static int productNext
        {
            get { return ProductId++; }
        }

        internal const int saleId = 1000;
        private static int SaleId = saleId;
        public static int saleNext
        {
            get { return SaleId++; }
        }

        internal const int customerId = 3000;
        private static int CustomerId = customerId;
        public static int customerNext
        {
            get { return CustomerId++; }
        }

    }

}

