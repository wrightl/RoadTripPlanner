using System;
using System.Collections.Generic;

namespace RoadTripPlanner.Application.Interfaces
{
	public interface ITripsService
	{
		IEnumerable<TripDto> GetTrips();

	}
}
