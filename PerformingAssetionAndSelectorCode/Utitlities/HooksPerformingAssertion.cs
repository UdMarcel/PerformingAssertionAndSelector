using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace PerformingAssetionAndSelectorCode.Utitlities
{
    [Binding]
    public class HooksPerformingAssertion
    {
        public static IWebDriver testrun;

        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            testrun = new ChromeDriver();
            
            testrun.Manage().Window.Maximize();
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
           
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //driver.Quit();
        }
    }
}