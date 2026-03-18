using DalApi;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    internal sealed class DalXml:IDal
    {
        public ICustomer Customer => new CustomerImplementation();
        public IProduct Product => new ProductImplementation();
        public ISale Sale => new SaleImplementation();

        private DalXml()
        {
        }
        private readonly DalXml instance = new DalXml();

        public DalXml Instance { get { return instance; } }
    }
}
