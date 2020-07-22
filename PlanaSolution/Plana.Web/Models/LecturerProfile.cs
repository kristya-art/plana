using AutoMapper;
using Plana.Models;


namespace Plana.Web.Models
{
    public class LecturerProfile : Profile
    {
        public LecturerProfile()
        {
            CreateMap<Lecturer, EditLecturerModel>()
                .ForMember(dest=>dest.ConfirmEmail,
                opt=>opt.MapFrom(src => src.Email));
            CreateMap<EditLecturerModel, Lecturer>();

        }
    }
}
