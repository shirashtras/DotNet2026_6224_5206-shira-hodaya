using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BO
{
    internal class SaleInProduct
    {
        public int idSaleInProduct { get; set; }
        public int amountSaleInProduct { get; set; }
        public double priceSaleInProduct { get; set; }
        public bool isSaleInProductSpecialToAll { get; set; }
    }
}
