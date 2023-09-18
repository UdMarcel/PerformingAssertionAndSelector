using OpenQA.Selenium;
using PerformingAssetionAndSelectorCode.Utitlities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformingAssetionAndSelectorCode.PageObject
{
    public class PerformingAssertion
    {

        //testrive = HooksPerformingAssertion.driver;

        IWebDriver testdrive;
        //check


        public PerformingAssertion()
        {
            testdrive = HooksPerformingAssertion.testrun;


        }

        IWebElement SignUp => testdrive.FindElement(By.XPath("//a[@class='nav-link active']"));
        IWebElement Username => testdrive.FindElement(By.CssSelector("input[placeholder='Username']"));
       
        IWebElement Email => testdrive.FindElement(By.XPath("//input[@type='email']"));

        IWebElement Password => testdrive.FindElement(By.XPath("//input[@type='password']"));

        IWebElement Login => testdrive.FindElement(By.CssSelector("button[type='submit']"));

        IWebElement NewArticle => testdrive.FindElement(By.CssSelector("a[class='nav-link active']"));



        public void NavigateToWebsite()
        {
            testdrive.Navigate().GoToUrl("http://angularjs.realworld.io/#/register");

        }
        public void ClickOnSignUP()
        {
            SignUp.Click();

        }

        public void EnterUsername()
        {
            Username.SendKeys("Ajibola7");
        }

        public void EnterEmail()
        {
            Email.SendKeys("ajibola7@yahoo.com");
        }

        public void EnterPassword()
        {
            Password.SendKeys("Passsecure7");
        }
        public void Enterlogin()
        {
            Login.Click();
        }
        public bool IsNewArticleDisplayed()
        {
            return NewArticle.Displayed;
        }





















    }




    
}
