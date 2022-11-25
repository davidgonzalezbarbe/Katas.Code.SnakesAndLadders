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

        [Given(@"Given the token is on square (.*)")]
        public void GivenGivenTheTokenIsOnSquare(int p0)
        {
            throw new PendingStepException();
        }

        [When(@"When the token is moved (.*) spaces")]
        public void WhenWhenTheTokenIsMovedSpaces(int p0)
        {
            throw new PendingStepException();
        }

        [Then(@"Then the token is on square (.*)")]
        public void ThenThenTheTokenIsOnSquare(int p0)
        {
            throw new PendingStepException();
        }

        [Given(@"the token is on square (.*)")]
        public void GivenTheTokenIsOnSquare(int p0)
        {
            throw new PendingStepException();
        }

        [When(@"the token is moved (.*) spaces")]
        public void WhenTheTokenIsMovedSpaces(int p0)
        {
            throw new PendingStepException();
        }

        [When(@"then it is moved (.*) spaces")]
        public void WhenThenItIsMovedSpaces(int p0)
        {
            throw new PendingStepException();
        }

        [Then(@"the player has won the game")]
        public void ThenThePlayerHasWonTheGame()
        {
            throw new PendingStepException();
        }

        [Then(@"the player has not won the game")]
        public void ThenThePlayerHasNotWonTheGame()
        {
            throw new PendingStepException();
        }

        [When(@"the player rolls a die")]
        public void WhenThePlayerRollsADie()
        {
            throw new PendingStepException();
        }

        [Then(@"the result should be between (.*) inclusive")]
        public void ThenTheResultShouldBeBetweenInclusive(Decimal p0)
        {
            throw new PendingStepException();
        }

        [Given(@"the player rolls a (.*)")]
        public void GivenThePlayerRollsA(int p0)
        {
            throw new PendingStepException();
        }

        [When(@"they move their token")]
        public void WhenTheyMoveTheirToken()
        {
            throw new PendingStepException();
        }

        [Then(@"the token should move (.*) spaces")]
        public void ThenTheTokenShouldMoveSpaces(int p0)
        {
            throw new PendingStepException();
        }

    }
}
