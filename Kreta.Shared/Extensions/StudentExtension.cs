using Kreta.Shared.Dtos;
using Kreta.Shared.Models.SchoolCitizens;

namespace Kreta.Shared.Extensions
{
    public static class StudentExtension
    {
        public static StudentDto ToDto(this Student student)
        {
            return new StudentDto
            {
                Id = student.Id,
                FirstName = student.FirstName,
                LastName = student.LastName,
                BirthDay = student.BirthDay,
                IsWoomen = student.IsWoomen,
                SchoolYear = student.SchoolYear,
                SchoolClass = student.SchoolClass,
                EducationLevel = student.EducationLevel,
            };
        }

        public static Student ToModel(this StudentDto studentDto)
        {
            return new Student
            {
                Id = studentDto.Id,
                FirstName = studentDto.FirstName,
                LastName = studentDto.LastName,
                BirthDay= studentDto.BirthDay,
                IsWoomen = studentDto.IsWoomen,
                SchoolYear = studentDto.SchoolYear,
                SchoolClass = studentDto.SchoolClass,
                EducationLevel = studentDto.EducationLevel,
            };
        }
    }
}
