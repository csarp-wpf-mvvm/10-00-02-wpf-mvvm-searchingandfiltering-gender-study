using Kreta.Backend.Context;
using Kreta.Backend.Controllers.Assamblers;
using Kreta.Backend.Repos;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Extensions
{
    public static class KretaBackendExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {

            services.AddCors(option =>
                 option.AddPolicy(name: "KretaCors",
                     policy =>
                     {
                         policy.WithOrigins("https://localhost:7020/")
                         .AllowAnyHeader()
                         .AllowAnyMethod();
                     }
                 )
            );
        }

        public static void ConfigureInMemoryContext(this IServiceCollection services)
        {
            string dbName = "Kreta" + Guid.NewGuid();
            /*services.AddDbContextFactory<KretaContext>(
                options => options.UseInMemoryDatabase(databaseName: dbName)
                );*/
            services.AddDbContextFactory<KretaInMemoryContext>(
                options => options.UseInMemoryDatabase(databaseName: dbName)
                );
        }

        public static void ConfigureRepoService(this IServiceCollection services)
        {
            services.AddScoped<IStudentRepo, StudentInMemoryRepo>();
            services.AddScoped<IGradeRepo, GradeInMemoryRepo>();
            services.AddScoped<IParentRepo, ParentInMemoryRepo>();
            services.AddScoped<ITeacherRepo, TeacherInMemoryRepo>();
            services.AddScoped<ISubjectRepo, SubjectInMemoryRepo>();
        }

        public static void ConfigureAssamblers(this IServiceCollection services)
        {
            services.AddScoped<TeacherAssambler>();
            services.AddScoped<GradeAssambler>();
            services.AddScoped<ParentAssambler>();
            services.AddScoped<StudentAssambler>();
            services.AddScoped<SubjectAssambler>();
        }
    }
}
