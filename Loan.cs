using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinansDemo
{
    internal class Loan 
    {
        public double time;
        public double i;
        public double present_value;
        public double accumulated_value;

        public Loan (double time, double i, double present_value)
        {
            this.time = time;
            this.i = i;
            this.present_value = present_value;
            

        }

        public double SimpleInterest(double time, double i, double present_value)
        {
            this.time = time;
            this.i = i;
            this.present_value = present_value;


            accumulated_value = this.present_value * (1 + this.i * this.time);

            return accumulated_value;
        }

        public double CompoundInterest(double time, double i, double present_value)
        {
            this.time = time;
            this.i = i;
            this.present_value = present_value;

            accumulated_value = this.present_value * Math.Pow(1 + this.i, this.time);

            return accumulated_value;
        }

        public override string ToString()
        {
            return $"Time: {time}, Interest Rate: {i * 100}%, Present Value: {present_value}, Accumulated Value: {accumulated_value}";
        }

        //public string accumulatedvalue { get; set; }

        //public Loan(double time, double i, double present_value) : base(time, i, present_value)
        //{
        //    this.accumulatedvalue = Convert.ToString(CompoundInterest(time, i, present_value)); 
        //}
    }
}
