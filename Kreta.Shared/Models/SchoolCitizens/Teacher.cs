namespace Kreta.Shared.Models.SchoolCitizens
{
    public class Teacher : IDbEntity<Teacher>
    {
        public Teacher()
        {
            Id = Guid.Empty;
            FirstName = string.Empty;
            LastName = string.Empty;
            IsWoman = false;
        }

        public Teacher(Guid id, string firstName, string lastName, bool isWoman, bool isHeadTeacher)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            IsWoman = isWoman;
            IsHeadTeacher = isHeadTeacher;
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsWoman { get; set; }
        public bool IsHeadTeacher { get; set; }
        public string FullName => $"{FirstName} {LastName}";        


        public override string ToString()
        {
            return $"{LastName} {FirstName}";
        }
    }
}
