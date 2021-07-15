using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace UserRegistrationProblem
{
    class RegExp
    {
        public static string s = "^[A-Z][a-z]{2,}$";
        public void ValidateFirstName()
        {
            Regex exp = new Regex(s);
            Console.WriteLine("Enter first name :");
            string firstName = Console.ReadLine();
            bool result = Regex.IsMatch(firstName, s);
            if (result)
            {
                Console.WriteLine("Valid name");
            }
            else
            {
                Console.WriteLine("Invalid name");
                Console.WriteLine("First name starts with Cap and has minimum 3 characters");
            }
        }
    }
}
