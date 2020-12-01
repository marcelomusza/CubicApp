using CubicApp.Core.Models;
using CubicApp.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CubicApp.Core.Interfaces
{
    public interface ICubeBuilderService
    {
        CubeBuilderService Cube();
        CubeBuilderService Location(double x, double y, double z);
        CubeBuilderService EdgeLength(double length);        

    }
}
