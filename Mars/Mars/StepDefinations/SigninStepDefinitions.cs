using Mars.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Mars.StepDefinations
{
    [Binding]
    public class SigninStepDefinitions
    {
      IWebDriver driver=new ChromeDriver();

        [Given(@"I login into mars portal using valid credentials'([^']*)' and '([^']*)'")]
        public void GivenILoginIntoMarsPortalUsingValidCredentialsAnd(string username, string password)
        {
            

            //signin page objection intialition
            SigninPage signinPageObj = new SigninPage();
           signinPageObj.SigninActions(driver, username, password);
        }

        
        

        [Then(@"I should be able to validate that I logged in successfully")]
        public void ThenIShouldBeAbleToValidateThatILoggedInSuccessfully()
        {
            SigninPage signinPageObj = new SigninPage();
            string nameCheck=signinPageObj.GetCode(driver);
            Assert.That(nameCheck == "Hi Trupti", "Test Failed");
        }
    }
}
