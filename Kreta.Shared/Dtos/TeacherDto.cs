namespace Kreta.Shared.Dtos
{
    public class TeacherDto
    {
        public Guid Id { get; set; } = Guid.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public bool IsHeadTeacher { get; set; } = false;
        public bool IsWoman { get; set; } = false;
    }
}
