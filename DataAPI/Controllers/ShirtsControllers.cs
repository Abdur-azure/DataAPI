using DataAPI.Filters;
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
        [Shirt_ValidationShirtIdFilter]
        public IActionResult GetShirtById(int id)
        {
            return Ok(ShirtRepository.GetShirtById(id));
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
