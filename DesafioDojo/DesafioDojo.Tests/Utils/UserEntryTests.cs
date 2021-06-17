using System;
using System.IO;
using DesafioDojo.Domain.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesafioDojo.Tests.Utils
{
    [TestClass]
    public class UserEntryTests
    {
        [TestMethod]
        [TestCategory("Utils")]
        public void ShouldReturnZeroIfNonNumericIsPassed() {
            var input = new StringReader("abc");
            Console.SetIn(input);

            int number = UserEntry.GetNumber();
            Assert.AreEqual(number, 0);
        }

        [TestMethod]
        [TestCategory("Utils")]
        public void ShouldReturnZeroIfNumberLessThanOneIsPassed() {
            var input = new StringReader("-5");
            Console.SetIn(input);

            int number = UserEntry.GetNumber();
            Assert.AreEqual(number, 0);
        }

        [TestMethod]
        [TestCategory("Utils")]
        public void ShouldReturnTheNumberPassedIfItIsValid() {
            var input = new StringReader("4");
            Console.SetIn(input);

            int number = UserEntry.GetNumber();
            Assert.AreEqual(number, 4);
        }
    }
}