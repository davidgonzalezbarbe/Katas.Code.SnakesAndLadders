using FluentAssertions;
using SnakesAndLadders.Core.Class;
using TechTalk.SpecFlow;

namespace SnakesAndLadders.IntegrationTest.StepDefinitions
{
    [Binding]
    public class Feature1StepDefinitions
    {
        #region Private

        private readonly Game _game;

        #endregion

        public Feature1StepDefinitions()
        {
            _game = new Game();
        }

        #region BeforeScenario

        [BeforeScenario("US1_UAT2", "US1_UAT3", "US3_UAT1", "US3_UAT2")]
        public void SetUpUserForScenario()
        {
            _game.Start();
            _game.AddUserOnTheboard();
        }

        [BeforeScenario("US2_UAT1", "US2_UAT2")]
        public void MoveTo96()
        {
            _game.Start();
            _game.AddUserOnTheboard();
            _game.MoveUser(96);
        }

        #endregion


        [Given(@"the game is started")]
        public void GivenTheGameIsStarted()
        {
            _game.Start();
        }

        [When(@"the token is placed on the board")]
        public void WhenTheTokenIsPlacedOnTheBoard()
        {
            _game.AddUserOnTheboard();
        }

        [Then(@"the token is on square (.*)")]
        public void ThenTheTokenIsOnSquare(int p0)
        {
            var position = _game.GetPosition();
            position.Should().Be(p0);
            position.Should().BeInRange(1, 100);
        }


        [When(@"the token is moved (.*) spaces")]
        public void WhenTheTokenIsMovedSpaces(int p0)
        {
            var initial = _game.GetPosition();
            var move = initial + p0;
            _game.MoveUser(p0);
            var result = _game.GetPosition();
            result.Should().Be(move > 100 ? initial : move);
        }

        [Given(@"the token is on square (.*)")]
        public void GivenTheTokenIsOnSquare(int p0)
        {
            var position = _game.GetPosition();
            position.Should().Be(p0);
            position.Should().BeInRange(1, 100);
        }

        [When(@"then it is moved (.*) spaces")]
        public void WhenThenItIsMovedSpaces(int p0)
        {
            _game.MoveUser(p0);
        }

        [Then(@"the player has won the game")]
        public void ThenThePlayerHasWonTheGame()
        {
            _game.IsWin().Should().Be(true);
        }

        [Then(@"the player has not won the game")]
        public void ThenThePlayerHasNotWonTheGame()
        {
            _game.IsWin().Should().Be(false);
        }

        [When(@"the player rolls a die")]
        public void WhenThePlayerRollsADie()
        {
            _game.RollDie().Should().BeInRange(1, 6);
        }

        [Then(@"the result should be between (.*) and (.*) inclusive")]
        public void ThenTheResultShouldBeBetweenAndInclusive(int p0, int p1)
        {
            _game.RollDie().Should().BeInRange(p0, p1);
        }

        [Given(@"the player rolls a (.*)")]
        public void GivenThePlayerRollsA(int p0)
        {
            //Test without implementation 
        }

        [When(@"they move their token")]
        public void WhenTheyMoveTheirToken()
        {
            //Test without implementation 
        }

        [Then(@"the token should move (.*) spaces")]
        public void ThenTheTokenShouldMoveSpaces(int p0)
        {
            var initial = _game.GetPosition();
            _game.MoveUser(p0);
            var result = _game.GetPosition() - initial;
            result.Should().Be(p0);
        }
    }
}
