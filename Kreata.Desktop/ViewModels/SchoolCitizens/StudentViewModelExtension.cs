using Kreta.Shared.Parameters;

namespace Kreta.Desktop.ViewModels.SchoolCitizens
{
    public static class StudentViewModelExtension
    {
        public static StudentQueryParameters ToStudentQueryParameters(this StudentViewModel studentViewModel)
        {
            return new StudentQueryParameters
            {
                MinYearOfBirth = studentViewModel.FileteredMinBirthYear,
                MaxYearOfBirth = studentViewModel.FilteredMaxBirthYear,
                Name = studentViewModel.SerchedName
            };
        }
    }
}
