using Kreta.Shared.Dtos;
using Kreta.Shared.Models.SchoolCitizens;

namespace Kreta.Shared.Extensions
{
    public static class TeacherExtension
    {
        public static TeacherDto ToDto(this Teacher teacher)
        {
            return new TeacherDto
            {
                Id = teacher.Id,
                FirstName = teacher.FirstName,
                LastName = teacher.LastName,
                IsWoman = teacher.IsWoman,
                IsHeadTeacher = teacher.IsHeadTeacher,
            };
        }

        public static Teacher ToModel(this TeacherDto teacherDto)
        {
            return new Teacher
            {
                Id = teacherDto.Id,
                FirstName = teacherDto.FirstName,
                LastName = teacherDto.LastName,
                IsWoman = teacherDto.IsWoman,
                IsHeadTeacher= teacherDto.IsHeadTeacher
            };
        }
    }
}
