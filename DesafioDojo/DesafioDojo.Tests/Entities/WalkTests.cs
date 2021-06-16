using System.Collections.Generic;
using DesafioDojo.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesafioDojo.Tests.Entities
{
    [TestClass]
    public class WalkTests
    {
        [TestMethod]
        public void ShouldReturnLightsOnOffOffIfPassedAListWith3Lights() {
            var lights = new List<Light>();
            for (int i = 0; i < 3; i++) {
                var light = new Light();
                lights.Add(light);
            }

            Walk.SwitchLights(lights);

            Assert.AreEqual(lights[0].On, true);
            Assert.AreEqual(lights[1].On, false);
            Assert.AreEqual(lights[2].On, false);
        }
    }
}