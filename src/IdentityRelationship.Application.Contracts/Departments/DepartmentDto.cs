using System;
using Volo.Abp.Application.Dtos;
namespace IdentityRelationship.Departments;

public class DepartmentDto : EntityDto<Guid>

{
    public string Name { get; set; }
}