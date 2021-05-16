using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using RoadTripPlanner.Controllers;
using RoadTripPlanner.Application;
using RoadTripPlanner.Application.Interfaces;
using Moq;
using Microsoft.Extensions.Logging;

namespace RoadTripPlanner.UnitTests.Controllers
{
	public class TripsControllerTests
	{
		private readonly TripsController _controller;

		private readonly Mock<ITripsService> _service;
		private readonly Mock<ILogger<TripsController>> _logger;

		// Test Data
		private readonly IEnumerable<TripDto> _trips;

		public TripsControllerTests()
		{
			_logger = new Mock<ILogger<TripsController>>();
			_service = new Mock<ITripsService>();

			_controller = new TripsController(_logger.Object, _service.Object);

			_trips = new TripDto[] {
					new TripDto() { Id = "nc500", Description = "North Cost 500" },
					new TripDto() { Id = "wc", Description = "Wild Atlantic Way" },
					new TripDto() { Id = "wales", Description = "Wales" }
				};
		}

		[Fact]
		public void GetTrips_Get_ReturnsTrips()
		{
			// Arrange
			_service.Setup(x => x.GetTrips()).Returns(_trips);

			// Act
			var result = _controller.GetTrips();
			var expected = _trips;

			// Assert
			Assert.Equal(expected.Count(), result.Count());
		}

		[Fact]
		public void GetTrips_Get_ReturnsValidTrips()
		{
			// Arrange
			_service.Setup(x => x.GetTrips()).Returns(_trips);

			// Act
			var result = _controller.GetTrips();
			var expected = _trips.FirstOrDefault();

			// Assert
			AssertTripsAreEqual(expected, result.FirstOrDefault());
		}

		private static void AssertTripsAreEqual(TripDto expected, TripDto actual)
		{
			Assert.NotNull(expected);
			Assert.NotNull(actual);
			Assert.Equal(expected.Id, actual.Id);
			Assert.Equal(expected.Description, actual.Description);
		}
	}
}
