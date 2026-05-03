using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Customer
    {
        public int Customer_Id { get; set; }
        public string Customer_Name { get; set; }
        public string Customer_Phone { get; set; }

        public string? Customer_Address { get; set; }

        public Customer(int Customer_Id, string Customer_Name, string Customer_Phone, bool isClub, string? Customer_Address)
        {
            this.Customer_Id = Customer_Id;
            this.Customer_Name = Customer_Name;
            this.Customer_Phone = Customer_Phone;
            this.Customer_Address = Customer_Address;
        }
        public Customer()
        {

        }

        public override string ToString() => this.ToStringProperty();
    }
}