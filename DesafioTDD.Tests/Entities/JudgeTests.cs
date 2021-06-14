using DesafioTDD.Domain.Entities;
using DesafioTDD.Domain.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesafioTDD.Tests.Entities
{
    [TestClass]
    public class JudgeTests
    {
        [TestMethod]
        public void ShouldReturnNullIfPlayersMoveAreEqual() {
            Player player1 = new Player(EHands.Paper);
            Player player2 = new Player(EHands.Paper);

            Judge judge = new Judge(player1, player2);

            Assert.AreEqual(judge.DefineWinner(), null);
        }

        [TestMethod]
        public void ShouldReturnPlayer1IfHePlaysRockAgainstScissors() {
            Player player1 = new Player(EHands.Rock);
            Player player2 = new Player(EHands.Scissors);

            Judge judge = new Judge(player1, player2);

            Assert.AreEqual(judge.DefineWinner(), player1);
        }

        [TestMethod]
        public void ShouldReturnPlayer1IfHePlaysScissorsAgainstPaper() {
            Player player1 = new Player(EHands.Scissors);
            Player player2 = new Player(EHands.Paper);

            Judge judge = new Judge(player1, player2);

            Assert.AreEqual(judge.DefineWinner(), player1);
        }

        [TestMethod]
        public void ShouldReturnPlayer1IfHePlaysPaperAgainstRock() {
            Player player1 = new Player(EHands.Paper);
            Player player2 = new Player(EHands.Rock);

            Judge judge = new Judge(player1, player2);

            Assert.AreEqual(judge.DefineWinner(), player1);
        }
    }
}