
using Kreta.Shared.Dtos;
using Kreta.Shared.Models.SchoolCitizens;

namespace Kreta.Shared.Extensions
{
    public static class ParentExtension
    {
        public static ParentDto ToDto(this Parent parent)
        {
            return new ParentDto
            {
                Id = parent.Id,
                FirstName = parent.FirstName,
                LastName = parent.LastName,
                IsWoman = parent.IsWoman,
                Address = parent.Address,
            };
        }

        public static Parent ToModel(this ParentDto parentDto)
        {
            return new Parent
            {
                Id = parentDto.Id,
                FirstName = parentDto.FirstName,
                LastName = parentDto.LastName,
                IsWoman= parentDto.IsWoman,
                Address = parentDto.Address,
            };
        }
    }
}
