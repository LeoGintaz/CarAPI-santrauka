using CarAPI_santrauka.Models.Dto;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace CarAPI_santrauka.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {


        private readonly ILogger<CarController> _logger;

        public CarController(ILogger<CarController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Gaunamas duomenu bazeje esanciu automobiliu sarasas
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetCarResult>))]
        [Produces(MediaTypeNames.Application.Json)] // Swagerija nustato media type kaip JSON, kitu carijaciju nebelieka.
        public IActionResult Get()
        {
            return Ok();
            
        }
    }
}