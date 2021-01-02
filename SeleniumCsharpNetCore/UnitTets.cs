using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumCsharpNetCore.Pages;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumCsharpNetCore
{
    public class UnitTests : DriverContext
    {

        [SetUp]
        public void Setup()
        {
            ChromeOptions option = new ChromeOptions();

            option.AddArgument("--window-size=1920,1080");
            option.AddArgument("--start-maximized");
            option.AddArgument("--headless");

            new DriverManager().SetUpDriver(new ChromeConfig());

            Console.WriteLine("Setup Passed");

            Driver = new ChromeDriver(option);
        }

        [Test]
        public void TestComboController()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");

            string controlName = "ContentPlaceHolder1_AllMealsCombo";

            CustomControl.ComboBox(controlName, "almond");

            Assert.Pass();
        }

        [Test]
        public void LoginTest()
        {
            Driver.Navigate().GoToUrl("http://eaapp.somee.com/");

            HomePage homePage = new HomePage();
            LoginPage loginPage = new LoginPage();

            homePage.ClickLogin();
            homePage.EnterUserNameAndPassword("admin", "password");
            loginPage.ClickLogin();
            Assert.That(homePage.IsLogOffDisplayed(), Is.True, "Log off button not displayed");
        }


        [TearDown]
        public void Shutdown()
        {
            Driver.Quit();
        }
    }
}