using Kreta.Shared.Models.SchoolCitizens;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Repos
{
    public class SubjectRepo<TDbContext> : RepositoryBase<TDbContext, Subject>, ISubjectRepo
        where TDbContext : DbContext
    {
        public SubjectRepo(IDbContextFactory<TDbContext> dbContextFactory) : base(dbContextFactory)
        {

        }
    }
}
