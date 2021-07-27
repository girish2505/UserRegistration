using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace UserRegistrationProblem
{
    public class RegExp
    {
        string message;
        public RegExp()
        {
            Console.WriteLine("Default Constructor");
        }
        public RegExp(string message)
        {
            this.message = message;
        }
        public static Func<string, string> ValidatingFirstName = (firstName) =>
        {
            string result = "Valid";
            Regex regex = new Regex(@"^[A-Z]{1}[a-z]{2,}");
            Match match = regex.Match(firstName);
            if (match.Success)
            {
                Console.WriteLine(firstName + "Valid");
            }
            else
            {
                Console.WriteLine(firstName + "Invalid");
                result = "Invalid";
            }
            return result;
        };
        public static Func<string, string> ValidatingLastName = (lastName) =>
        {
            string result = "Valid";
            Regex regex = new Regex(@"^[A-Z]{1}[a-z]{2,}");
            if (lastName != "")
            {
                Match match = regex.Match(lastName);
                if (match.Success)
                {
                    Console.WriteLine(lastName + "Valid");
                }
                else
                {
                    Console.WriteLine(lastName + "Invalid");
                    result = "Invalid";
                }
                if (result == "Invalid")
                    throw new CustomException(CustomException.ExceptionType.INVALID_NAME, "Invalid Last Name");
                else
                    return result;
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Empty Last Name");
            }
        };
        public static Func<string, string> ValidatingEmail = (email) =>
        {
            string result = "Valid";
            Regex regex = new Regex(@"^[a-zA-Z]{3}([\- \+ _\.]*[a-zA-Z0-9]+)*@[a-zA-Z0-9]+\.[a-z]{2,3}(\.[a-zA-Z]{2,4}){0,1}$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                Console.WriteLine(email + "Valid");
            }
            else
            {
                Console.WriteLine(email + "Invalid");
                result = "Invalid";
            }
            if (result == "Invalid")
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_EMAIL, "Email is invalid");
            }
            else
            {
                return result;
            }
        };
        public static Func<string, string> ValidatingPhoneNumber = (number) =>
        {
            string result = "Valid";
            string pattern = @"^[1-9]{2}[ ][0-9]{10}$";
            Regex regex = new Regex(pattern);
            if (number != null)
            {
                Match match = regex.Match(number);
                if (match.Success)
                {
                    Console.WriteLine(number + "Valid");
                    result = "Valid";
                }
                else
                {
                    Console.WriteLine(number + "Invalid");
                    result = "Invalid";
                }
                if (result == "Invalid")
                    throw new CustomException(CustomException.ExceptionType.INVALID_PHONE, "Invalid PhoneNumber");
                else
                    return result;
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Null");
            }
        };
        public static Func<string, string> ValidatingPassword = (password) =>
        {
            string result = "Valid";
            string pattern = @"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$";
            Regex regex = new Regex(pattern);

            Match match = regex.Match(password);
            if (match.Success)
            {
                Console.WriteLine(password + "Valid");
                result = "Valid";
            }
            else
            {
                Console.WriteLine(password + "Invalid");
                result = "Invalid";
            }

            if (result == "Invalid")
                throw new CustomException(CustomException.ExceptionType.INVALID_PASSWORD, "Invalid Password");
            else
            {
                return result;
            }
        };
    }
}
