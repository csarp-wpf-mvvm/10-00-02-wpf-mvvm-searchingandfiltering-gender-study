using Kreta.Desktop.ViewModels;
using Kreta.Desktop.ViewModels.ControlPanel;
using Kreta.Desktop.ViewModels.Login;
using Kreta.Desktop.ViewModels.SchoolCitizens;
using Kreta.Desktop.ViewModels.SchoolClasses;
using Kreta.Desktop.ViewModels.SchoolGrades;
using Kreta.Desktop.ViewModels.SchoolSubjects;
using Kreta.Desktop.Views;
using Kreta.Desktop.Views.ControlPanel;
using Kreta.Desktop.Views.Login;
using Kreta.Desktop.Views.SchoolCitizens;
using Kreta.Desktop.Views.SchoolClasses;
using Kreta.Desktop.Views.SchoolGrades;
using Kreta.Desktop.Views.SchoolSubjects;
using Microsoft.Extensions.DependencyInjection;

namespace KretaDesktop.Extensions
{
    public static class ViewViewModelsExtensions
    {
        public static void ConfigureViewViewModels(this IServiceCollection services)
        {
            // MainView
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<MainView>(s => new MainView()
            {
                DataContext = s.GetRequiredService<MainViewModel>()
            });

            // LoginView
            services.AddSingleton<LoginViewModel>();
            services.AddSingleton<LoginView>(s => new LoginView()
            {
                DataContext = s.GetRequiredService<LoginViewModel>()
            });

            // ControlPanel
            services.AddSingleton<ControlPanelViewModel>();
            services.AddSingleton<ControlPanelView>(s => new ControlPanelView()
            {
                DataContext = s.GetRequiredService<ControlPanelViewModel>()
            });
            // School Citizens
            services.AddSingleton<SchoolCitizensViewModel>();
            services.AddSingleton<SchoolCitizensView>(s => new SchoolCitizensView()
            {
                DataContext = s.GetRequiredService<SchoolCitizensViewModel>()
            });

            services.AddSingleton<StudentViewModel>();
            services.AddSingleton<StudentView>(s => new StudentView()
            {
                DataContext = s.GetRequiredService<StudentViewModel>()
            });

            services.AddSingleton<TeacherViewModel>();
            services.AddSingleton<TeacherView>(s => new TeacherView()
            {
                DataContext = s.GetRequiredService<TeacherViewModel>()
            });
            services.AddSingleton<ParentViewModel>();
            services.AddSingleton<ParentView>(s => new ParentView()
            {
                DataContext = s.GetRequiredService<ParentViewModel>()
            });
            // School classes
            services.AddSingleton<SchoolClassesViewModel>();
            services.AddSingleton<SchoolClassesView>(s => new SchoolClassesView()
            {
                DataContext = s.GetRequiredService<SchoolClassesViewModel>()
            });
            // School subject
            services.AddSingleton<SchoolSubjectsViewModel>();
            services.AddSingleton<SchoolSubjectsView>(s => new SchoolSubjectsView()
            {
                DataContext = s.GetRequiredService<SchoolSubjectsViewModel>()
            });
            services.AddSingleton<SubjectsViewModel>();
            services.AddSingleton<SubjectsView>(s => new SubjectsView()
            {
                DataContext = s.GetRequiredService<SubjectsViewModel>()
            });
            services.AddSingleton<TeacherSubjectsViewModel>();
            services.AddSingleton<TeacherSubjectsView>(s => new TeacherSubjectsView()
            {
                DataContext = s.GetRequiredService<TeacherSubjectsViewModel>()
            });
            services.AddSingleton<SchoolClassSubjectsViewModel>();
            services.AddSingleton<SchoolClassSubjectsView>(s => new SchoolClassSubjectsView()
            {
                DataContext = s.GetRequiredService<SchoolClassSubjectsViewModel>()
            });
            //School Grade
            services.AddSingleton<SchoolGradeViewModel>();
            services.AddSingleton<SchoolGradeView>(s => new SchoolGradeView()
            {
                DataContext = s.GetRequiredService<SchoolGradeViewModel>()
            });
            services.AddSingleton<ClosingEndOfYearGradeViewModel>();
            services.AddSingleton<ClosingEndOfYearGradeView>(s => new ClosingEndOfYearGradeView()
            {
                DataContext = s.GetRequiredService<ClosingEndOfYearGradeViewModel>()              
            });
            services.AddSingleton<ClosingSemesterGradeViewModel>();
            services.AddSingleton<ClosingSemesterGradeView>(s => new ClosingSemesterGradeView()
            {
                DataContext = s.GetRequiredService<ClosingSemesterGradeViewModel>()
            });
            services.AddSingleton<CurrentSchoolHoursViewModel>();
            services.AddSingleton<CurrentSchoolHoursView>(s => new CurrentSchoolHoursView()
            {
                DataContext = s.GetRequiredService<CurrentSchoolHoursViewModel>()
            });
            services.AddSingleton<TaughtClassesViewModel>();
            services.AddSingleton<TaughtClassesView>(s => new TaughtClassesView()
            {
                DataContext = s.GetRequiredService<TaughtClassesViewModel>()
            });

        }
    }
}
