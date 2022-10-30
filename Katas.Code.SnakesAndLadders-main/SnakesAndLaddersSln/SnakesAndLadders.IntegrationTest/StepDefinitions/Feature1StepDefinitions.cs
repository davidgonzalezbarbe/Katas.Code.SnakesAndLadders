using System;
using SnakesAndLadders.Core;
using TechTalk.SpecFlow;

namespace SnakesAndLadders.IntegrationTest.StepDefinitions
{
    [Binding]
    public class Feature1StepDefinitions
    {
        #region Private

        private readonly Player _player = new Player();

        #endregion

        [Given(@"the game is started")]
        public void GivenTheGameIsStarted()
        {
            _player.Start();
        }

        [When(@"the token is placed on the board")]
        public void WhenTheTokenIsPlacedOnTheBoard()
        {
            _player.AddUserOnTheboard();
        }

        [Then(@"the token is on square (.*)")]
        public void ThenTheTokenIsOnSquare(int p0)
        {
            throw new PendingStepException();
        }
    }
}
