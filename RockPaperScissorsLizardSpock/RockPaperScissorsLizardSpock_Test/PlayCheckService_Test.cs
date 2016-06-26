using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissorsLizardSpock;
using RockPaperScissorsLizardSpock.Constants;
using RockPaperScissorsLizardSpock.Services;

namespace RockPaperScissorsLizardSpock_Test
{
    [TestClass]
    public class PlayCheckService_Test
    {
        #region Rock

        [TestMethod]
        public void RockWinsScissors_Test()
        {
            //Arrange
            IPlayCheckService playCheck = new PlayCheckService();
            var playerOneMove = PlayType.ROCK;
            var playerTwoMove = PlayType.SCISSORS;
            var result = string.Empty;

            //Act
            result = playCheck.GetWinner(playerOneMove, playerTwoMove);

            //Assert
            Assert.AreEqual(Messages.PLAYER_ONE, result);
            

        }

        [TestMethod]
        public void RockWinsLizzard_Test()
        {
            //Arrange
            IPlayCheckService playCheck = new PlayCheckService();
            var playerOneMove = PlayType.ROCK;
            var playerTwoMove = PlayType.LIZARD;
            var result = string.Empty;

            //Act
            result = playCheck.GetWinner(playerOneMove, playerTwoMove);

            //Assert
            Assert.AreEqual(Messages.PLAYER_ONE, result);


        }

        [TestMethod]
        public void RockLosesPaper_Test()
        {
            //Arrange
            IPlayCheckService playCheck = new PlayCheckService();
            var playerOneMove = PlayType.ROCK;
            var playerTwoMove = PlayType.PAPER;
            var result = string.Empty;

            //Act
            result = playCheck.GetWinner(playerOneMove, playerTwoMove);

            //Assert
            Assert.AreEqual(Messages.PLAYER_TWO, result);

        }

        [TestMethod]
        public void RockLosesSpock_Test()
        {
            //Arrange
            IPlayCheckService playCheck = new PlayCheckService();
            var playerOneMove = PlayType.ROCK;
            var playerTwoMove = PlayType.SPOCK;
            var result = string.Empty;

            //Act
            result = playCheck.GetWinner(playerOneMove, playerTwoMove);

            //Assert
            Assert.AreEqual(Messages.PLAYER_TWO, result);
        }

        #endregion

        #region Paper
        [TestMethod]
        public void PaperWinsRock_Test()
        {
            //Arrange
            IPlayCheckService playCheck = new PlayCheckService();
            var playerOneMove = PlayType.PAPER;
            var playerTwoMove = PlayType.ROCK;
            var result = string.Empty;

            //Act
            result = playCheck.GetWinner(playerOneMove, playerTwoMove);

            //Assert
            Assert.AreEqual(Messages.PLAYER_ONE, result);
        }

        [TestMethod]
        public void PaperWinsSpock_Test()
        {
            //Arrange
            IPlayCheckService playCheck = new PlayCheckService();
            var playerOneMove = PlayType.SPOCK;
            var playerTwoMove = PlayType.ROCK;
            var result = string.Empty;

            //Act
            result = playCheck.GetWinner(playerOneMove, playerTwoMove);

            //Assert
            Assert.AreEqual(Messages.PLAYER_ONE, result);
        }

        [TestMethod]
        public void PaperLosesScissors_Test()
        {
            //Arrange
            IPlayCheckService playCheck = new PlayCheckService();
            var playerOneMove = PlayType.PAPER;
            var playerTwoMove = PlayType.SCISSORS;
            var result = string.Empty;

            //Act
            result = playCheck.GetWinner(playerOneMove, playerTwoMove);

            //Assert
            Assert.AreEqual(Messages.PLAYER_TWO, result);
        }

        [TestMethod]
        public void PaperLosesLizard_Test()
        {
            //Arrange
            IPlayCheckService playCheck = new PlayCheckService();
            var playerOneMove = PlayType.PAPER;
            var playerTwoMove = PlayType.LIZARD;
            var result = string.Empty;

            //Act
            result = playCheck.GetWinner(playerOneMove, playerTwoMove);

            //Assert
            Assert.AreEqual(Messages.PLAYER_TWO, result);
        }

        #endregion

        #region Scissors

        [TestMethod]
        public void ScissorsWinsPaperTest()
        {
            //Arrange
            IPlayCheckService playCheck = new PlayCheckService();
            var playerOneMove = PlayType.SCISSORS;
            var playerTwoMove = PlayType.PAPER;
            var result = string.Empty;

            //Act
            result = playCheck.GetWinner(playerOneMove, playerTwoMove);

            //Assert
            Assert.AreEqual(Messages.PLAYER_ONE, result);
        }

        [TestMethod]
        public void ScissorsWinsLizard_Test()
        {
            //Arrange
            IPlayCheckService playCheck = new PlayCheckService();
            var playerOneMove = PlayType.SCISSORS;
            var playerTwoMove = PlayType.LIZARD;
            var result = string.Empty;

            //Act
            result = playCheck.GetWinner(playerOneMove, playerTwoMove);

            //Assert
            Assert.AreEqual(Messages.PLAYER_ONE, result);
        }

