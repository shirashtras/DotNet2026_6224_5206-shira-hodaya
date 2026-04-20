
using Dal;
using DalApi;

namespace DalList
{

    internal sealed class DalList : IDal
    {

        public ICustomer Customer => new CustomerImplementation();
        public IProduct Product => new ProductImplementation();
        public ISale Sale => new SaleImplementation();
        private DalList()
        {

        }
        private readonly DalList instance = new DalList();

        public DalList Instance { get { return instance; } }

    }

}