using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    public class ValidatePinCode
    {
        //public const string PIN_CODE = "^[0-9]{6}$";
        public const string PIN_CODE = "^[a-zA-Z]{1}[0-9]{6}";

        
        public void Validate(string pinCode)
        {
            if (Regex.IsMatch(pinCode, PIN_CODE))
            {
                Console.WriteLine("Validation Successfull");
            }
            else
            {
                Console.WriteLine("Validation UnSuccessfull");
            }
        }
    }
}
