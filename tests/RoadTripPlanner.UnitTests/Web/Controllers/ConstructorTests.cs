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
	public class ConstructorTests
	{
		[Fact]
		public void GetTrips_Constructor_ReturnsOkWithAllParameter()
		{
			// Arrange
			var _logger = new Mock<ILogger<TripsController>>();
			var _service = new Mock<ITripsService>();

			// Act
			var controller = new TripsController(_logger.Object, _service.Object);

			// Assert
			Assert.NotNull(controller);
		}

		[Fact]
		public void GetTrips_Constructor_ThrowsExceptionOnNullLogger()
		{
			// Arrange
			var _service = new Mock<ITripsService>();

			// Act & Assert
			Assert.Throws<ArgumentNullException>(() => new TripsController(null, _service.Object));
		}

		[Fact]
		public void GetTrips_Constructor_ThrowsExceptionOnNullService()
		{
			// Arrange
			var _logger = new Mock<ILogger<TripsController>>();

			// Act & Assert
			Assert.Throws<ArgumentNullException>(() => new TripsController(_logger.Object, null));
		}

		[Fact]
		public void GetTrips_Constructor_ThrowsExceptionOnNullParameters()
		{
			// Arrange

			// Act & Assert
			Assert.Throws<ArgumentNullException>(() => new TripsController(null, null));
		}
	}
}
