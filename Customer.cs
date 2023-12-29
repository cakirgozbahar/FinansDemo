using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinansDemo
{
    internal class Customer
    {
        public string name { get; set; }
        private string customerId { get; set; }
        public ID ıd {  get; set; }
        public Address Address;
        public List<Loan> LoanList;
        public Customer(string name,string customerId,ID ıd,Address Address)

        {
            this.name = name;
            this.customerId = customerId;
            this.ıd = ıd;
            this.Address = Address;
            this.LoanList = new  List<Loan>();
        }
        public string getCustomerId()
        {
            return this.customerId;
        }
        public void setCustomerId(string customerId)
        {
            this.customerId = customerId;
        }
        public void addLoan(Loan loan)
        {
            this.LoanList.Add(loan);
        }
       
      




    }


}
