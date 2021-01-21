using AutoMapper;
using Plana.Api.Models;
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
            CreateMap<Lecturer, LecturerDto>()
                .ForMember(dest => dest.ConfirmEmail, opt => opt.MapFrom(src => src.Email));
            CreateMap<LecturerDto, Lecturer>();

            CreateMap<PlanLecturerDto, PlanLecturer>();
            CreateMap<PlanLecturer, PlanLecturerDto>();

            CreateMap<LecturerGroupDto, LecturerGroup>();
            CreateMap<LecturerGroup, LecturerGroupDto>();

            CreateMap<LecturerGroupModuleGroupDto, LecturerGroupModuleGroup>();
            CreateMap<LecturerGroupModuleGroup, LecturerGroupModuleGroupDto>();

            CreateMap<LecturerLecturerGroupDto, LecturerLecturerGroup>();
            CreateMap<LecturerLecturerGroup, LecturerLecturerGroupDto>();

            CreateMap<LecturerModuleDto, LecturerModule>();
            CreateMap<LecturerModule, LecturerModuleDto>();

            CreateMap<LecturerModuleGroupDto, LecturerModuleGroup>();
            CreateMap<LecturerModuleGroup, LecturerModuleGroupDto>();

            CreateMap<LecturerModuleRunDto, LecturerModuleRun>();
            CreateMap<LecturerModuleRun, LecturerModuleRunDto>();

            CreateMap<LecturerSemesterDto, LecturerSemester>();
            CreateMap<LecturerSemester, LecturerSemesterDto>();
            
            CreateMap<ModuleDto, Module>();
            CreateMap<Module, ModuleDto>();

            CreateMap<ModuleGroupDto, ModuleGroup>();
            CreateMap<ModuleGroup, ModuleGroupDto>();

            CreateMap<ModuleRunDto, ModuleRun>();
            CreateMap<ModuleRun, ModuleRunDto>();

            CreateMap<ModuleRunLecturerGroupDto, ModuleRunLecturerGroup>();
            CreateMap<ModuleRunLecturerGroup, ModuleRunLecturerGroupDto>();

            CreateMap<PlanDto, Plan>();
            CreateMap<Plan, PlanDto>();

            CreateMap<SemesterDto, Semester>();
            CreateMap<Semester, SemesterDto>();

            CreateMap<StudyBranchDto, StudyBranch>();
            CreateMap<StudyBranch, StudyBranchDto>();

            CreateMap<AdditionalAssignmentDto, AdditionalAssignment>();
            CreateMap<AdditionalAssignment, AdditionalAssignmentDto>();
            
        }
    }
}
