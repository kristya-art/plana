using AutoMapper;
using Plana.Models;
using Plana.Shared;

namespace Plana.Api
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMaps();
        }

        private void CreateMaps()
        {
            CreateMap<Lecturer, EditLecturerModel>()
                .ForMember(dest => dest.ConfirmEmail, opt => opt.MapFrom(src => src.Email));

            CreateMap<EditLecturerModel, Lecturer>();

            CreateMap<PlanLecturerDto, PlanLecturer>();
            CreateMap<PlanLecturer, PlanLecturerDto>();
        }
    }
}
