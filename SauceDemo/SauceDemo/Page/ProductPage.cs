using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SauceDemo.Driver;

namespace SauceDemo.Page
{
    public class ProductPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public void SelectOption(string text)
        {
            SelectElement element = new SelectElement(SortByPrice);
            element.SelectByText(text);
        }
        public IWebElement SortByPrice => driver.FindElement(By.ClassName("product_sort_container"));
        public IWebElement AddShirt => driver.FindElement(By.Id("add-to-cart-sauce-labs-onesie"));
        public IWebElement AddBikeLight => driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light"));
        public IWebElement AddSecondShirt => driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt"));
        public IWebElement Cart => driver.FindElement(By.CssSelector("#shopping_cart_container ,shopping_cart_badge"));
        public IWebElement ShoppingCartClick => driver.FindElement(By.Id("shopping_cart_container"));


        public IWebElement RemoveShirt => driver.FindElement(By.Id("remove-sauce-labs-onesie"));
        public IWebElement RemoveBikeLight => driver.FindElement(By.Id("remove-sauce-labs-bike-light"));
        public IWebElement EmptyCart => driver.FindElement(By.ClassName("shopping_cart_link"));

    }
}
