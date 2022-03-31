using Microsoft.AspNetCore.Mvc;
using SchoolMessengerAPI.Data;
using SchoolMessengerAPI.Data.Interfaces;
using SchoolMessengerAPI.Models;

namespace SchoolMessengerAPI.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepo _repo;

        public StudentController(IStudentRepo repo)
        {
            _repo = repo;
        }

        [HttpGet("GetById/{id}")]
        public async Task <ActionResult<Student>> GetStudentById(int id)
        {
            var response = await _repo.GetStudentById(id);
            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<Student>>> GetAllStudents()
        {
            var response = await _repo.GetStudents();
            if (response == null || response.Count() ==  0)
            {
                return NotFound();
            }
            return Ok(response);
        }

        [HttpPost("AddStudent")]
        public async Task <ActionResult<Student>> AddStudent(Student aStudent)
        {
            Student response = await _repo.AddStudent(aStudent);
            return Ok(response);
        }

        [HttpDelete("DeleteStudent")]
        public async Task <ActionResult<bool>> DeleteStudentById(int id)
        {
            var response = await _repo.DeleteStudentById(id); 
            return Ok(response);
        }

        [HttpGet("GetByName/{aName}")]
        public async Task<ActionResult<Student>> GetStudetByName(string aName)
        {
            var response = await _repo.GetStudentByName(aName);
            if (response == null)
            {
                return NotFound(aName);
            }
            return Ok(response);
        }
    
        [HttpGet("GetByParentId")]
        public async Task<ActionResult<IEnumerable<Student>>> GetByParentId(int id)
        {
            var response = await _repo.GetByParentId(id);
            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }

        [HttpGet("GetParcialesByStudentId")]
        public async Task<ActionResult<IEnumerable<Student>>> GetParcialesByStudentId(int id)
        {
            var response = await _repo.GetParcialesByStudentId(id);
            if (response == null)
            {       
                return NotFound();
            }
            return Ok(response);
        }

    }
}
