namespace Kreta.Shared.Dtos
{
    public class StudentQueryParametersDto
    {
        public uint MinYearOfBirth { get; set; }
        public uint MaxYearOfBirth { get; set; } = (uint)DateTime.Now.Year;
        public string Name { get; set; } = string.Empty;
        public bool HaveGender { get; set; } = false;
        public bool IsWooman { get; set; } = false;
    }
}
