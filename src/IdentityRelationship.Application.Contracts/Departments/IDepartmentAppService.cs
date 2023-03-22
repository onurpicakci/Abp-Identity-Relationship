using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace IdentityRelationship.Departments;

public interface IDepartmentAppService : IApplicationService
{
    public Task<PagedResultDto<DepartmentDto>> GetAsync();
}