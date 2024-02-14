using Kreta.Shared.Dtos;
using Kreta.Shared.Models;
using Kreta.Shared.Models.SchoolCitizens;
using Kreta.Shared.Parameters;
using Kreta.Shared.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kreta.HttpService.Service
{
    public interface IStudentService
    {
        public Task<List<Student>> SelectAllStudentAsync();
        public Task<ControllerResponse> UpdateAsync(Student studentDto);
        public Task<ControllerResponse> DeleteAsync(Guid id);
        public Task<ControllerResponse> InsertAsync(Student student);
        public Task<List<Student>> SearchAndFilterStudents(StudentQueryParameters studentQueryParameters);
    }
}
