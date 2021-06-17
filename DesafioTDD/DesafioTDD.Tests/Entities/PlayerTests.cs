using System;
using DesafioTDD.Domain.Entities;
using DesafioTDD.Domain.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesafioTDD.Tests.Entities
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        [TestCategory("Entities")]
        public void ShouldReturnFalseIfFailToValidate() {
            Enum.TryParse("4", out EHands play1);
            Enum.TryParse("0", out EHands play2);

            Assert.AreEqual(Player.Validate(play1), false);
            Assert.AreEqual(Player.Validate(play2), false);
        }

        [TestMethod]
        [TestCategory("Entities")]
        public void ShouldReturnTrueIfValidate() {
            Enum.TryParse("2", out EHands play);

            Assert.AreEqual(Player.Validate(play), true);
        }
    }
}