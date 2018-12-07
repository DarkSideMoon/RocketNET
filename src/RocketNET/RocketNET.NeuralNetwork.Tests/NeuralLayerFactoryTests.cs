using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RocketNET.NeuralNetwork.ActivationFunctions;
using RocketNET.NeuralNetwork.InputFunctions;

namespace RocketNET.NeuralNetwork.Tests
{
    [TestClass]
    public class NeuralLayerFactoryTests
    {
        [TestMethod]
        public void CreateNeuralLayer_NumberOfNeuronsPasses_CorrectLayerCreated()
        {
            var neuralLayerFactory = new NeuralLayerFactory();
            var neuralLayer = neuralLayerFactory.CreateNeuralLayer(11, new StepActivationFunction(0.5), new WeightedSumFunction());

            Assert.AreEqual(11, neuralLayer.Neurons.Count);
        }
    }
}
