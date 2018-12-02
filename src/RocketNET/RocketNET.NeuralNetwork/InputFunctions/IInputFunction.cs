using System;
using System.Collections.Generic;
using System.Text;
using RocketNET.NeuralNetwork.Synapses;

namespace RocketNET.NeuralNetwork.InputFunctions
{
    public interface IInputFunction
    {
        double CalculateInput(List<ISynapse> inputs);
    }
}
