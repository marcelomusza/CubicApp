using CubicApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CubicApp.Core.Interfaces
{
    public interface ICubeCollisionService
    {
        bool CollisionDetector(Cube cubeA, Cube cubeB);
    }
}
