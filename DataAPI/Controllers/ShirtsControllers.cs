using DataAPI.Models;
using DataAPI.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DataAPI.Controllers
{
    [ApiController]
    public class ShirtsControllers : ControllerBase
    {
        [HttpGet]
        [Route("/shirts/{id}")]
        public IActionResult GetShirtById(int id)
        {
            if (id <= 0)
                return BadRequest();

            var shirt = ShirtRepository.GetShirtById(id);

            if (shirt == null)
                return NotFound();

            return Ok(shirt);
        }

        [HttpPost]
        [Route("/shirts")]
        public IActionResult CreateShirt([FromBody]Shirt shirt)
        {
            return Ok("Creating a shirt");
        }

        [HttpPut]
        [Route("/shirts/{id}")]
        public IActionResult UpdateShirtById(int id)
        {
            return Ok("Updating shirt with ID: {id}");
        }

        [HttpDelete]
        [Route("/shirts/{id}")]
        public IActionResult DeleteShirtById(int id)
        {
            return Ok("Deleting shirt with ID: {id}");
        }


    }
}
