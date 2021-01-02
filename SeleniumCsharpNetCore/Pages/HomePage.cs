using System;
using System.Collections.Generic;
using OpenQA.Selenium;

namespace SeleniumCsharpNetCore.Pages
{
    public class HomePage : DriverContext
    {
        IWebElement txtUserName => Driver.FindElement(By.Name("UserName"));
        IWebElement txtPassword => Driver.FindElement(By.Name("Password"));
        IWebElement lnkLogin => Driver.FindElement(By.Id("loginLink"));

        public bool IsLogOffDisplayed() => Driver.FindElement(By.LinkText("Log off")).Displayed;

        public void EnterUserNameAndPassword(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }

        public void ClickLogin()
        {
            lnkLogin.Click();
        }
    }
}
