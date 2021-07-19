using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationProblem;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("First Name")]
        public void TestMethodforValidFirstName()
        {
            string expected = "Valid";
            string actual = RegExp.ValidateFirstName("Girish");
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        [TestCategory("First Name")]
        public void TestMethodforInValidFirstName()
        {
            string expected = "Invalid";
            string actual = RegExp.ValidateFirstName("gir");
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        [TestCategory("First Name")]
        public void TestMethodforEmptyName()
        {
            try
            {
                RegExp.ValidateLastName("");
            }
            catch (CustomException ex)
            {
                string expected = "Empty Last Name";
                Assert.AreEqual(expected, ex.Message);
            }

        }
        [TestMethod]
        [TestCategory("Last Name")]
        public void TestMethodforLastName()
        {
            try
            {
                RegExp.ValidateLastName("Guptha");
            }
            catch (CustomException ex)
            {
                string expected = "Valid";
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        [TestCategory("Last Name")]
        public void TestMethodforInvalidLastName()
        {
            try
            {
                RegExp.ValidateLastName("gup");
            }
            catch (CustomException ex)
            {
                string expected = "Invalid Last Name";
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        [TestCategory("Email")]
        public void TestForInvalidEmail()
        {
            try
            {
                RegExp.ValidateEmail("abc@%*.com");
            }
            catch (CustomException ex)
            {
                string expected = "Email is invalid";
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        [TestCategory("Email")]
        public void TestForValidEmail()
        {
            string actual = RegExp.ValidateEmail("abc@gmail.com");
            string expected = "Valid";
            Assert.AreEqual(actual, expected);

        }
        [TestMethod]
        [TestCategory("PhoneNumber")]
        public void TestForValidPhoneNumber()
        {
            string actual = RegExp.ValidatePhoneNumber("91 7660094458");
            string expected = "Valid";
            Assert.AreEqual(actual, expected);

        }
        [TestMethod]
        [TestCategory("PhoneNumber")]
        public void TestForPhoneNumber()
        {
            try
            {
                RegExp.ValidatePhoneNumber(null);
            }
            catch (CustomException ex)
            {
                string expected = "Null";
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        [TestCategory("Password")]
        public void TestMethodValidPassword()
        {
            try
            {
                RegExp.ValidatePassword("awsvWf&2");
            }
            catch (CustomException ex)
            {
                string expected = "Valid";
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        [TestCategory("Password")]
        public void TestMethodInvalidPassword()
        {
            try
            {
                RegExp.ValidatePassword("awsvWf&2#");
            }
            catch (CustomException ex)
            {
                string expected = "Invalid Password";
                Assert.AreEqual(expected, ex.Message);
            }
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
