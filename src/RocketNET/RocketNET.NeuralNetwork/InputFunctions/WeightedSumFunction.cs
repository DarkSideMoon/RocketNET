using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RocketNET.NeuralNetwork.Synapses;

namespace RocketNET.NeuralNetwork.InputFunctions
{
    public class WeightedSumFunction : IInputFunction
    {
        public double CalculateInput(List<ISynapse> inputs)
        {
            return inputs.Select(x => x.Weight * x.GetOutput()).Sum();
        }
    }
}
