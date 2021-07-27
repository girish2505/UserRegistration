using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationProblem;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow("Girish", "Girish")]
        
        public void ValidateFirstname(string a, string expected)
        {
            
                var actual = RegExp.ValidatingFirstName(a);
                Assert.AreEqual(expected, actual);
        }
        [DataTestMethod]
        [DataRow("Guptha", "GupTha")]
        [DataRow("Gup", "  ")]
        public void ValidateLastname(string a, string expected)
        {
                var actual = RegExp.ValidatingLastName(a);
                Assert.AreEqual(expected, actual);
        }
        [DataTestMethod]
        [DataRow("abc@yahoo.com", "abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com", "abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com", "abc.100@yahoo.com")]
        [DataRow("abc@gmail.com.1a", null)]
        [DataRow("abc@gmail.com.aa.au", null)]
        public void ValidateEmailId(string a, string expected)
        {
                var actual = RegExp.ValidatingEmail(a);
                Assert.AreEqual(expected, actual);
        }
        [DataTestMethod]
        [DataRow("91 7660094458", "91 7660094458")]
        [DataRow("91 9182501714", " 91 9182501714")]
        [DataRow("91 9440284232", null)]

        public void ValidateNumber(string x, string expected)
        {
            var actual = RegExp.ValidatingPhoneNumber(x);
            Assert.AreEqual(expected, actual);
        }
        [DataTestMethod]
        [DataRow("Abc#123", "Abc#123")]
        [DataRow("G57@g57", "G57@g57")]
        [DataRow("Vg@2505", null)]

        public void ValidatePassword(string x, string expected)
        {
            var actual = RegExp.ValidatingPassword(x);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Reflection")]
        public void TestCreateObjectWithDefaultConstructor()
        {
            object expected = new RegExp();
            object actual = UserRegistrationFactory.CreateingObjectForDefaultConstructor("UsingExceptionsInRegex.RegexAllMethods", "RegexAllMethods");
            expected.Equals(actual);
        }
        [TestMethod]
        [TestCategory("Reflection")]
        public void TestCreateObjectWithParameterConstructor()
        {
            object expected = new RegExp("Parameter Constructor");
            object actual = UserRegistrationFactory.CreateingObjectForParameterizedConstructor("UsingExceptionsInRegex.RegexAllMethods", "RegexAllMethods", "Parameter Constructor");
            actual.Equals(expected);
        }
    }
}
