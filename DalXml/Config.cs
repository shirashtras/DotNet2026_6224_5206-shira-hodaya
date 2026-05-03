using System.Xml.Linq;
using System.IO;

internal static class Config
{
    static readonly string path =
        Path.Combine(AppContext.BaseDirectory, "xml", "data-config.xml");

    const string PRODUCTID = "ProductNum";
    const string IDSALE = "SaleNum";

    static XElement dataConfigXml = Initialize();

    private static XElement Initialize()
    {
        var dir = Path.GetDirectoryName(path) ?? Path.Combine(AppContext.BaseDirectory, "xml");
        if (!Directory.Exists(dir))
            Directory.CreateDirectory(dir);

        if (!File.Exists(path))
        {
            var defaultXml = new XElement("config",
                new XElement(PRODUCTID, "1039"), 
                new XElement(IDSALE, "2000")
            );

            defaultXml.Save(path);
            return defaultXml;
        }

        XElement loaded;
        try
        {
            loaded = XElement.Load(path);
        }
        catch
        {
            var fallback = new XElement("config",
                new XElement(PRODUCTID, "1039"),
                new XElement(IDSALE, "2000")
            );
            fallback.Save(path);
            return fallback;
        }

        bool changed = false;
        if (loaded.Element(PRODUCTID) == null)
        {
            loaded.Add(new XElement(PRODUCTID, "1039"));
            changed = true;
        }
        if (loaded.Element(IDSALE) == null)
        {
            loaded.Add(new XElement(IDSALE, "2000"));
            changed = true;
        }
        if (changed) loaded.Save(path);

        return loaded;
    }

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