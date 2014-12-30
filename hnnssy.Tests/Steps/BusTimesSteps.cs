using TechTalk.SpecFlow;

namespace hnnssy.Tests.Steps
{
    [Binding]
    public class BusTimesSteps
    {
        [Given(@"The current time and date")]
        public void GivenTheCurrentTimeAndDate()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I load the bus times page")]
        public void WhenILoadTheBusTimesPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the closest bus time for the library stop is displayed")]
        public void ThenTheClosestBusTimeForTheLibraryStopIsDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
