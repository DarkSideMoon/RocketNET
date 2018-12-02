using System;
using System.Collections.Generic;
using System.Text;
using RocketNET.NeuralNetwork.ActivationFunctions;
using RocketNET.NeuralNetwork.InputFunctions;

namespace RocketNET.NeuralNetwork
{
    public class NeuralLayerFactory
    {
        public NeuralLayer CreateNeuralLayer(
            int numberOfNeurons, 
            IActivationFunction activationFunction, 
            IInputFunction inputFunction)
        {
            var layer = new NeuralLayer();

            for (int i = 0; i < numberOfNeurons; i++)
            {
                var neuron = new Neuron.Neuron(activationFunction, inputFunction);
                layer.Neurons.Add(neuron);
            }

            return layer;
        }
    }
}
