using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;
using System.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.CodeDom;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FinansDemo
{
    public partial class Form1 : Form
    {
        private Form parent;
        Bank bnk;
        public Form1(Form parent)
        {
            bnk = new Bank();
            this.parent = parent;
            InitializeComponent();
        }



        private void btncreate_Click_1(object sender, EventArgs e)
        {
            Address address = new Address(txtAddress.Text);
            ID id = new ID(txtID.Text);

            Customer cs = new Customer(txtName.Text, txtCustomerID.Text, id, address);
            bool result = bnk.addCustomer(cs, id, address);

            MessageBox.Show("Customer " + txtCustomerID.Text + " has been inserted.", "Adding Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);


            txtName.Text = "";
            txtCustomerID.Text = "";
            txtID.Text = "";
            txtAddress.Text = "";


        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Are you sure to delete!", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                bool result = bnk.deleteCustomer(cbxDeleteCustomer.SelectedItem.ToString());

                if (result)
                {
                    cbxDeleteCustomer.Items.RemoveAt(cbxDeleteCustomer.SelectedIndex);
                    MessageBox.Show("This student has been deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("This student couldn't be deleted!", "Not Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (cbxDeleteCustomer.Items.Count != 0)
                    cbxDeleteCustomer.SelectedIndex = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }

    private void btnAddLoanToCustomer_Click(object sender, EventArgs e)
        {

            Loan loan = new Loan(Convert.ToDouble(txtTime.Text), Convert.ToDouble(txtInterestRate.Text), Convert.ToDouble(txtPresentValue.Text));
            bnk.addLoanToCustomer(loan, Convert.ToInt32(cbxAddLoanToCustomer.SelectedIndex.ToString()));
            MessageBox.Show("Loan added to customer " + txtCustomerID.Text + " .", "Adding Loan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtTime.Text = " ";
            txtInterestRate.Text = " ";
            txtPresentValue.Text = " ";
        }


        private void tbcBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcBank.SelectedIndex == 1)
            {
                cbxDeleteCustomer.Items.Clear();

                foreach (Customer cs in bnk.customers)
                {
                    cbxDeleteCustomer.Items.Add(cs.getCustomerId());
                }

                if (cbxDeleteCustomer.Items.Count != 0)
                {
                    cbxDeleteCustomer.SelectedIndex = 0;
                }
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                lsbCustomers.Items.Clear();

                foreach (Customer cs in bnk.customers)
                {
                    lsbCustomers.Items.Add(cs.getCustomerId() + " " + cs.name + " " + cs.ýd.getID() + " " + cs.Address.getText());
                }
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                cbxAddLoanToCustomer.Items.Clear();
                foreach (Customer cs in bnk.customers)
                {
                    cbxAddLoanToCustomer.Items.Add(cs.getCustomerId());
                }

                if (cbxAddLoanToCustomer.Items.Count != 0)
                {
                    cbxAddLoanToCustomer.SelectedIndex = 0;
                }
            }
            else if (tabControl1.SelectedIndex == 4)
            {
                cbxDltLoanToCs.Items.Clear();
                cbxDltCsLoans.Items.Clear();
                foreach (Customer cs in bnk.customers)
                {
                    cbxDltLoanToCs.Items.Add(cs.getCustomerId());
                    cbxDltCsLoans.Items.Add(cs.LoanList);
                }

                if (cbxDltLoanToCs.Items.Count != 0 && cbxDltCsLoans.Items.Count != 0)
                {
                    cbxDltLoanToCs.SelectedIndex = 0;
                    cbxDltCsLoans.SelectedIndex = 0;
                }

            }
            else if (tabControl1.SelectedIndex == 5)
            {
                lsbLoansOfCustomers.Items.Clear();




                foreach (Customer cs in bnk.customers)
                {
                    lsbLoansOfCustomers.Items.Add($"{cs.getCustomerId()} - {cs.name}'s Loans:");

                    foreach (Loan loan in cs.LoanList)
                    {
                        lsbLoansOfCustomers.Items.Add($"    {loan.accumulated_value}");
                    }

                    // lsbLoansOfCustomers.Items.Add(cs.getCustomerId() + " " + cs.name+ " " );  
                    //cs.LoanList.ForEach(loan => lsbLoansOfCustomers.Items.Add($"    {loan}"));
                    //foreach (Loan loan in cs.LoanList)
                    //{
                    //    lsbLoansOfCustomers.Items.Add($"    {loan}");
                    //}



                }
            }
            else if (tabControl1.SelectedIndex == 6)
            {
                cbxUpdateCustomer.Items.Clear();
                foreach (Customer cs in bnk.customers)
                {
                    cbxUpdateCustomer.Items.Add(cs.getCustomerId());
                }

                if (cbxUpdateCustomer.Items.Count != 0)
                {
                    cbxUpdateCustomer.SelectedIndex = 0;
                }



            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}