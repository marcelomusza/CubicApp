using CubicApp.Core.Interfaces;
using CubicApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CubicApp.Core.Services
{
    public class CubeCollisionService : ICubeCollisionService
    {

        
        public bool CollisionDetector(Cube cubeA, Cube cubeB)
        {
            //Service that calculates if two cubes touch/overlap themselves, or have no contact
            return cubeA.CollidesWith(cubeB);

        }
                
    }
}
