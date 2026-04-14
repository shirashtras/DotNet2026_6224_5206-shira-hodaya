
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BIApi
    {
        public interface IBl
        {
            IProduct iProduct { get; }
            ICustomer iCustomer { get; }
            ISale iSale { get; }
            IOrder iOrder { get; }
        }
    }



