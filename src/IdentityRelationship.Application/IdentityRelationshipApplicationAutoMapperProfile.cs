using AutoMapper;
using IdentityRelationship.Departments;

namespace IdentityRelationship;

public class IdentityRelationshipApplicationAutoMapperProfile : Profile
{
    public IdentityRelationshipApplicationAutoMapperProfile()
    {
        CreateMap<Departments.Department, DepartmentDto>();
    }
}
