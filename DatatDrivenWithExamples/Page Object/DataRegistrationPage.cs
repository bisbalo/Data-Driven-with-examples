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

        //locating the webaddress for each WebeElement on the webpage.
        IWebElement SignUp => driver.FindElement(By.XPath("(//a[@class='nav-link'])[2]"));
        IWebElement UserName => driver.FindElement(By.XPath("//input[@placeholder='Username']"));
        IWebElement Email => driver.FindElement(By.XPath("//input[@type='email']"));
        IWebElement Password => driver.FindElement(By.XPath("//input[@placeholder='Password']"));
        IWebElement SignUpButton => driver.FindElement(By.XPath("//button[@type='submit']"));

        IWebElement Home => driver.FindElement(By.XPath("(//a [@class='nav-link active'])[3]"));




        public void NavigateToWebsite(string url)
        {
            // Navigate to the Website
            driver.Navigate().GoToUrl(url);
        }

        public void ClickOnSignUp()
        {
            //Click on the Signup link

            SignUp.Click();
        }

        
        public void EnterUsername(string username)
        {
            //Radom generator to generate radom number with the username, to enable repetitton of execution
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            UserName.SendKeys(username + randomInt);
            


        }
       

        public void EnterEmailAddress(string email)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            Email.SendKeys(email + randomInt);
           
        
        }


        public void EnterPassword(string password)
        {
            // Sending the variable password to adress of the WebElement
            Password.SendKeys(password);

        }

        public void ClickSignUpButton()
        {
            //Clicking om the SignUp button
            SignUpButton.Click();
            
        }


        public bool IsHomeDisplayed()

        { 
                   
            //asserting that the WebElement Home is seen
            return Home.Displayed;

        }





    }
}
