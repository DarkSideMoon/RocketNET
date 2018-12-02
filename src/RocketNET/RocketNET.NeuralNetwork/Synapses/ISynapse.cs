﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RocketNET.NeuralNetwork.Synapses
{
    public interface ISynapse
    {
        double Weight { get; set; }
        double PreviousWeight { get; set; }
        double GetOutput();

        bool IsFromNeuron(Guid fromNeuronId);
        void UpdateWeight(double learningRate, double delta);
    }
}
