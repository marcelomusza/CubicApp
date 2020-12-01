using CubicApp.Core.Interfaces;
using CubicApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CubicApp.Core.Services
{
    public class CubeBuilderService : ICubeBuilderService
    {
        private Point center;
        private double edgeLength;

        public CubeBuilderService Cube()
        {
            return new CubeBuilderService();
        }
        public CubeBuilderService Location(double x, double y, double z)
        {
            center = new Point(x, y, z);
            return this;
        }
        public CubeBuilderService EdgeLength(double length)
        {
            edgeLength = length;
            return this;
        }
        public Cube Build()
        {
            return new Cube(center, edgeLength);
        }
    }
}
