using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;
using System.Net;

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


        //private void btnConfirm_Click(object sender, EventArgs e)
        //{
        //    if (rbtAdd.Checked)
        //    {
        //        pnlInsideForm.Visible = true;

        //    }
        //    else if (rbtSearch.Checked)
        //        pnlSearch.Visible = true;
        //    else if (rbtList.Checked)
        //    {
        //        pnlListNames.Visible = true;

        //        List<string> names = bnk.listCustomer();

        //        foreach (string name in names)
        //            lsbNames.Items.Add(name);
        //    }
        //}

      

        //  public void compoundInterest_Click(object sender, EventArgs e)
        /*  {Interest interest = new Interest(0, 0, 0);
              interest.present_value = Convert.ToDouble(textPresentValue.Text);
              interest.i = Convert.ToDouble(textInterestRate.Text);
              interest.time = Convert.ToDouble(textTime.Text);

              double p = interest.present_value;
              double i = interest.i;
              double t = interest.time;

              double a = interest.CompoundInterest(t, i, p);
              return a;

              MessageBox.Show("Accumulated value is ");
          }
        */
        //public void simpleInterest_Click(object sender, EventArgs e)
        //{
        //    Interest interest = new Interest(0, 0, 0);
        //    interest.present_value = Convert.ToDouble(textPresentValue.Text);
        //    interest.i = Convert.ToDouble(textInterestRate.Text);
        //    interest.time = Convert.ToDouble(textTime.Text);

        //    double p = interest.present_value;
        //    double i = interest.i;
        //    double t = interest.time;

        //    double a = interest.SimpleInterest(t, i, p);

        //    MessageBox.Show("Accumulated value is " + a);
        //}

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

            MessageBox.Show("Customer " + txtCustomerID.Text + " has been inserted.");
            bnk.insertCustomer(cs);

        }
    }
}