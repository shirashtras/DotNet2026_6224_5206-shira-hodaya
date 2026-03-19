using DalApi;
using DO;
using System.Reflection;
using System.Xml.Linq;
using Tools;



namespace Dal
{
    internal class SaleImplementation : ISale
    {
        const string ID = "id";
        const string IDSALE = "idSale";
        const string COUNT = "count";
        const string PRICE = "price";
        const string ISSALETOALL = "isSaleToAll";
        const string STARTDATE = "startDate";
        const string ENDDATE = "endDate";

        const string SALE = "Sale";
        
        const string path = @"..\sales.xml";
        XElement sales;
        private XElement LoadXElement()
        {
            XElement saleXml = XElement.Load(path);
            return saleXml;
        }

        public Sale? Read(Func<Sale, bool>? filter)
        {
            sales = LoadXElement();
            LogManager.writeToLog("start read sale by filter", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            var q = (from s in sales.Elements(SALE)
                     select new Sale()
                     {
                         id = (int)s.Element(ID),
                         idSale = (int)s.Element(IDSALE),
                         price = (double)s.Element(PRICE),
                         count = (int)s.Element(COUNT),
                         isSaleToAll = (bool)s.Element(ISSALETOALL),
                         startDate = (DateTime)s.Element(STARTDATE),
                         endDate = (DateTime)s.Element(ENDDATE)
                     }).ToList();
            if (filter != null)
            {
                LogManager.writeToLog("finish read sale by filter", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
                return q.FirstOrDefault(s => filter(s));
            }
            LogManager.writeToLog("לא נמצא מבצע שעונה על תנאי זה", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            throw new DalFilterNotExists("לא נמצא מבצע שעונה על תנאי זה");
        }
        public int Create(Sale item)
        {
            sales = LoadXElement();
            LogManager.writeToLog("start to create sale", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

            int newId = Config.GetSaleId;
            Sale newSale = item with { id = newId };
            sales.Add(new XElement
                (SALE,
                new XElement(ID, newSale.id),
                new XElement(IDSALE, newSale.idSale),
                new XElement(PRICE, newSale.price),
                new XElement(COUNT, newSale.count),
                new XElement(ISSALETOALL, newSale.isSaleToAll),
                new XElement(STARTDATE, newSale.startDate),
                new XElement(ENDDATE, newSale.endDate)));
            sales.Save(path);
            LogManager.writeToLog("finish to create sale", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            return newSale.id;
        }


        public void Delete(int id)
        {
            sales = LoadXElement();
            LogManager.writeToLog("start to delete sale by id", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            var q = (from s in sales.Elements(SALE)
                     where int.Parse(s.Element(ID).Value) == id
                     select s).FirstOrDefault();
            if (q != null)
            {
                LogManager.writeToLog("finish to delete sale by id", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
                q.Remove();
                sales.Save(path);
            }
            else
            {
                LogManager.writeToLog("לא נמצא מבצע עם קוד זה", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

                throw new DalIdNotExists("לא נמצא מבצע עם קוד זה");
            }
        }

        public Sale? Read(int id)
        {
            sales = LoadXElement();
            LogManager.writeToLog("start to read sale by id", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            var q = (from s in sales.Elements(SALE)
                     where int.Parse(s.Element(ID).Value) == id
                     select s).FirstOrDefault();
            if (q != null)
            {
                LogManager.writeToLog("finish to read sale by id", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
                return new Sale()
                {
                    id = (int)q.Element(ID),
                    idSale = (int)q.Element(IDSALE),
                    price = (double)q.Element(PRICE),
                    count = (int)q.Element(COUNT),
                    isSaleToAll = (bool)q.Element(ISSALETOALL),
                    startDate = (DateTime)q.Element(STARTDATE),
                    endDate = (DateTime)q.Element(ENDDATE)
                };
            }
            LogManager.writeToLog("לא נמצא מבצע עם קוד זה", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

            throw new DalIdNotExists("לא נמצא מבצע עם קוד זה");
        }
        public List<Sale?> ReadAll(Func<Sale, bool>? filter)
        {
            sales = LoadXElement();
            LogManager.writeToLog("start to read all sale/by id", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
            var sa = (from s in sales.Elements(SALE)
                      select new Sale()
                      {
                          id = (int)s.Element(ID),
                          idSale = (int)s.Element(IDSALE),
                          price = (double)s.Element(PRICE),
                          count = (int)s.Element(COUNT),
                          isSaleToAll = (bool)s.Element(ISSALETOALL),
                          startDate = (DateTime)s.Element(STARTDATE),
                          endDate = (DateTime)s.Element(ENDDATE)

                      }).ToList();
            if (filter == null)
            {
                LogManager.writeToLog("finish to read all sale", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
                return sa;
            }
            else
            {
                LogManager.writeToLog("finish to read sale by filter", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
                return sa.Where(s => filter(s)).ToList();
            }
        }

        public void Update(Sale item)
        {
            LogManager.writeToLog("start to upadate sale", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

            Delete(item.id);
            Create(item);
            LogManager.writeToLog("finish to update sale", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

        }

    }
}
