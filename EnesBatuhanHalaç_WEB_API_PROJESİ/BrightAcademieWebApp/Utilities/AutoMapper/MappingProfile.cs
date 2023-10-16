using AutoMapper;
using BrightApp.Entity.Concrete;
using BrightApp.Entity.DataTransferObjects;

namespace BrightAcademieWebApp.Utilities.AutoMapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<CategoryDtoForUpdate, Category>();
            CreateMap<TraineeDtoForUpdate, Trainee>();
            CreateMap<TrainerDtoForUpdate, Trainer>();
            CreateMap<CourseDtoForUpdate, Course>();
        }
    }
}
