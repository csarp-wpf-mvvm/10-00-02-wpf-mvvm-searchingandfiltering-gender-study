using System.Globalization;

namespace Kreta.Shared.Models.SchoolCitizens
{
    public class Student : IDbEntity<Student>
    {

        public Student()
        {
            Id = Guid.Empty;
            FirstName = string.Empty;
            LastName = string.Empty;
            BirthDay = new DateTime();
            SchoolYear = 9;
            SchoolClass = SchoolClassType.ClassA;
            IsWoomen = false;
            EducationLevel = string.Empty;
        }

        public Student(Guid id, string firstName, string lastName, DateTime birthDay, int schoolYear, SchoolClassType schoolClass, bool isWoomen, string educationLevel)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
            SchoolYear = schoolYear;
            SchoolClass = schoolClass;
            IsWoomen = isWoomen;
            EducationLevel = educationLevel;
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int SchoolYear { get; set; }
        public DateTime BirthDay { get; set; }
        public SchoolClassType SchoolClass { get; set; }
        public string EducationLevel { get; set; }
        public bool IsWoomen { get; set; }
        public bool HasId => Id != Guid.Empty;
        public string HungarianFullName
        {
            set { }
            get => $"{LastName} {FirstName}";
        }

        public override string ToString()
        {
            return $"{LastName} {FirstName} ({SchoolYear}.{SchoolClass}) {BirthDay.ToString("d", new CultureInfo("hu-HU"))} {EducationLevel}";
        }
    }
}