        [TestMethod]
        public void ScissorsLosesRock_Test()
        {
            //Arrange
            IPlayCheckService playCheck = new PlayCheckService();
            var playerOneMove = PlayType.SCISSORS;
            var playerTwoMove = PlayType.ROCK;
            var result = string.Empty;

            //Act
            result = playCheck.GetWinner(playerOneMove, playerTwoMove);

            //Assert
            Assert.AreEqual(Messages.PLAYER_TWO, result);
        }

        [TestMethod]
        public void ScissorsLosesSpock_Test()
        {
            //Arrange
            IPlayCheckService playCheck = new PlayCheckService();
            var playerOneMove = PlayType.SCISSORS;
            var playerTwoMove = PlayType.SPOCK;
            var result = string.Empty;

            //Act
            result = playCheck.GetWinner(playerOneMove, playerTwoMove);

            //Assert
            Assert.AreEqual(Messages.PLAYER_TWO, result);
        }

        #endregion

        #region Lizard

        [TestMethod]
        public void LizardWinsSpock_Test()
        {
            //Arrange
            IPlayCheckService playCheck = new PlayCheckService();
            var playerOneMove = PlayType.SCISSORS;
            var playerTwoMove = PlayType.PAPER;
            var result = string.Empty;

            //Act
            result = playCheck.GetWinner(playerOneMove, playerTwoMove);

            //Assert
            Assert.AreEqual(Messages.PLAYER_ONE, result);
        }

        [TestMethod]
        public void LizardWinsPaper_Test()
        {
            //Arrange
            IPlayCheckService playCheck = new PlayCheckService();
            var playerOneMove = PlayType.LIZARD;
            var playerTwoMove = PlayType.PAPER;
            var result = string.Empty;

            //Act
            result = playCheck.GetWinner(playerOneMove, playerTwoMove);

            //Assert
            Assert.AreEqual(Messages.PLAYER_ONE, result);
        }

        [TestMethod]
        public void LizardLosesRock_Test()
        {
            //Arrange
            IPlayCheckService playCheck = new PlayCheckService();
            var playerOneMove = PlayType.LIZARD;
            var playerTwoMove = PlayType.ROCK;
            var result = string.Empty;

            //Act
            result = playCheck.GetWinner(playerOneMove, playerTwoMove);

            //Assert
            Assert.AreEqual(Messages.PLAYER_TWO, result);
        }

        [TestMethod]
        public void LizardLosesScissors_Test()
        {
            //Arrange
            IPlayCheckService playCheck = new PlayCheckService();
            var playerOneMove = PlayType.LIZARD;
            var playerTwoMove = PlayType.SCISSORS;
            var result = string.Empty;

            //Act
            result = playCheck.GetWinner(playerOneMove, playerTwoMove);

            //Assert
            Assert.AreEqual(Messages.PLAYER_TWO, result);
        }

        #endregion

        #region Spock

        [TestMethod]
        public void SpockWinsScissors_Test()
        {
            //Arrange
            IPlayCheckService playCheck = new PlayCheckService();
            var playerOneMove = PlayType.SPOCK;
            var playerTwoMove = PlayType.SCISSORS;
            var result = string.Empty;

            //Act
            result = playCheck.GetWinner(playerOneMove, playerTwoMove);

            //Assert
            Assert.AreEqual(Messages.PLAYER_ONE, result);
        }

        [TestMethod]
        public void SpockWinsRock_Test()
        {
            //Arrange
            IPlayCheckService playCheck = new PlayCheckService();
            var playerOneMove = PlayType.SPOCK;
            var playerTwoMove = PlayType.ROCK;
            var result = string.Empty;

            //Act
            result = playCheck.GetWinner(playerOneMove, playerTwoMove);

            //Assert
            Assert.AreEqual(Messages.PLAYER_ONE, result);
        }

        [TestMethod]
        public void SpockLosesPaper_Test()
        {
            //Arrange
            IPlayCheckService playCheck = new PlayCheckService();
            var playerOneMove = PlayType.SPOCK;
            var playerTwoMove = PlayType.PAPER;
            var result = string.Empty;

            //Act
            result = playCheck.GetWinner(playerOneMove, playerTwoMove);

            //Assert
            Assert.AreEqual(Messages.PLAYER_TWO, result);
        }

        [TestMethod]
        public void SpockLosesLizard_Test()
        {
            //Arrange
            IPlayCheckService playCheck = new PlayCheckService();
            var playerOneMove = PlayType.SPOCK;
            var playerTwoMove = PlayType.LIZARD;
            var result = string.Empty;

            //Act
            result = playCheck.GetWinner(playerOneMove, playerTwoMove);

            //Assert
            Assert.AreEqual(Messages.PLAYER_TWO, result);
        }

        #endregion
    }
}
