﻿using Microsoft.AspNetCore.Mvc;
using SchoolMessengerAPI.Data;
using SchoolMessengerAPI.Models;

namespace SchoolMessengerAPI.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentController : ControllerBase
    {
        private readonly ISchoolRepo _repo;

        public StudentController(ISchoolRepo repo)
        {
            _repo = repo;
        }

        [HttpGet("{id}")]
        public ActionResult<Student> GetStudentById(int id)
        {
            var response = _repo.GetStudentById(id);
            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }

        [HttpGet("GetAll")]
        public ActionResult<IEnumerable<Student>> GetAllStudents()
        {
            var response = _repo.GetStudents();
            if (response == null || response.Count() ==  0)
            {
                return NotFound();
            }
            return Ok(response);
        }

        [HttpPost("AddStudent")]
        public ActionResult<Student> AddStudent(Student aStudent)
        {
            Student response = _repo.AddStudent(aStudent);
            return Ok(response);
        }

        [HttpDelete("DeleteStudent")]
        public ActionResult<bool> DeleteStudentById(int id)
        {
            var response = _repo.DeleteStudentById(id); 
            return Ok(response);
        }


    }
}
