using Kreta.Shared.Models.SchoolCitizens;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Repos
{
    public class GradeRepo<TDbContext> : RepositoryBase<TDbContext, Grade>, IGradeRepo
        where TDbContext : DbContext
    {
        public GradeRepo(IDbContextFactory<TDbContext> dbContextFactory) : base(dbContextFactory)
        {

        }
    }
}
