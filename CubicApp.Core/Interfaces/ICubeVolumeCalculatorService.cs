using CubicApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CubicApp.Core.Interfaces
{
    public interface ICubeVolumeCalculatorService
    {
        double VolumeCalculator(Cube cubeA, Cube cubeB);
    }
}
