using Kreta.Shared.Models.SchoolCitizens;

namespace Kreta.Shared.Dtos
{
    public class StudentDto
    {
        public Guid Id { get; set; } = Guid.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime BirthDay { get; set; } = DateTime.MinValue;
        public int SchoolYear { get; set; } = 0;
        public SchoolClassType SchoolClass { get; set; } = SchoolClassType.ClassA;
        public string EducationLevel { get; set; } = string.Empty;
        public bool IsWoomen { get; set; } = false;
    }
}
