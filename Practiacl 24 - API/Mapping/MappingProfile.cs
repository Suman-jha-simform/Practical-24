using AutoMapper;
using Practical_24.Dto;
using Practical_24.Model;

namespace Practical_23.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EmployeeDto, Employee>();
            CreateMap<Employee, EmployeeDto>();

            CreateMap<CreateEmployeeDto, Employee>();
            CreateMap<Employee, CreateEmployeeDto>();

            CreateMap<UpdateEmployeeDto, Employee>();
            CreateMap<Employee, UpdateEmployeeDto>();

            CreateMap<Employee, EmployeeDtoHourBonus>();

        }
    }
}
