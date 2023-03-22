using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IdentityRelationship.Departments;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;

namespace IdentityRelationship.Department;

public class DepartmentAppService : IdentityRelationshipAppService, IDepartmentAppService
{
    private readonly IRepository<Departments.Department, Guid> _departmentRepository;

    public DepartmentAppService(IRepository<Departments.Department, Guid> departmentRepository)
    {
        _departmentRepository = departmentRepository;
    }

    public async Task<ListResultDto<DepartmentDto>> GetAsync()
    {
        var departments = await _departmentRepository.GetListAsync();
        return new ListResultDto<DepartmentDto>(
            ObjectMapper.Map<List<Departments.Department>, List<DepartmentDto>>(departments));
    }
}