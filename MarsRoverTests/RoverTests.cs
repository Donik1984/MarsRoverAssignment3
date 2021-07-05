using System;
using System.Collections.Generic;
using MarsRover;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRoverTests
{
    [TestClass]
    public class RoverTests
    {
        [TestMethod]
        public void ConstructorSetsDefaultPosition()
        {
            Rover newRover = new Rover(8000);
            Assert.AreEqual(8000, newRover.Position);
        }
        [TestMethod]
        public void ConConstructorSetsDefaultMode()
        {
            Rover newRover = new Rover(8000);
            Assert.AreEqual("Normal", newRover.Mode);
        }
        [TestMethod]
        public void ConstructorSetsDefaultGeneratorWatts()
        {
            Rover newRover = new Rover(8000);
            Assert.AreEqual(110, newRover.GeneratorWatts);
        }
        [TestMethod]
        public void RespondsCorrectlyToModeChangeCommand()
        {
            Rover newRover = new Rover(8000, "MODE_CHANGE");
            Assert.AreEqual("Low Power", newRover.Mode);
        }
        [TestMethod]
        public void DoesNotMoveInLowPower()
        {
            Rover newRover = new Rover(8000, "MODE_CHANGE");
            Assert.AreEqual(0, newRover.Position);
        }
        [TestMethod]
        public void PositionChangesFromMoveCommand()
        {
            Rover newRover = new Rover(98615, "Normal");
            Assert.AreEqual(98615, newRover.Position);
        }
    }
}
