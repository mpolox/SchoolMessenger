using Microsoft.AspNetCore.Mvc;
using SchoolMessengerAPI.Data;
using SchoolMessengerAPI.Data.Interfaces;
using SchoolMessengerAPI.Models;

namespace SchoolMessengerAPI.Controllers
{
    [ApiController]
    [Route("api/parents")]
    public class ParentController : ControllerBase
    {
        private readonly IParentRepo _repo;

        public ParentController(IParentRepo repo)
        {
            _repo = repo;
        }

        [HttpGet("GetById/{id}")]
        public async Task<ActionResult<Parent>> GetParentById(int id)   
        {
            var response = await _repo.GetParentById(id);
            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<Parent>>> GetAllParents()
        {
            var response = await _repo.GetParents();
            if (response == null || response.Count() == 0)
            {
                return NotFound();
            }
            return Ok(response);
        }

        [HttpPost("AddParent")]
        public async Task<ActionResult<Parent>> AddParent(Parent aParent)
        {
            Parent response = await _repo.AddParent(aParent);
            return Ok(response);
        }

        [HttpDelete("DeleteParent")]
        public async Task<ActionResult<bool>> DeleteParentById(int id)
        {
            var response = await _repo.DeleteParenttById(id);
            return Ok(response);
        }

        [HttpGet("GetByName/{aName}")]
        public async Task <ActionResult<Parent>> GetParentByName(string aName)
        {
            var response = await _repo.GetParentByName(aName);
            if (response == null)
            {
                return NotFound(aName);
            }
            return Ok(response);
        }
    }
}
