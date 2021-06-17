using DesafioDojo.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesafioDojo.Tests.Entities
{
    [TestClass]
    public class LightTests
    {
        [TestMethod]
        [TestCategory("Entities")]
        public void ShouldSetOnAsTrueIfItIsFalse() {
            Light light = new Light();

            light.Switch();
            Assert.AreEqual(light.On, true);
        }

        [TestMethod]
        [TestCategory("Entities")]
        public void ShouldSetOnAsFalseIfItIsTrue() {
            Light light = new Light();

            light.Switch();
            light.Switch();
            Assert.AreEqual(light.On, false);
        }
    }
}