using MediatR;
using Microsoft.AspNetCore.Mvc;
using Molntjanster.UseCases.ManageStudents;
using Molntjanster.UseCases.ManageStudents.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{name}")]
        public async Task<List<StudentModel>> Get(string name)
        {
            return await _mediator.Send(new Read.GetStudentByStudentNameQuery(name));
        }
    }
}
