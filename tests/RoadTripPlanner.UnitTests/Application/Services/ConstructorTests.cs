using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using RoadTripPlanner.Core.Repositories;
using RoadTripPlanner.Application;
using RoadTripPlanner.Application.Services;
using RoadTripPlanner.Core.Models;
using Moq;

namespace RoadTripPlanner.UnitTests.Application.Services
{
    public class ConstructorTests
    {
        [Fact]
        public void GetTrips_Constructor_ReturnsOkWithAllParameter()
        {
            // Arrange
            var repository = new Mock<ITripsRepository>();

            // Act
            var result = new TripsService(repository.Object);

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void GetTrips_Constructor_ThrowsExceptionOnNullLogger()
        {
            // Arrange

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new TripsService(null));
        }
    }
}
