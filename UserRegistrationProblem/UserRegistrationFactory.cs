using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Text;

namespace UserRegistrationProblem
{
    public class UserRegistrationFactory
    {
        public static object CreateingObjectForDefaultConstructor(string classname, string constructorname)
        {
            string pattern = @"." + constructorname + "$";
            Match result = Regex.Match(classname, pattern);
            if (result.Success)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type type = assembly.GetType(classname);
                    return Activator.CreateInstance(type);
                }
                catch (ArgumentNullException)
                {
                    throw new CustomException(CustomException.ExceptionType.NO_SUCH_CLASS, "class Not Found");
                }
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.NO_CONSTRUCTOR_FOUND, "constructor Not Found");
            }
        }
        public static object CreateingObjectForParameterizedConstructor(string classname, string constructorname, string message)
        {
            Type type = typeof(RegExp);
            if (type.Name.Equals(classname) || type.FullName.Equals(classname))
            {
                if (type.Name.Equals(constructorname))
                {
                    ConstructorInfo constructorInfo = type.GetConstructor(new[] { typeof(string) });
                    object objectConstructor = constructorInfo.Invoke(new object[] { message });
                    return objectConstructor;
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.NO_CONSTRUCTOR_FOUND, "constructor Not Found");
                }
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.NO_SUCH_CLASS, "class Not Found");
            }
        }
    }
}
