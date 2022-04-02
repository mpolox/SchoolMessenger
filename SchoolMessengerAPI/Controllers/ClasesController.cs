using Microsoft.AspNetCore.Mvc;
using SchoolMessengerAPI.Data.Interfaces;
using SchoolMessengerAPI.Models;

namespace SchoolMessengerAPI.Controllers
{
    [ApiController]
    [Route("api/Clases")]
    public class ClasesController : ControllerBase
    {
        private readonly IClasesRepo _repo;

        public ClasesController(IClasesRepo repo)
        {
            _repo = repo;
        }

        [HttpGet("GetById/{id}")]
        public async Task<ActionResult<IEnumerable<Student>>> GetClaseById(int id)
        {
            var response = await _repo.GetClasesByX();
            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }
    }
}
