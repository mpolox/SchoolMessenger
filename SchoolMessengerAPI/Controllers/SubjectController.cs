using Microsoft.AspNetCore.Mvc;
using SchoolMessengerAPI.Data.Interfaces;
using SchoolMessengerAPI.Models;

namespace SchoolMessengerAPI.Controllers
{
    [ApiController]
    [Route("api/Subject")]
    public class SubjectController : ControllerBase
    {
        private readonly ISubjectRepo _repo;

        public SubjectController(ISubjectRepo repo)
        {
            _repo = repo;
        }

        [HttpGet("GetById")]
        public async Task<ActionResult> GetById(int id)
        {
            var response = await _repo.GetById(id);
            if (response is null)
            {
                return NotFound();
            }
            return Ok(response);
        }

        [HttpPost("AddSubject")]
        public async Task<ActionResult> AddSubject(Subject subject)
        {
            var response = await _repo.AddSubject(subject);
            return Ok(response);
        }


        [HttpGet("GetSubjects")]
        public async Task<ActionResult<IEnumerable<Subject>>> GetSubjects()
        {
            var response = await _repo.GetSubjects();
            return Ok(response);
        }

        [HttpGet("GetByCredits")]
        public async Task<ActionResult<IEnumerable<Subject>>> GetByCredits(int credits)
        {
            var response = await _repo.GetByCredits(credits);
            if (response is null || response.Count() == 0)
            {
                return NotFound();
            }
            return Ok(response);
        }
    }
}
