﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinansDemo
{
    internal class Bank
    {
        public List<Customer> customers { get; set; }

        public Bank()
        {
            customers = new List<Customer>();
        }
        public DataSet makeDBOperations(string query)
        {
            DataSet dataSet = null;
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Şeyda\source\repos\FinansDemo\database.mdf;Integrated Security=True");
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);

                connection.Open();

                dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "Table");
                connection.Close();
            }
            catch
            {
                dataSet = null;
            }

            return dataSet;
        }

        public bool addCustomer(Customer cs,ID id, Address ads)
        {

            DataSet ds = makeDBOperations("insert into CustomerTable(CustomerId, Name, ID_number, Address) values('" + cs.getCustomerId() + "', '" + cs.name + "','" + id.getID() + "', '" + ads.getText()  + "')");

            if (ds != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool deleteCustomer(string idnumber)
        {
            DataSet ds = makeDBOperations("delete from CustomerTable where CustomerId = '" + idnumber + "'");

            if (ds != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataSet getAllCustomers()
        {
            return makeDBOperations("select * from CustomerTable");
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
