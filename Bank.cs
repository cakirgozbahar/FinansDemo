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
        public List<Customer> customers;

        public Bank()
        {
            customers = new List<Customer>();
        }

        public void insertCustomer(Customer cs)
        {
            customers.Add(cs);
        }
        public string searchCustomer(string name)
        {
            string address = "";

            for (int i = 0; i < customers.Count; i++)
            {
                if (name == customers[i].name)
                {
                    address = customers[i].Address.getText();
                    break;
                }
            }

            return address;
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
