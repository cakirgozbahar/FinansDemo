using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FinansDemo
{
    internal class Bank
    {
        public List<Customer> customers {get; set;}

        public Bank()
        {
            customers = new List<Customer>();
        }

        public void insertCustomer(Customer cs)
        {
            this.customers.Add(cs);
        }
        public void deleteCustomer(int index) 
        { 
            this.customers.RemoveAt(index);
        }
        public void addLoanToCustomer(Loan loan, int number)
        {
            foreach (Customer cs in this.customers)
            {
                if (number == Convert.ToInt32(cs.getCustomerId()))
                {
                    cs.addLoan(loan);
                    break;
                }
            }
        }

        public List<string> listCustomer()
        {
            List<string> names = new List<string>();

            foreach (Customer cs in customers)
            {
                names.Add(cs.name);
            }

            return names;
        }
    }
}
