
namespace Kreta.Shared.Models.SchoolCitizens
{
    public class Subject : IDbEntity<Subject>
    {
        public Subject()
        {
            Id = Guid.Empty;
            SubjectName = string.Empty;
            OptionalExaminationSubject = false;
            CompulsoryExaminationSubject = false;
        }
        public Subject(Guid id, string subjectName, bool optionalExaminationSubject, bool compulsoryExaminationSubject)
        {
            Id = id;
            SubjectName = subjectName;
            OptionalExaminationSubject = optionalExaminationSubject;
            CompulsoryExaminationSubject = compulsoryExaminationSubject;
        }

        public Guid Id { get; set; }
        public string SubjectName { get; set; }
        public bool OptionalExaminationSubject { get; set; }
        public bool CompulsoryExaminationSubject { get; set; }

        public override string ToString()
        {
            return $"{SubjectName}";
        }

    }
}
