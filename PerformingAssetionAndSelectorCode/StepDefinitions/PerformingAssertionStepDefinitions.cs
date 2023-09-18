using NUnit.Framework;
using PerformingAssetionAndSelectorCode.PageObject;
using System;
using TechTalk.SpecFlow;

namespace PerformingAssetionAndSelectorCode.StepDefinitions
{
    [Binding]
    public class PerformingAssertionStepDefinitions
    {

        PerformingAssertion performingAssertion;
        public PerformingAssertionStepDefinitions()
        { 
            performingAssertion = new PerformingAssertion();
        }
        [Given(@"I navigate to the wesbite")]
        public void GivenINavigateToTheWesbite()
        {
            performingAssertion.NavigateToWebsite();
        }

        [Given(@"I Click on SignUp")]
        public void GivenIClickOnSignUp()
        {
            performingAssertion.ClickOnSignUP();
        }

        [Given(@"I Enter my Username")]
        public void GivenIEnterMyUsername()
        {
            performingAssertion.EnterUsername();
        }

        [Given(@"I Enter my email")]
        public void GivenIEnterMyEmail()
        {
            performingAssertion.EnterEmail();
        }

        [Given(@"I Enter passowrd")]
        public void GivenIEnterPassowrd()
        {
            performingAssertion.EnterPassword();
        }

        [When(@"I Click on the Sign up button")]
        public void WhenIClickOnTheSignUpButton()
        {
            performingAssertion.Enterlogin();
        }

        [Then(@"I Should be able to register succesfully")]
        public void ThenIShouldBeAbleToRegisterSuccesfully()
        {
            //Thread.Sleep(5000);
            Assert.That(performingAssertion.IsNewArticleDisplayed);
        }
    }
}
