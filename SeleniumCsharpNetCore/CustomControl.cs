using System;
using OpenQA.Selenium;

namespace SeleniumCsharpNetCore
{
    public class CustomControl : DriverContext
    {

        public static void ComboBox(string controlName, string value)
        {
            var comboControl = Driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));

            comboControl.Clear();
            comboControl.SendKeys(value);


            Driver.FindElement(By.XPath($"//div[@id='{controlName}-dropmenu']//li[text()='{value}']")).Click();
        }
    }
}
