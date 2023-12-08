using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinansDemo
{
    internal class Customer
    {
        public string name;
        private string customerId;
        public ID ıd;
        public Address Address;
        //public Interest Interest;
        public Customer(string name,string _customerId,ID ıd,Address Address)

        {
            this.name = name;
            this.customerId = _customerId;
            this.ıd = ıd;
            this.Address = Address;
            //this.Interest = interest;
        }
        public string getCustomerId()
        {
            return this.customerId;
        }
        public void setCustomerId(string customerId)
        {
            this.customerId = customerId;
        }
        
        
            
        

    }
    
    
}
