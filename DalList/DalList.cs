
using DalApi;

namespace DalList
{
    
    public class DalList : IDal
    {
        
        public ICustomer Customer => new CustomerImplementation();
        public IProduct Product => new ProductImplementation();
        public ISale Sale => new SaleImplementation();
    }

}
