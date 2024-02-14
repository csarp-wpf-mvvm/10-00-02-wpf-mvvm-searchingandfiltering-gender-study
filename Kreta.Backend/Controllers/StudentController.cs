using Kreta.Backend.Controllers.Assamblers;
using Kreta.Backend.Repos;
using Kreta.Shared.Dtos;
using Kreta.Shared.Extensions;
using Kreta.Shared.Models.SchoolCitizens;
using Kreta.Shared.Parameters;
using Kreta.Shared.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : BaseController<Student, StudentDto>
    {
        private readonly IStudentRepo repo;
        public StudentController(StudentAssambler assembler, IStudentRepo repo) : base(assembler, repo)
        {
            this.repo = repo;
        }

        [HttpPost("queryparameters")]
        public async Task<IActionResult> GetStudents(StudentQueryParametersDto dto)
        {
            StudentQueryParameters parameters = dto.ToModel();
            if (!parameters.ValidYearRange)
            {
                ControllerResponse response = new ControllerResponse();
                response.AppendNewError("A születési év maximuma nagyobb kell legyen a születési év minimumánál!");
                return BadRequest(response);
            }
            else
            {
                if (repo is null)
                {
                    ControllerResponse response = new ControllerResponse();
                    response.AppendNewError("A diákok szűrése születési év alapján nem lehetséges");
                    return BadRequest(response);
                }
                else
                {
                    List<Student> result = await repo.GetStudents(parameters).ToListAsync();
                    return Ok(result);
                }
            }

        }
    }
}
