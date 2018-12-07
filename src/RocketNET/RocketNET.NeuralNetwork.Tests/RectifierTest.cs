using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RocketNET.NeuralNetwork.ActivationFunctions;

namespace RocketNET.NeuralNetwork.Tests
{
    [TestClass]
    public class RectifierTest
    {
        [TestMethod]
        public void CalculateOutput_InputLargerThanZeroPassed_CorrectOutput()
        {
            var rectifier = new RectifiedActivationFuncion();

            Assert.AreEqual(0.23, rectifier.CalculateOutput(0.23));
        }

        [TestMethod]
        public void CalculateOutput_InputSmallerThanZeroPassed_CorrectOutput()
        {
            var rectifier = new RectifiedActivationFuncion();

            Assert.AreEqual(0, rectifier.CalculateOutput(-0.23));
        }
    }
}
