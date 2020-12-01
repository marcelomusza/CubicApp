using CubicApp.Core;
using CubicApp.Core.Interfaces;
using CubicApp.Core.Models;
using CubicApp.Core.Services;
using CubicApp.Logger;
using System;

namespace CubicApp
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                var logger = new ConsoleLogger();
                var engine = new CubicEngine(logger, new CubeBuilderService(), new CubeCollisionService(), new CubeVolumeCalculatorService());


                Console.WriteLine("************************************************************");
                Console.WriteLine("*** Welcome to the Cube Collision and Volume Calculator! ***");
                Console.WriteLine("************************************************************");

                engine.ReadUserInput();

                //Calculating Collision
                if (engine.CalculateCubesCollision())
                    Console.WriteLine("Cubes Collide!");
                else
                    Console.WriteLine("Cubes do not touch each other!");

                //Calculating Volume, if applicable
                var volume = engine.CalculateCubesVolume();
                if (volume == 0)
                    Console.WriteLine("Cubes do not intersect!");
                else
                    Console.WriteLine("Cubes Intersection Volume:{0} ", volume);
            }
            catch (Exception ex)
            {

                Console.WriteLine("A Problem was found while running the application. Log: " + ex.Message);
            }

        }
    }
}
