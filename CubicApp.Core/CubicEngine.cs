using CubicApp.Core.Helpers;
using CubicApp.Core.Interfaces;
using CubicApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CubicApp.Core
{
    public class CubicEngine
    {
        private readonly ILogger _logger;
        private readonly ICubeBuilderService _cubeBuilderService;
        private readonly ICubeCollisionService _cubeCollisionService;
        private readonly ICubeVolumeCalculatorService _cubeVolumeCalculatorService;

        public Cube cubeA { get; set; }
        public Cube cubeB { get; set; }

        public CubicEngine(ILogger logger,
            ICubeBuilderService cubeBuilderService,
            ICubeCollisionService cubeCollisionService,
            ICubeVolumeCalculatorService cubeVolumeCalculatorService)
        {
            _logger = logger;
            _cubeBuilderService = cubeBuilderService;
            _cubeCollisionService = cubeCollisionService;
            _cubeVolumeCalculatorService = cubeVolumeCalculatorService;
        }

        public Cube BuildCube(double coordX, double coordY, double coordZ, double length)
        {
            return _cubeBuilderService.Cube().Location(coordX, coordY, coordZ).EdgeLength(length).Build();
        }
        
        public void ReadUserInput()
        {

            double coordX, coordY, coordZ, length;
            ConsoleStreamer consoleHelper = new ConsoleStreamer();

            // CUBE A
            _logger.Log("Please Enter the Coordinates of Cube A...");
            _logger.Log("Coordinate X: ");
            coordX = consoleHelper.ReadNumber();

            _logger.Log("Coordinate Y: ");
            coordY = consoleHelper.ReadNumber();

            _logger.Log("Coordinate Z: ");
            coordZ = consoleHelper.ReadNumber();

            _logger.Log("Please enter the length: ");
            length = consoleHelper.ReadNumber();

            _logger.Log("*** CUBE A -- X:" + coordX + ", Y:" + coordY + ", Z:" + coordZ + ", Length: " + length + " ***\n");
            cubeA = BuildCube(coordX, coordY, coordZ, length);

            // CUBE B
            _logger.Log("Please Enter the Coordinates of Cube B...");
            _logger.Log("Coordinate X: ");
            coordX = consoleHelper.ReadNumber();

            _logger.Log("Coordinate Y: ");
            coordY = consoleHelper.ReadNumber();

            _logger.Log("Coordinate Z: ");
            coordZ = consoleHelper.ReadNumber();

            _logger.Log("Please enter the length: ");
            length = consoleHelper.ReadNumber();

            _logger.Log("*** CUBE B -- X:" + coordX + ", Y:" + coordY + ", Z:" + coordZ + ", Length: " + length + " ***\n");
            cubeB = BuildCube(coordX, coordY, coordZ, length);
            
        }

        public bool CalculateCubesCollision()
        {
            return _cubeCollisionService.CollisionDetector(cubeA, cubeB);
        }

        public double CalculateCubesVolume()
        {
            return _cubeVolumeCalculatorService.VolumeCalculator(cubeA, cubeB);
        }
        
    }
}
