using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumCsharpNetCore
{
    public class Tests : DriverContext
    {

        [SetUp]
        public void Setup()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("--headless");
            new DriverManager().SetUpDriver(new ChromeConfig());

            Console.WriteLine("Setup");

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

        [TearDown]
        public void Shutdown()
        {
            Driver.Quit();
        }
    }
}