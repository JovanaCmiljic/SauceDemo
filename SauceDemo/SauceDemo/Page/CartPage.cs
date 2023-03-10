using OpenQA.Selenium;
using SauceDemo.Driver;

namespace SauceDemo.Page
{
    public class CartPage
    {
        private IWebDriver driver = WebDrivers.Instance;


        public IWebElement Checkout => driver.FindElement(By.Id("checkout"));
        public IWebElement FirstName => driver.FindElement(By.Id("first-name"));
        public IWebElement LastName => driver.FindElement(By.Id("last-name"));
        public IWebElement ZipCode => driver.FindElement(By.Id("postal-code"));
        public IWebElement ButtonContinue => driver.FindElement(By.Id("continue"));
        public IWebElement ButtonFinish => driver.FindElement(By.Id("finish"));
        public IWebElement OrderFinished => driver.FindElement(By.CssSelector("#checkout_complete_container > h2"));
        public IWebElement TotalPrice => driver.FindElement(By.ClassName("summary_total_label"));
    }
}
