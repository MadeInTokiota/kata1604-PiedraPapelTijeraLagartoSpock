using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BPCommunityKataTest
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void FirstGameIsStoneWinWhenSecondIsScissors()
        {
            //Arrange
            var kata = new Game();
            kata.FirstGame = "stone";
            kata.SecondGame = "scissors";
            var expectedResult = "win";

            //Act
            var result = kata.Play(kata.FirstGame, kata.SecondGame);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void FirstGameIsStoneWinWhenSecondIsLizard()
        {
            // Arrange
            var kata = new Game();
            kata.FirstGame = "stone";
            kata.SecondGame = "lizard";
            var expectedResult = "win";

            //Act
            var result = kata.Play(kata.FirstGame, kata.SecondGame);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void FirstGameIsStoneLoseWhenSecondIsPaper()
        {
            //Arrange
            var kata = new Game();
            kata.FirstGame = "stone";
            kata.SecondGame = "paper";
            var expectedResult = "lose";

            //Act
            var result = kata.Play(kata.FirstGame, kata.SecondGame);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void FirstGameIsStoneLoseWhenSecondIsSpock()
        {
            //Arrange
            var kata = new Game();
            kata.FirstGame = "stone";
            kata.SecondGame = "spock";
            var expectedResult = "lose";

            //Act
            var result = kata.Play(kata.FirstGame, kata.SecondGame);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void FirstGameIsPaperWinWhenSecondIsStone()
        {
            //Arrange
            var kata = new Game();
            kata.FirstGame = "paper";
            kata.SecondGame = "stone";
            var expectedResult = "win";

            //Act
            var result = kata.Play(kata.FirstGame, kata.SecondGame);

            //Assert
            Assert.AreEqual(expectedResult, result);

        }

        [TestMethod]
        public void FirstGameIsPaperWinWhenSecondIsSpock()
        {
            //Arrange
            var kata = new Game();
            kata.FirstGame = "paper";
            kata.SecondGame = "spock";
            var expectedResult = "win";

            //Act
            var result = kata.Play(kata.FirstGame, kata.SecondGame);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void FirstGameIsPaperLoseWhenSecondIsScissors()
        {
            //Arrange
            var kata = new Game();
            kata.FirstGame = "paper";
            kata.SecondGame = "scissors";
            var expectedResult = "lose";

            //Act
            var result = kata.Play(kata.FirstGame, kata.SecondGame);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void FirstGameIsPaperLoseWhenSecondIsLizard()
        {
            //Arrange 
            var kata = new Game();
            kata.FirstGame = "paper";
            kata.SecondGame = "lizard";
            var expectedResult = "lose";

            //Act
            var result = kata.Play(kata.FirstGame, kata.SecondGame);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void FirstGameIsScissorsWinWhenSecondIsPaper()
        {
            //Arrange
            var kata = new Game();
            kata.FirstGame = "scissors";
            kata.SecondGame = "paper";
            var expectedResult = "win";

            //Act
            var result = kata.Play(kata.FirstGame, kata.SecondGame);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void FirstGameIsScissorsWinWhenSecondIsLizard()
        {
            //Arrange
            var kata = new Game();
            kata.FirstGame = "scissors";
            kata.SecondGame = "lizard";
            var expectedResult = "win";

            //Act
            var result = kata.Play(kata.FirstGame, kata.SecondGame);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void FirstGameIsScissorsLoseWhenSecondIsStone()
        {
            //Arrange
            var kata = new Game();
            kata.FirstGame = "scissors";
            kata.SecondGame = "stone";
            var expectedResult = "lose";

            //Act
            var result = kata.Play(kata.FirstGame, kata.SecondGame);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void FirstGameIsScissorsLoseWhenSecondIsSpock()
        {
            //Arrange
            var kata = new Game();
            kata.FirstGame = "scissors";
            kata.SecondGame = "spock";
            var expectedResult = "lose";

            //Act
            var result = kata.Play(kata.FirstGame, kata.SecondGame);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void FirstGameIsLizardWinWhenSecondIsSpock()
        {
            //Arrange
            var kata = new Game();
            kata.FirstGame = "lizard";
            kata.SecondGame = "spock";
            var expectedResult = "win";

            //Act 
            var result = kata.Play(kata.FirstGame, kata.SecondGame);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void FirstGameIsLizardWinWhenSecondIsPaper()
        {
            //Arrange
            var kata = new Game();
            kata.FirstGame = "lizard";
            kata.SecondGame = "paper";
            var expectedResult = "win";

            //Act
            var result = kata.Play(kata.FirstGame, kata.SecondGame);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void FirstGameIsLizardLoseWhenSecondIsStone()
        {
            //Arrange
            var kata = new Game();
            kata.FirstGame = "lizard";
            kata.SecondGame = "stone";
            var expectedResult = "lose";

            //Act
            var result = kata.Play(kata.FirstGame, kata.SecondGame);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void FirstGameIsLizardLoseWhenSecondIsScissors()
        {
            //Arrange
            var kata = new Game();
            kata.FirstGame = "lizard";
            kata.SecondGame = "scissors";
            var expectedResult = "lose";

            //Act
            var result = kata.Play(kata.FirstGame, kata.SecondGame);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void FirstGameIsSpockWinWhenSecondIsScissors()
        {
            //Arrange
            var kata = new Game();
            kata.FirstGame = "spock";
            kata.SecondGame = "scissors";
            var expectedResult = "win";

            //Act
            var result = kata.Play(kata.FirstGame, kata.SecondGame);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void FirstGameIsSpockWinWhenSecondIsStone()
        {
            //Arrange
            var kata = new Game();
            kata.FirstGame = "spock";
            kata.SecondGame = "stone";
            var expectedResult = "win";

            //Act
            var result = kata.Play(kata.FirstGame, kata.SecondGame);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void FirstGameIsSpockLoseWhenSecondIsPaper()
        {
            //Arrange
            var kata = new Game();
            kata.FirstGame = "spock";
            kata.SecondGame = "paper";
            var expectedResult = "lose";

            //Act
            var result = kata.Play(kata.FirstGame, kata.SecondGame);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void FirstGameIsSpockLoseWhenSecondIsLizard()
        {
            //Arrange
            var kata = new Game();
            kata.FirstGame = "spock";
            kata.SecondGame = "lizard";
            var expectedResult = "lose";

            //Act
            var result = kata.Play(kata.FirstGame, kata.SecondGame);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
