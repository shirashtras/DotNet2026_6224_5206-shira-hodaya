
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIApi
{
    public interface IBl
    {
        private ICustomer icustomer { get { return icustomer; }  }
        private IProduct iproduct { get { return iproduct; } }

        private ISale isale { get { return isale; } }
        private IOrder iorder { get { return iorder; } }


    }
}
