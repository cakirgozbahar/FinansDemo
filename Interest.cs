using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinansDemo
{
    internal class Interest
    {
        public double time;
        public double i;
        public double present_value;

        public Interest(double time,double i, double present_value)
        {
            this.time = time;
            this.i = i;
            this.present_value = present_value;
        }

        public double SimpleInterest(double time, double i, double present_value)
        {   this.time = time; 
            this.i = i; 
            this.present_value = present_value;
            double accumulated_value;

            accumulated_value = this.present_value * (1 + this.i * this.time);

            return accumulated_value;
        }

        public double CompoundInterest(double time, double i, double present_value)
        {
            this.time = time;
            this.i = i;
            this.present_value = present_value;
            double accumulated_value;
            //double y = Math.Pow(1 + this.i, this.time);
            accumulated_value = this.present_value * Math.Pow(1 + this.i, this.time);

            return accumulated_value;
        }

    }
}
