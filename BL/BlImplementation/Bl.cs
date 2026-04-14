using BIApi;
using BlImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    internal class Bl: IBl
    {
        public IProduct iProduct => new ProductImplementation();
        public ICustomer iCustomer => new CustomerImplementation();
        public ISale iSale => new SaleImplementation();

    }
}
