using System;

namespace RegularExpression
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expression");
            Console.WriteLine();

            //UC1
            //ValidatePinCode pin = new ValidatePinCode();
            //pin.Validate("400088");

            //UC2
            //ValidatePinCode pin = new ValidatePinCode();
            //pin.Validate("A400088");

            //UC3
            //ValidatePinCode pin = new ValidatePinCode();
            //pin.Validate("400088C");

            //UC4
            //ValidatePinCode pin = new ValidatePinCode();
            //pin.Validate("400 088");

            //UC1 (Email)
            //ValidatePinCode mail = new ValidatePinCode();
            //mail.Validate1("abcxyz");

            //UC2 (Email)
            //ValidatePinCode mail = new ValidatePinCode();
            //mail.Validate1("abc.xyz@bridgelabz");

            //UC3 (Email)
            //ValidatePinCode mail = new ValidatePinCode();
            //mail.Validate1("abc.xyz@bridgelabz.");

            //UC4 (Email)
            ValidatePinCode mail = new ValidatePinCode();
            mail.Validate1("abc.xyz@bridgelabz.com.in");

        }
    }
}
