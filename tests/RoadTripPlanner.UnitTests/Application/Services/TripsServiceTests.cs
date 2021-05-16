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
    public class TripsServiceTests
    {
        private readonly TripsService _service;

        private readonly Mock<ITripsRepository> _repository;

        // Test Data
        private readonly IEnumerable<Trip> _trips;

        public TripsServiceTests()
        {
            _repository = new Mock<ITripsRepository>();

            _service = new TripsService(_repository.Object);

            _trips = new Trip[] {
                    new Trip() { Id = "nc500", Description = "North Cost 500" },
                    new Trip() { Id = "wc", Description = "Wild Atlantic Way" },
                    new Trip() { Id = "wales", Description = "Wales" }
                };
        }

        [Fact]
        public void GetTrips_Get_ReturnsTrips()
        {
            // Arrange
            _repository.Setup(x => x.GetTrips()).Returns(_trips);

            // Act
            var result = _service.GetTrips();
            var expected = _trips;

            // Assert
            Assert.Equal(expected.Count(), result.Count());
        }

        [Fact]
        public void GetTrips_Get_ReturnsValidTrips()
        {
            // Arrange
            _repository.Setup(x => x.GetTrips()).Returns(_trips);

            // Act
            var result = _service.GetTrips();
            var expected = _trips.FirstOrDefault();

            // Assert
            AssertTripsAreEqual(expected, result.FirstOrDefault());
        }

        private static void AssertTripsAreEqual(Trip expected, TripDto actual)
        {
            Assert.NotNull(expected);
            Assert.NotNull(actual);
            Assert.Equal(expected.Id, actual.Id);
            Assert.Equal(expected.Description, actual.Description);
        }
    }
}
