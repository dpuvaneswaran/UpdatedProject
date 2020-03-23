using NUnit.Framework;
using NUnit.Framework.Internal;
using System;

namespace ProjectTests
{
    public class Tests
    {
        private TestMethods userRegister;

        [SetUp]
        public void Setup()
        {
            userRegister = new TestMethods();
        }

        //VALID REGISTRATION TEST

        [Test]
        public void ValidateRegistration()

        {
            userRegister.username = "Dushan1205";
            userRegister.password = "1234";
            var message = userRegister.Registration();
            Assert.AreEqual("You have successfully registered!", message);

        }


        //Invalid Register test

        [Test]

        public void InvadlidRegistrationTest()
        {

            userRegister.username = "Dushan1205";
            userRegister.password = null;
            var message = userRegister.Registration();
            Assert.AreEqual("Please input in your name or password", message);

        }


        // Unmatched Password test

        [Test]

        public void InvadlidPasswordTest()
        {

            userRegister.password = "1205";
            userRegister.password = null;
            var message = userRegister.Registration();
            Assert.AreEqual("Password is not matching", message);

        }
    }
}