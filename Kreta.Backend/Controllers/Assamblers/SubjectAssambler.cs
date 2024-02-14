using Kreta.Shared.Dtos;
using Kreta.Shared.Extensions;
using Kreta.Shared.Models.SchoolCitizens;

namespace Kreta.Backend.Controllers.Assamblers
{
    public class SubjectAssambler : Assambler<Subject, SubjectDto>
    {
        public override SubjectDto ToDto(Subject model)
        {
            return model.ToDto();
        }

        public override Subject ToModel(SubjectDto dto)
        {
            return dto.ToModel();
        }
    }
}
