using System;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----> User Registration Problem <-----");
            RegExp regExp = new RegExp();
            regExp.ValidateMobileNumber();
        }
    }
}
