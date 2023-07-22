using AutoMapper;

namespace TestApp.Data.Dto
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile()
        {
            CreateMap<Company, CompanyDto>().ReverseMap();
            CreateMap<Company, CompanyFullDto>();
            CreateMap<Order, OrderDto>();
            CreateMap<Employee, EmployeeDto>();
            CreateMap<Note, NoteDto>()
                .ForMember(d => d.EmployeeFullName, 
                    s => s.MapFrom(x => string.Concat(x.Employee.FirstName, " ", x.Employee.LastName)));
        }
    }
}
