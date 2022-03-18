using Microsoft.AspNetCore.Mvc;
using SchoolMessengerAPI.Data;
using SchoolMessengerAPI.Models;

namespace SchoolMessengerAPI.Controllers
{
    [ApiController]
    [Route("api/Student")]
    public class StudentController : ControllerBase
    {
        readonly MockSchoolRepo _repo = new();

        public StudentController()
        {
            
        }

        [HttpGet("{id}")]
        public ActionResult<Student> GetStudentById(int id)
        {
            var response = _repo.GetStudentById(id);
            return Ok(response);
        }

    }
}
