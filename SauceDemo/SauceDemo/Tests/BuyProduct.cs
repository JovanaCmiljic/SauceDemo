using NUnit.Framework;
using SauceDemo.Driver;
using SauceDemo.Page;

namespace SauceDemo.Tests
{
    public class Tests
    {
        LoginPage loginPage;
        ProductPage productPage;
        CartPage cartPage;


        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            loginPage = new LoginPage();
            productPage = new ProductPage();
            cartPage = new CartPage();
        }
        [TearDown]
        public void Close()
        {
            WebDrivers.CleanUp();

        }
        [Test]
        public void TC01_AddThreeProductInCart_ShouldDisplayedThreeProducts()
        {
            loginPage.Login("standard_user", "secret_sauce");
            productPage.AddShirt.Click();
            productPage.AddBikeLight.Click();
            productPage.AddSecondShirt.Click();
            productPage.ShoppingCartClick.Click();

            Assert.That(productPage.Cart.Displayed);
        }
        [Test]
        public void TC02_AddTwoProductInCartAndDeleteBoth_ShouldBeEmptyCart()
        {
            loginPage.Login("standard_user", "secret_sauce");
            productPage.AddShirt.Click();
            productPage.AddBikeLight.Click();
            productPage.ShoppingCartClick.Click();
            productPage.RemoveShirt.Click();
            productPage.RemoveBikeLight.Click();

            Assert.That(productPage.EmptyCart.Displayed);
        }
        [Test]
        public void TC03_BuyAllProducts_ShouldBeFinishedShopping()
        {
            loginPage.Login("standard_user", "secret_sauce");
            productPage.AddShirt.Click();
            productPage.AddBikeLight.Click();
            productPage.AddSecondShirt.Click();
            productPage.ShoppingCartClick.Click();
            cartPage.Checkout.Click();
            cartPage.FirstName.SendKeys("Jovana");
            cartPage.LastName.SendKeys("CC");
            cartPage.ZipCode.SendKeys("11000");
            cartPage.ButtonContinue.Submit();
            cartPage.ButtonFinish.Click();

            Assert.That("THANK YOU FOR YOUR ORDER", Is.EqualTo(cartPage.OrderFinished.Text));


        }
        [Test]
        public void TC04_CheckItemTotalPrice_ShouldBeDisplayedTotalPrice()
        {
            loginPage.Login("standard_user", "secret_sauce");
            productPage.AddShirt.Click();
            productPage.AddBikeLight.Click();
            productPage.AddSecondShirt.Click();
            productPage.ShoppingCartClick.Click();
            cartPage.Checkout.Click();
            cartPage.FirstName.SendKeys("Jovana");
            cartPage.LastName.SendKeys("CC");
            cartPage.ZipCode.SendKeys("11000");
            cartPage.ButtonContinue.Submit();

            Assert.That(cartPage.TotalPrice.Displayed);
        }

    }
}