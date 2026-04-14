using System.Xml.Linq;
using System.IO;
internal static class Config
{


    static readonly string path =
        Path.Combine(AppContext.BaseDirectory, "xml", "data-config.xml");

    const string PRODUCTID = "ProductNum";
    const string IDSALE = "idSale";

    static XElement dataConfigXml = XElement.Load(path);

    private static int ProductId = int.Parse(dataConfigXml.Element(PRODUCTID).Value);
    private static int SaleId = int.Parse(dataConfigXml.Element(IDSALE).Value);

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

    public static int GetSaleId
    {
        get
        {
            SaleId++;
            dataConfigXml.Element(IDSALE).SetValue(SaleId.ToString());
            dataConfigXml.Save(path);
            return SaleId;
        }
    }
}