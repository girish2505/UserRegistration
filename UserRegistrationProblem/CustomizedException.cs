using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationProblem
{
    public class CustomException : Exception
    {
        //enum declaration
        ExceptionType exceptiontype;
        public enum ExceptionType
        {
            EMPTY_MESSAGE, NULL_MESSAGE, INVALID_EMAIL, INVALID_PASSWORD, NO_SUCH_CLASS, NO_CONSTRUCTOR_FOUND, NO_METHOD_FOUND, INVALID_PHONE, INVALID_NAME
        }

        //constructor for Regex custom exception class
        public CustomException(ExceptionType exception, string message) : base(message)
        {
            this.exceptiontype = exception;
        }
    }
}
