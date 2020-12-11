using IRF_Project_DCWC5L.Entities;
using NUnit.Framework;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestAccountProject
{
    class AccountControllerTestFixture
    {
        [
            Test,
            TestCase("abcd1234", false),
            TestCase("irf@uni-corvinus", false),
            TestCase("irf.uni-corvinus.hu", false),
            TestCase("irf@uni-corvinus.hu", true)
        ]
        public void TestValidateEmail(string email, bool expectedResult)
        {
            // Arrange
            var accountController = new AccountController();

            // Act
            var actualResult = accountController.ValidateEmail(email);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [
            Test,
            TestCase("KovacsKaroly", false),
            TestCase("Kovács Károly", false),
            TestCase("Kovacs karoly", false),
            TestCase("kovacs Karoly", false),
            TestCase("kovacs karoly", false),
            TestCase("Kovacs Karoly1", false),
            TestCase("K K", false),
            TestCase("Kovacs Karoly", true),
        ]
        public void TestValidateFullName(string fullname, bool expectedResult)
        {
            // Arrange
            var accountController = new AccountController();

            // Act
            var actualResult = accountController.ValidateFullName(fullname);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [
            Test,
            TestCase("1Szandika", false),
            TestCase("Sünike", false),
            TestCase("Sz", false),
            TestCase("Kiss Szandika", false),
            TestCase("Szandika9", false),
            TestCase("szandika", true),
            TestCase("Szandika", true),
        ]
        public void TestValidateShortName(string shortname, bool expectedResult)
        {
            // Arrange
            var accountController = new AccountController();

            // Act
            var actualResult = accountController.ValidateShortName(shortname);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        public void TestRegisterHappyPath(string fullname, string shortname, string email)
        {
            // Arrange
            var accountregController = new AccountController();

            // Act
            var actualregResult = accountregController.Register(fullname, shortname, email);

            // Assert
            Assert.AreEqual(fullname, actualregResult.TeljesNev);
            Assert.AreEqual(shortname, actualregResult.BeceNev);
            Assert.AreEqual(email, actualregResult.Email);
        }

        [
            Test,
            TestCase("kisskaroly", "k", "e-mailem.gmail.com"),
            TestCase("Kiss Karoly", "Karesz", "e-mailem.gmail.com"),
            TestCase("Kiss Karoly", "k", "kisskaroly@gmail.com"),
            TestCase("kisskaroly", "Karesz", "kisskaroly@gmail.com"),
            TestCase("kisskaroly", "k", "kisskaroly@gmail.com"),
            TestCase("kisskaroly", "Karesz", "e-mailem.gmail.com"),
            TestCase("Kiss Karoly", "k", "e-mailem.gmail.com"),
        ]
        public void TestRegisterValidateException(string fullname, string shortname, string email)
        {
            // Arrange
            var accountregController = new AccountController();

            // Act + Assert
            try
            {
                var actualregResult = accountregController.Register(fullname, shortname, email);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOf<ValidationException>(ex);
            }

        }

    }
}
