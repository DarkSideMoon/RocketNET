using System;
using System.Collections.Generic;
using System.Text;

namespace RocketNET.NeuralNetwork.ActivationFunctions
{
    public interface IActivationFunction
    {
        double CalculateOutput(double input);
    }
}
