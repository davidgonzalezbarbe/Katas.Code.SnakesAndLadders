using System;
using TechTalk.SpecFlow;

namespace SnakesAndLadders.IntegrationTest.StepDefinitions
{
    [Binding]
    public class Feature1StepDefinitions
    {
        [Given(@"the game is started")]
        public void GivenTheGameIsStarted()
        {
            throw new PendingStepException();
        }

        [When(@"the token is placed on the board")]
        public void WhenTheTokenIsPlacedOnTheBoard()
        {
            throw new PendingStepException();
        }

        [Then(@"the token is on square (.*)")]
        public void ThenTheTokenIsOnSquare(int p0)
        {
            throw new PendingStepException();
        }
    }
}
