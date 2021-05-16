using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using RoadTripPlanner.Application;
using RoadTripPlanner.Application.Interfaces;
using RoadTripPlanner.Core.Models;
using RoadTripPlanner.Infrastructure.Repositories;
using Moq;
using Microsoft.Extensions.Logging;

namespace RoadTripPlanner.UnitTests.Repositories
{
	public class TripsRepositoryTests
	{
		private readonly TripsRepository _repository;

		private readonly IEnumerable<Trip> _trips;

		public TripsRepositoryTests()
		{
			_repository = new TripsRepository();

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

			// Act
			var result = _repository.GetTrips();
			var expected = _trips;

			// Assert
			Assert.Equal(expected.Count(), result.Count());
		}

		[Fact]
		public void GetTrips_Get_ReturnsValidTrips()
		{
			// Arrange

			// Act
			var result = _repository.GetTrips();
			var expected = _trips.FirstOrDefault();

			// Assert
			AssertTripsAreEqual(expected, result.FirstOrDefault());
		}

		private static void AssertTripsAreEqual(Trip expected, Trip actual)
		{
			Assert.NotNull(expected);
			Assert.NotNull(actual);
			Assert.Equal(expected.Id, actual.Id);
			Assert.Equal(expected.Description, actual.Description);
		}
	}
}
