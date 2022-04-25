﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SchoolMessengerAPI.Data.Interfaces;
using SchoolMessengerAPI.Dtos;
using SchoolMessengerAPI.Dtos.Read;
using SchoolMessengerAPI.Models;

namespace SchoolMessengerAPI.Controllers
{
    [ApiController]
    [Route("api/Clases")]
    public class ClasesController : ControllerBase
    {
        private readonly IClasesRepo _repo;
        private readonly IMapper _mapper;

        public ClasesController(IClasesRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
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

        [HttpGet("GetByStudentName/{studentName}")]
        public async Task<ActionResult<IEnumerable<ClaseDto>>> GetByStudentName(string studentName="Marcopolo")
        {
            var response = await _repo.GetClaseaByStudentName(studentName);
            //var myResponse2 = _mapper.Map<IEnumerable<ClaseDto>>(response);
            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }

        [HttpGet("GetByStudentMatricula/{matricula}")]
        public async Task<ActionResult<IEnumerable<Student>>> GetClasesByStudentMatricula(string matricula)
        {
            var response = await _repo.GetClasesByStudentMatricula(matricula);
            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }

        [HttpGet("GetClases")]
        public async Task<ActionResult<IEnumerable<Student>>> GetClases()
        {
            var response = await _repo.GetClases();
            if (response == null || !response.Any() )
            {
                return NotFound();
            }
            return Ok(response);
        }
    }
}
