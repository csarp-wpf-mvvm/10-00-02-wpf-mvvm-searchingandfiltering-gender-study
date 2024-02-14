using Kreta.Shared.Dtos;
using Kreta.Shared.Parameters;

namespace Kreta.Shared.Extensions
{
    public static class StudentQueryParametersExtension
    {
        public static StudentQueryParametersDto ToDto(this StudentQueryParameters parameters)
        {
            return new StudentQueryParametersDto
            {
                MaxYearOfBirth = parameters.MaxYearOfBirth,
                MinYearOfBirth = parameters.MinYearOfBirth,
                Name = parameters.Name,
                HaveGender = parameters.HaveGender,
                IsWooman = parameters.IsWooman,
            };
        }

        public static StudentQueryParameters ToModel(this StudentQueryParametersDto parameters)
        {
            return new StudentQueryParameters
            {
                MinYearOfBirth = parameters.MinYearOfBirth,
                MaxYearOfBirth = parameters.MaxYearOfBirth,
                Name = parameters.Name,
                HaveGender = parameters.HaveGender, 
                IsWooman=parameters.IsWooman,
            };
        }
    }
}
