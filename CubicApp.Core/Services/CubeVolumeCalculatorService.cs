using CubicApp.Core.Interfaces;
using CubicApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CubicApp.Core.Services
{
    public class CubeVolumeCalculatorService : ICubeVolumeCalculatorService
    {

        public double VolumeCalculator(Cube cubeA, Cube cubeB)
        {
            return cubeA.IntersectionVolumeWith(cubeB);
        }

        
    }
}
