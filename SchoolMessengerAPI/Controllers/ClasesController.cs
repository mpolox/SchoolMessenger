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

        [HttpGet("GetByCredits/{credits}")]
        public async Task<ActionResult<IEnumerable<Student>>> GetClaseByCredit(int credits)
        {
            var response = await _repo.GetClaseByCredit(credits);
            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }

        [HttpGet("GetByShortName/{shortName}")]
        public async Task<ActionResult<IEnumerable<Student>>> GetByShortName(string shortName)
        {
            var response = await _repo.GetClaseByShortName(shortName);
            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }

        [HttpGet("GetByStudentId/{id}")]
        public async Task<ActionResult<IEnumerable<Student>>> GetByStudentId(int id)
        {
            var response = await _repo.GetClasesByStudentId(id);
            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }

    }
}
