using NUnit.Framework;
using SauceDemo.Driver;
using SauceDemo.Page;

namespace SauceDemo.Tests
{
    public class LoginTests
    {
        LoginPage loginPage;
        string message = "Epic sadface: Username and password do not match any user in this service";

        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            loginPage = new LoginPage();

        }
        [TearDown]
        public void Close()
        {
            WebDrivers.CleanUp();

        }

        [Test]
        public void TC01_EnterInvalidUserName_ShouldNotBeLogin()
        {
            loginPage.Login("Jovana", "secret_sauce");
            Assert.That(message, Is.EqualTo(loginPage.UserNotLogin.Text));

        }
        [Test]
        public void TC02_EnterInvalidPassword_ShouldNotBeLogin()
        {
            loginPage.Login("standard_user", "Jovana");
            Assert.That(message, Is.EqualTo(loginPage.UserNotLogin.Text));
        }
        [Test]
        public void TC03_InvalidDataForLogin_ShouldNotBeLogin()
        {
            loginPage.Login("bb", "tt");
            Assert.That(message, Is.EqualTo(loginPage.UserNotLogin.Text));
        }

    }
}


