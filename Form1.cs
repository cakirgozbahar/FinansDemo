using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;
using System.Net;
using System;

namespace FinansDemo
{
    public partial class Form1 : Form
    {
        Bank bnk;
        public Form1()
        {
            bnk = new Bank();
            InitializeComponent();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void btncreate_Click_1(object sender, EventArgs e)
        {
            Address address = new Address(txtAddress.Text);
            ID id = new ID(txtID.Text);

            Customer cs = new Customer(txtName.Text, txtCustomerID.Text, id, address);

            MessageBox.Show("Customer " + txtCustomerID.Text + " has been inserted.", "Adding Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bnk.insertCustomer(cs);

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
                bnk.deleteCustomer(cbxDeleteCustomer.SelectedIndex);
                MessageBox.Show("This customer has been deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cbxDeleteCustomer.Items.Clear();

                foreach (Customer cs in bnk.customers)
                {
                    cbxDeleteCustomer.Items.Add(cs.getCustomerId());
                }

                if (cbxDeleteCustomer.Items.Count != 0)
                    cbxDeleteCustomer.SelectedIndex = 0;
            }

        }

        private void btnAddLoanToCustomer_Click(object sender, EventArgs e)
        {
            Interest interest = new Interest(0, 0, 0);
            Loan loan = new Loan(Convert.ToDouble(txtTime.Text), Convert.ToDouble(txtInterestRate), Convert.ToDouble(txtPresentValue.Text));
            bnk.addLoanToCustomer(loan, Convert.ToInt32(cbxAddLoanToCustomer.SelectedIndex.ToString()));
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
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
            else if (tabControl1.SelectedIndex == 5)
            {
                lsbLoansOfCustomers.Items.Clear();

                foreach (Customer cs in bnk.customers)
                {
                    lsbLoansOfCustomers.Items.Add(cs.getCustomerId() + " " + cs.name + " " + cs.LoanList);
                }
            }

        }
















        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }


    }
}