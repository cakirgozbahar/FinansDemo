using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinansDemo
{
    internal class Address
    {
        private string text;
        

        public Address(string text )
        {
            this.text = text;
            
        }



        public string getText()
        {
            return this.text;
        }
     

        public void setText(string text)
        {
            this.text = text;
        }
    
    }
}
