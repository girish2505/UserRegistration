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
        public void ValidateLastName()
        {
            Regex exp = new Regex(s);
            Console.WriteLine("Enter Last name :");
            string lastName = Console.ReadLine();
            bool result = Regex.IsMatch(lastName, s);
            if (result)
            {
                Console.WriteLine("Valid name");
            }
            else
            {
                Console.WriteLine("Invalid name");
                Console.WriteLine("Last name starts with Cap and has minimum 3 characters");
            }
        }
        public void ValidateEmail()
        {
            string[] email = { "abc@yahoo.com", "abc-100$yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc.100@abc.net.in", "abc#1.com" };
            string s = @"^[a-zA-Z]{3}([\- \+ _\.]*[a-zA-Z0-9]+)*@[a-zA-Z0-9]+\.[a-z]{2,3}(\.[a-zA-Z]{2,4}){0,1}$";
            Regex exp = new Regex(s);
            foreach (string i in email)
            {
                Match res = exp.Match(i);
                if (res.Success)
                {
                    Console.WriteLine($"Valid  {i}");
                }
                else
                {
                    Console.WriteLine($"InValid  {i}");
                }
            }
        }
        public void ValidateMobileNumber()
        {
            string[] number = { "91 7660094458", "91 9182501714","144 9848022338", "31 123456", "+1 9108542398" };
            string s = @"^[1-9]{2}[ ][0-9]{10}$";
            Regex exp = new Regex(s);
            foreach (string i in number)
            {
                Match res = exp.Match(i);
                if (res.Success)
                {
                    Console.WriteLine($"Valid  {i}");
                }
                else
                {
                    Console.WriteLine($"InValid  {i}");
                }
            }
        }
    }
}
