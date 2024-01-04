using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using WebApplication1.Dto.SubjectClass;
using WebApplication1.Entities;
using WebApplication1.Services.Implements;
using WebApplication1.Services.Interfaces;

namespace WebApplication1.Controllers
{
    [Route("api/subjectclass")]
    [ApiController]
    public class SubjectClassController : ControllerBase
    {
        private readonly ISubjectClass _subjectclassService;

        public SubjectClassController(ISubjectClass subjectclassService)
        {
            _subjectclassService = subjectclassService;
        }

        [HttpPost("create")]
        public IActionResult Create(CreateSubjectClassDto input)
        {
            try
            {
                _subjectclassService.Create(input);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("update")]
        public IActionResult Update(UpdateSubjectClassDto input)
        {
            try
            {
                _subjectclassService.Update(input);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_subjectclassService.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("get-by-id/{id}")]
        public IActionResult GetById([Range(1, int.MaxValue, ErrorMessage = "Id phải lớn hơn 0")] int id)
        {
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete()
        {
            try
            {
                
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
