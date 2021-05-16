using System;
using System.Collections.Generic;
using System.Linq;
using RoadTripPlanner.Application.Interfaces;
using RoadTripPlanner.Core.Repositories;

namespace RoadTripPlanner.Application.Services
{
    public class TripsService : ITripsService
    {
        private readonly ITripsRepository _repository;

        public TripsService(ITripsRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public IEnumerable<TripDto> GetTrips()
        {
            var trips = _repository.GetTrips();


            return trips.Select(entry => new TripDto() { Id = entry.Id, Description = entry.Description });
        }

    }
}
