using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinansDemo
{
    internal class Customer
    {
        public string name { get; set; }
        private string CustomerId { get; set; }
        public ID ıd {  get; set; }
        public Address Address;
        public List<Loan> LoanList;
        public Customer(string name,string CustomerId,ID ıd,Address Address)

        {
            this.name = name;
            this.CustomerId = CustomerId;
            this.ıd = ıd;
            this.Address = Address;
            this.LoanList = new  List<Loan>();
        }
        public string getCustomerId()
        {
            return this.CustomerId;
        }
        public void setCustomerId(string CustomerId)
        {
            this.CustomerId = CustomerId;
        }
       
       
      




    }


}
