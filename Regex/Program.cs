using System;

namespace RegexExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regex Expression Programs!");
            Pincode pin = new Pincode();
            string[] pincode = { "400088", "A400088", "400088B", "400 088" };
            for (int i = 0; i < pincode.Length; i++)
            {
                pin.Check(pincode[i]);
            }
        }
    }
}
