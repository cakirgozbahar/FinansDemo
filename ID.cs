using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FinansDemo
{
    internal class ID
    {
        private string _id;
        
        public ID(string id)
        {
            _id = id;
        }

        public string getID()
        {
            return this._id.Substring(0, 5) + "******";
        }
        public void setID(string id)
        {
            this._id = id;
        }

        //public string Id
        //{
        //    get
        //    {
        //        return _id.Substring(0, 5) + "******";
        //    }
        //    set
        //    {
        //        bool check = false;
        //        if (value.Length == 11)
        //        {
        //            for (int i = 0; i < value.Length; i++)
        //            {
        //                bool isNumber = char.IsNumber(value[i]);
        //                if (isNumber)
        //                {
        //                    // yapacak bir şey yok
        //                }
        //                else
        //                {
        //                    check = true;
        //                    break;
        //                }
        //            }
        //            if (check)
        //            {
        //                Console.WriteLine("An invalid character is found in your id.");
        //            }
        //            else
        //            {
        //                _id = value;
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("Your ID number length should be 11.");
        //        }
        //    }
        //}
    }
}
