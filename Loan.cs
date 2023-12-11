using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinansDemo
{
    internal class Loan : Interest
    {
        public double accumulated_value { get; set; }
       
        public Loan(double time, double i, double present_value) : base(time, i, present_value)
        {
            this.accumulated_value = CompoundInterest(time, i, present_value); 
        }
    }
}
