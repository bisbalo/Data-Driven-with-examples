using DatatDrivenWithExamples.Page_Object;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace DatatDrivenWithExamples.Step_Definition
{
    [Binding]
    public class DataSteps
    {
        DataRegistrationPage dataregistrationpage;

        public DataSteps ()
        {
            dataregistrationpage = new DataRegistrationPage();


        }

        

          
      [Given(@"I navigate to the website ""(.*)""")]
        public void GivenINavigateToTheWebsite(string url)

        {
            dataregistrationpage.NavigateToWebsite(url);
        }
        
        [Given(@"I click on sign up")]
        public void GivenIClickOnSignUp()
        {
            dataregistrationpage.ClickOnSignUp();
        }
        
        [Given(@"I enter my username ""(.*)""")]
        public void GivenIEnterMyUsername(string username)
        {
            dataregistrationpage.EnterUsername(username);
        }
        
        [Given(@"I enter my email address ""(.*)""")]
        public void GivenIEnterMyEmailAddress(string email)
        {
            dataregistrationpage.EnterEmailAddress(email);
        }
        
        [Given(@"i enter my password ""(.*)""")]
        public void GivenIEnterMyPassword(string password)
        {
            dataregistrationpage.EnterPassword(password);
        }
        
        [When(@"I click on the sign up button")]
        public void WhenIClickOnTheSignUpButton()
        {
            dataregistrationpage.ClickSignUpButton();
        }
        
        [Then(@"I should be able to sign up successfully")]
        public void ThenIShouldBeAbleToSignUpSuccessfully()
        {
            Thread.Sleep(3000);
            Assert.That(dataregistrationpage.IsHomeDisplayed);
        }
    }
}
