using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace NunitTestApp
{
    [Binding]
    class TestBdd
    {
        [Given(@"I have entered (.*) into the calculator(.*)")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I press add(.*)")]
        public void WhenIPressAdd(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the result should be (.*) on the screen(.*)")]
        public void ThenTheResultShouldBeOnTheScreen(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
