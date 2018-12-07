using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RocketNET.NeuralNetwork.ActivationFunctions;

namespace RocketNET.NeuralNetwork.Tests
{
    [TestClass]
    public class SigmoidFunctionTest
    {
        [TestMethod]
        public void CalculateOutput_InputPassed_CorrectOutput()
        {
            var sigmoidFuncion = new SigmoidActivationFunction(1);

            Assert.AreEqual(0.557247854598556, Math.Round(sigmoidFuncion.CalculateOutput(0.23), 15));
        }
    }
}
