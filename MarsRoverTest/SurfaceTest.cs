using MarsRoverLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MarsRoverTest
{
    public class SurfaceTest
    {
        [Theory]
        [InlineData("1 2 3")]
        [InlineData("6")]
        [InlineData("4 2 1 5")]
        public void CreateSurface_ThrowsLengthException_WhenInputStringNotHasOnlyOneSpace(string coordinates)
        {
            Assert.Throws<ArgumentException>(() => SurfaceFactory.CreateSurface(coordinates));
        }

        [Theory]
        [InlineData("1 A")]
        [InlineData("B 2")]
        public void CreateSurface_ThrowsIntegerTypeException_WhenInputStringHasChar(string coordinates)
        {
            Assert.Throws<ArgumentException>(() => SurfaceFactory.CreateSurface(coordinates));
        }

        [Theory]
        [InlineData("5 5")]
        [InlineData("7 8")]
        public void CreateSurface_ReturnsISurface_WhenInputInCorrectFormat(string coordinates)
        {
            ISurface surface = SurfaceFactory.CreateSurface(coordinates);
            Assert.NotNull(surface);
            Assert.True(surface.X > 0 && surface.Y > 0);
        }
    }
}
