using System;
using System.Collections.Generic;
using System.Text;

namespace RocketNET.NeuralNetwork.ActivationFunctions
{
    public class RectifiedActivationFuncion : IActivationFunction
    {
        public double CalculateOutput(double input)
        {
            return Math.Max(0, input);
        }
    }
}
