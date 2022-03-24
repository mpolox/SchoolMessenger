using Microsoft.AspNetCore.Mvc;
using SchoolMessengerAPI.Data;
using SchoolMessengerAPI.Models;

namespace SchoolMessengerAPI.Controllers
{
    [ApiController]
    [Route("api/parents")]
    public class ParentController : ControllerBase
    {
        private readonly ISchoolRepo _repo;

        public ParentController(ISchoolRepo repo)
        {
            _repo = repo;
        }

        [HttpGet("GetById/{id}")]
        public ActionResult<Parent> GetParentById(int id)   
        {
            var response = _repo.GetParentById(id);
            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }

        [HttpGet("GetAll")]
        public ActionResult<IEnumerable<Parent>> GetAllParents()
        {
            var response = _repo.GetParents();
            if (response == null || response.Count() == 0)
            {
                return NotFound();
            }
            return Ok(response);
        }

        [HttpPost("AddParent")]
        public ActionResult<Parent> AddParent(Parent aParent)
        {
            Parent response = _repo.AddParent(aParent);
            return Ok(response);
        }

        [HttpDelete("DeleteParent")]
        public ActionResult<bool> DeleteParentById(int id)
        {
            var response = _repo.DeleteParenttById(id);
            return Ok(response);
        }

        [HttpGet("GetByName/{aName}")]
        public ActionResult<Parent> GetParentByName(string aName)
        {
            var response = _repo.GetParentByName(aName);
            if (response == null)
            {
                return NotFound(aName);
            }
            return Ok(response);
        }
    }
}
