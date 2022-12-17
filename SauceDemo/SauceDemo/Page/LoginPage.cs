using OpenQA.Selenium;
using SauceDemo.Driver;

namespace SauceDemo.Page
{
    public class LoginPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement UserName => driver.FindElement(By.Id("user-name"));
        public IWebElement Password => driver.FindElement(By.Id("password"));
        public IWebElement LoginButton => driver.FindElement(By.Id("login-button"));
        public IWebElement UserNotLogin => driver.FindElement(By.CssSelector("#login_button_container > div > form > div.error-message-container.error > h3"));



        public void Login(string name, string pass)
        {
            UserName.SendKeys(name);
            Password.SendKeys(pass);
            LoginButton.Submit();
        }
    }
}
