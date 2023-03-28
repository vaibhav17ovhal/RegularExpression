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
            ValidatePinCode pin = new ValidatePinCode();
            pin.Validate("A400088");
        }
    }
}
