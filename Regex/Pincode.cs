using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexExpression
{
    class Pincode
    {
        public void Check(string pincode)
        {
            //regex pattern is created to check validity
            string pattern = "^[1-9]{1}[0-9]{5}$";
            Regex regex = new Regex(pattern);
            // IsMatch method check the pattern and pincode
            if(regex.IsMatch(pincode))
            {
                Console.WriteLine("PinCode :{0} is Valid", pincode);
            }
            else
            {
                Console.WriteLine("Pincode :{0} is Invalid", pincode);
            }
        }
    }
}
