using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RoadTripPlanner.Application;
using RoadTripPlanner.Application.Interfaces;

namespace RoadTripPlanner.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class TripsController : ControllerBase
    {

        private readonly ILogger<TripsController> _logger;
        private readonly ITripsService _service;

        public TripsController(ILogger<TripsController> logger, ITripsService service)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        [HttpGet]
        public IEnumerable<TripDto> GetTrips()
        {
            _logger.LogInformation("Getting Trips");
            var results = _service.GetTrips();
            _logger.LogInformation("Finished getting trips");
            return results;
        }
    }
}
