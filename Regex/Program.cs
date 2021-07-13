using System;

namespace RegexExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regex Expression Programs!");
            Console.WriteLine("1.Pincode\n2.Emailcheck");
            Console.WriteLine("Enter the choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {

                case 1:
                    Pincode pin = new Pincode();
                    string[] pincode = { "400088", "A400088", "400088B", "400 088" };
                    for (int i = 0; i < pincode.Length; i++)
                    {
                        pin.Check(pincode[i]);
                    }
                    break;

                case 2:
                    Email email = new Email();
                    string[] mail = {"abc@yahoo.co.com","abf@gmail.com","a@bcd3","a"};
                    for (int i = 0; i < mail.Length; i++)
                    {
                        email.Check(mail[i]);
                    }

                    Console.Read();
                    break;
            }

        }

    }
}
  
