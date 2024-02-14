using Kreta.Shared.Models.SchoolCitizens;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Repos
{
    public class TeacherRepo<TDbContext> : RepositoryBase<TDbContext, Teacher>, ITeacherRepo
        where TDbContext : DbContext
    {
        public TeacherRepo(IDbContextFactory<TDbContext> dbContextFactory) : base(dbContextFactory)
        {
        }
    }
}
