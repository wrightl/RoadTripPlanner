using System;
using System.Collections.Generic;
using RoadTripPlanner.Core.Models;

namespace RoadTripPlanner.Core.Repositories
{
	public interface ITripsRepository
	{
		IEnumerable<Trip> GetTrips();
	}
}
