using Kreta.Shared.Models.SchoolCitizens;
using Kreta.Shared.Parameters;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Repos
{
    public class StudentRepo<TDbContext> : RepositoryBase<TDbContext, Student>, IStudentRepo
        where TDbContext : DbContext
    {
        public StudentRepo(IDbContextFactory<TDbContext> dbContextFactory) : base(dbContextFactory)
        {
        }

        public IQueryable<Student> GetStudents(StudentQueryParameters parameters)
        {
            IQueryable<Student> filteredStudent = FindByCondition(student => student.BirthDay.Year >= parameters.MinYearOfBirth
                                           && student.BirthDay.Year <= parameters.MaxYearOfBirth
                                  )
                                  .OrderBy(student => student.HungarianFullName);

            SearchByStudentName(ref filteredStudent, parameters.Name);
            if (parameters.HaveGender)
            {
                FilteringByGender(ref filteredStudent, parameters.IsWooman);
            }
            return filteredStudent;

        }

        private void SearchByStudentName(ref IQueryable<Student> students, string studentName)
        {
            if (!students.Any() || string.IsNullOrEmpty(studentName))
            {
                return;
            }
            students = students.Where(student => student.HungarianFullName.ToLower().Contains(studentName.Trim().ToLower()));
        }

        private void FilteringByGender(ref IQueryable<Student> students, bool isWooman)
        {
            students = students.Where(student => student.IsWoomen== isWooman);
        }
    }
}
