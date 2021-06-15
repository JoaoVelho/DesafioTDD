using System;
using System.IO;
using DesafioTDD.Domain.Enums;
using DesafioTDD.Domain.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesafioTDD.Tests.Utils
{
    [TestClass]
    public class UserEntryTests
    {
        [TestMethod]
        public void ShouldReturnZeroIfNonNumericIsPassed() {
            var input = new StringReader("abc");
            Console.SetIn(input);

            EHands move = UserEntry.GetMove(1);
            Assert.AreEqual(move, (EHands) 0);
        }

        [TestMethod]
        public void ShouldReturnTheSelectedMoveIfValidNumberIsPassed() {
            var input = new StringReader("2");
            Console.SetIn(input);

            EHands move = UserEntry.GetMove(1);
            Assert.AreEqual(move, EHands.Papel);
        }
    }
}