
using Molntjanster.Entities;
using Molntjanster.UseCases.ManageStudents.Models;

namespace Molntjanster.UseCases
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentModel>();
        }
    }
}
