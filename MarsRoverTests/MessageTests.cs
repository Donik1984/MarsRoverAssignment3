using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRover;

namespace MarsRoverTests
{
    [TestClass]
    public class MessageTests
    {
        Command[] commands = { new Command("foo", 0), new Command("bar", 20) };

        [TestMethod]
        public void ArgumentNullExceptionThrownIfNameNotPassedToConstructor()
        {
            try
            {
                new Message("", commands);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Command type required.", ex.Message);
            }
        }
        [TestMethod]
        public void ConstructorSetsName()
        {
            Message newMessage = new Message("Rover", commands);
            Assert.AreEqual("Rover", newMessage.Name);
        }
        [TestMethod]
        public void ConstructorSetsCommandsField()
        {
            Message newMessage = new Message("Rover", commands);
        }
    }
}
