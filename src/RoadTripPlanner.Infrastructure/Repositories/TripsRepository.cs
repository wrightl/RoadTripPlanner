using System;
using System.Collections.Generic;
using RoadTripPlanner.Core.Models;
using RoadTripPlanner.Core.Repositories;

namespace RoadTripPlanner.Infrastructure.Repositories
{
    public class TripsRepository : ITripsRepository
    {
        public IEnumerable<Trip> GetTrips()
        {
            return new Trip[]
                {
                    new Trip() { Id = "nc500", Description = "North Cost 500" },
                    new Trip() { Id = "wc", Description = "Wild Atlantic Way" },
                    new Trip() { Id = "wales", Description = "Wales" }
                };
        }
    }
}