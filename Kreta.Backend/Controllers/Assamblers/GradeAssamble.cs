using Kreta.Shared.Dtos;
using Kreta.Shared.Extensions;
using Kreta.Shared.Models.SchoolCitizens;

namespace Kreta.Backend.Controllers.Assamblers
{
    public class GradeAssambler : Assambler<Grade, GradeDto>
    {
        public override GradeDto ToDto(Grade model)
        {
            return model.ToDto();
        }

        public override Grade ToModel(GradeDto dto)
        {
            return dto.ToModel();
        }
    }
}
