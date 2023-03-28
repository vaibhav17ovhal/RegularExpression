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
        public const string PIN_CODE = "^[0-9]{6}$";
        //public const string PIN_CODE = "^[a-zA-Z]{1}[0-9]{6}$";
        //public const string PIN_CODE = "^[0-9]{6}[a-zA-Z]{1}$";
        //public const string PIN_CODE = "^[0-9]{3}[ ]{0,1}[0-9]{3}$";

        //abx.xyz@bridgelabz.co.in
        //abc.xyz@bridgelabz.com.in

        //public const string EMAIL_PATTERN = "^[a-zA-Z]{1,}$";
        //public const string EMAIL_PATTERN = "^[a-zA-Z]{1,}[.]{0,1}[a-zA-Z]{1,}[@]{1}[a-zA-Z]{1,}$";
        //public const string EMAIL_PATTERN = "^[a-zA-Z]{1,}[.]{0,1}[a-zA-Z]{1,}[@]{1}[a-zA-Z]{1,}[.]{0,1}$";
        public const string EMAIL_PATTERN = "^[a-zA-Z]{1,}[.]{0,1}[a-zA-Z]{1,}[@]{1}[a-zA-Z]{1,}[.]{1}[a-z]{2,3}[.]{1}[a-z]{2}$";


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
        
        public void Validate1(string email)
        {
            if (Regex.IsMatch(email, EMAIL_PATTERN))
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
