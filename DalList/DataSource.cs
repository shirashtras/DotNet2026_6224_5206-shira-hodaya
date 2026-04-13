
using DO;
using System.Xml.Linq;
namespace DalList;

internal static class DataSource
{
    internal static List<Product?> products = new List<Product?>();
    internal static List<Sale?> sales = new List<Sale?>();
    internal static List<Customer?> customers = new List<Customer?>();


    internal static class Config
    {
        const string path = @"xml\data-config.xml";
        const string PRODUCTID = "productId";
        const string SALEID = "saleId";
        static XElement dataConfigXml = XElement.Load(path);
        private static int ProductId = int.Parse(dataConfigXml.Element(PRODUCTID).Value);
        private static int SaleId = int.Parse(dataConfigXml.Element(SALEID).Value);



        public static int GetProductId
        {
            get
            {
                ProductId++;
                dataConfigXml.Element(PRODUCTID).SetValue(ProductId.ToString());
                dataConfigXml.Save(path);
                return ProductId;

            }
        }

<<<<<<< HEAD

=======
  
>>>>>>> 0f768fb0cac83c82a0547067e934e76c3ec5f9fe
        public static int getSaleId
        {
            get
            {
                SaleId++;
                dataConfigXml.Element(SALEID).SetValue(SaleId.ToString());
                dataConfigXml.Save(path);
<<<<<<< HEAD
                return SaleId;
=======
                return SaleId;  
>>>>>>> 0f768fb0cac83c82a0547067e934e76c3ec5f9fe
            }
        }


    }

}