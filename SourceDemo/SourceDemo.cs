using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace SourceDemo
{
    public class Tests
    {
        Browser_Operation browser = new Browser_Operation();
        String url = "https://www.saucedemo.com/";

        

        [SetUp]
        public void Wait()
        {
           
            System.Threading.Thread.Sleep(1000);
           

        }

        [Test]
        public void test_login()
        {
            browser.Init_Browser();
            browser.Goto(url);
            IWebDriver driver= browser.getDriver();

            //Assert to check if actual url matches the expected url
            String actual_url = browser.Geturl;
            Assert.That(actual_url, Is.EqualTo(url));

            //Assert to check if the page title matches the login page title
            String Actuallogin_title = browser.Title;
            String Expectedlogin_title = "Swag Labs";
            Assert.That(Actuallogin_title, Is.EqualTo(Expectedlogin_title));

            //Login simulation
            LoginPage.inputLogin(driver, "standard_user", "secret_sauce");

            System.Threading.Thread.Sleep(1000);

            ProductPage.sort_lowest(driver);

        }
        [Test]
        public void test_product()
        {
            IWebDriver driver = browser.getDriver();

            System.Threading.Thread.Sleep(1000);
            ProductPage.selectProduct(driver);

            System.Threading.Thread.Sleep(1000);
            ProductPage.clickShoppingCart(driver);

        }

        [Test]
        public void test_shoppingCart_checkout()
        {
            IWebDriver driver = browser.getDriver();

            System.Threading.Thread.Sleep(1000);
            ShoppingCart.checkSelectedProduct(driver);

            System.Threading.Thread.Sleep(1000);
            ShoppingCart.removeItem(driver);

            System.Threading.Thread.Sleep(1000);
            ShoppingCart.clickContinueShopping(driver);

            System.Threading.Thread.Sleep(1000);
            ProductPage.selectAProduct(driver);

            System.Threading.Thread.Sleep(1000);
            ProductPage.clickShoppingCart(driver);

            System.Threading.Thread.Sleep(1000);
            ShoppingCart.clickCheckout(driver);

            
        }
        [Test]
        public void test_shoppingCheckout()
        {
            IWebDriver driver = browser.getDriver();

            System.Threading.Thread.Sleep(1000);
            CheckoutInformation.inputInfo(driver);
        }

        [Test]
        public void test_ycheckout()
        {
            IWebDriver driver = browser.getDriver();

            System.Threading.Thread.Sleep(1000);
            CheckOut.checkProductPresence(driver);

            System.Threading.Thread.Sleep(1000);
            CheckOut.clickFinish(driver);
        }

        [Test]
        public void test_zcomfirmation_and_Close()
        {
            IWebDriver driver = browser.getDriver();

            System.Threading.Thread.Sleep(1000);
            OrderComfirmation.checkorderComfirmation(driver);

            browser.Close();
        }
    }
}