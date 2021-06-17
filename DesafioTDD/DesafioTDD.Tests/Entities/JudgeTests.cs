using DesafioTDD.Domain.Entities;
using DesafioTDD.Domain.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesafioTDD.Tests.Entities
{
    [TestClass]
    public class JudgeTests
    {
        [TestMethod]
        [TestCategory("Entities")]
        public void ShouldReturnNullIfPlayersMoveAreEqual() {
            Player player1 = new Player(EHands.Papel);
            Player player2 = new Player(EHands.Papel);

            Judge judge = new Judge(player1, player2);

            Assert.AreEqual(judge.DefineWinner(), null);
        }

        [TestMethod]
        [TestCategory("Entities")]
        public void ShouldReturnPlayer1IfHePlaysRockAgainstScissors() {
            Player player1 = new Player(EHands.Pedra);
            Player player2 = new Player(EHands.Tesoura);

            Judge judge = new Judge(player1, player2);

            Assert.AreEqual(judge.DefineWinner(), player1);
        }

        [TestMethod]
        [TestCategory("Entities")]
        public void ShouldReturnPlayer1IfHePlaysScissorsAgainstPaper() {
            Player player1 = new Player(EHands.Tesoura);
            Player player2 = new Player(EHands.Papel);

            Judge judge = new Judge(player1, player2);

            Assert.AreEqual(judge.DefineWinner(), player1);
        }

        [TestMethod]
        [TestCategory("Entities")]
        public void ShouldReturnPlayer1IfHePlaysPaperAgainstRock() {
            Player player1 = new Player(EHands.Papel);
            Player player2 = new Player(EHands.Pedra);

            Judge judge = new Judge(player1, player2);

            Assert.AreEqual(judge.DefineWinner(), player1);
        }
    }
}