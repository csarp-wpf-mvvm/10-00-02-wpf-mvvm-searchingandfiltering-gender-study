using Kreta.Backend.Context;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Repos
{
    public class StudentInMemoryRepo : StudentRepo<KretaInMemoryContext>
    {
        public StudentInMemoryRepo(IDbContextFactory<KretaInMemoryContext> dbContextFactory) : base(dbContextFactory)
        {
        }
    }
    public class GradeInMemoryRepo : GradeRepo<KretaInMemoryContext>
    {
        public GradeInMemoryRepo(IDbContextFactory<KretaInMemoryContext> dbContextFactory) : base(dbContextFactory)
        {
        }
    }

    public class ParentInMemoryRepo : ParentRepo<KretaInMemoryContext>
    {
        public ParentInMemoryRepo(IDbContextFactory<KretaInMemoryContext> dbContextFactory) : base(dbContextFactory)
        {
        }
    }

    public class SubjectInMemoryRepo : SubjectRepo<KretaInMemoryContext>
    {
        public SubjectInMemoryRepo(IDbContextFactory<KretaInMemoryContext> dbContextFactory) : base(dbContextFactory)
        {
        }
    }

    public class TeacherInMemoryRepo : TeacherRepo<KretaInMemoryContext>
    {
        public TeacherInMemoryRepo(IDbContextFactory<KretaInMemoryContext> dbContextFactory) : base(dbContextFactory)
        {
        }
    }
}
