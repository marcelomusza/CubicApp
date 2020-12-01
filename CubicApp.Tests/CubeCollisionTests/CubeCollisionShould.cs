using CubicApp.Core;
using CubicApp.Core.Services;
using CubicApp.Logger;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CubicApp.Tests.CubeCollisionTests
{
    public class CubeVolumenShould
    {
        [Fact]
        public void CubesDoNotIntersect()
        {
            //Arrange
            var logger = new ConsoleLogger();
            double cubeAcoordx = 2, cubeAcoordy = 2, cubeAcoordz = 2, cubeAlength = 2;
            double cubeBcoordx = 10, cubeBcoordy = 10, cubeBcoordz = 10, cubeBlength = 2;                  
            var sut = new CubicEngine(logger, new CubeBuilderService(), new CubeCollisionService(), new CubeVolumeCalculatorService());
            sut.cubeA = sut.BuildCube(cubeAcoordx, cubeAcoordy, cubeAcoordz, cubeAlength);
            sut.cubeB = sut.BuildCube(cubeBcoordx, cubeBcoordy, cubeBcoordz, cubeBlength);

            //Act
            var result = sut.CalculateCubesVolume();

            //Assert
            Assert.Equal(0, result);


        }

        [Fact]
        public void CubesVolumen()
        {
            //Arrange
            var logger = new ConsoleLogger();
            double cubeAcoordx = 2, cubeAcoordy = 2, cubeAcoordz = 2, cubeAlength = 2;
            double cubeBcoordx = 3, cubeBcoordy = 2, cubeBcoordz = 2, cubeBlength = 2;
            var sut = new CubicEngine(logger, new CubeBuilderService(), new CubeCollisionService(), new CubeVolumeCalculatorService());
            sut.cubeA = sut.BuildCube(cubeAcoordx, cubeAcoordy, cubeAcoordz, cubeAlength);
            sut.cubeB = sut.BuildCube(cubeBcoordx, cubeBcoordy, cubeBcoordz, cubeBlength);

            //Act
            var result = sut.CalculateCubesVolume();

            //Assert
            Assert.True(result > 0);


        }
    }
}
