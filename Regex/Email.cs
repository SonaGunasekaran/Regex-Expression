using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace RegexExpression
{
    class Email
    {
        public void Check(string mail)
        {
            //regex pattern is created to check validity
            string pattern = "^[a-z ]{3}[a-z A-Z 0-9]*$";
            Regex regex = new Regex(pattern);
            // IsMatch method check the pattern and pincode
            if (regex.IsMatch(mail))
            {
                Console.WriteLine("Email :{0} is Valid", mail);
            }
            else
            {
                Console.WriteLine("Email :{0} is Invalid", mail);
            }
        }
    }
}
