using DatatDrivenWithExamples.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatatDrivenWithExamples.Page_Object
{
    class DataRegistrationPage
    {
        public DataRegistrationPage()
        {
            driver = Hooks1.driver;

        }

        IWebDriver driver;
        IWebElement SignUp => driver.FindElement(By.XPath("/html/body/div/app-header/nav/div/ul[1]/li[3]/a"));
        IWebElement UserName => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > fieldset:nth-child(1) > input"));
        IWebElement Email => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[2]/input"));
        IWebElement Password => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[3]/input"));
        IWebElement SignUpButton => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/button"));

        IWebElement Home => driver.FindElement(By.XPath("(//a [@class='nav-link active'])[3]"));



     public void ClickOnSignUp()
        {


            SignUp.Click();




        }
        public void EnterUsername(string username)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            UserName.SendKeys(username + randomInt);
            //UserName.SendKeys(username);


        }
        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void EnterEmailAddress(string email)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            Email.SendKeys(email + randomInt);
           // Email.SendKeys(email);
        
        }


        public void EnterPassword(string password)
        {
            Password.SendKeys(password);

        }

        public void ClickSignUpButton()
        {

            SignUpButton.Click();


        }


        public bool IsHomeDisplayed()

        {
            return Home.Displayed;


        }





    }
}
