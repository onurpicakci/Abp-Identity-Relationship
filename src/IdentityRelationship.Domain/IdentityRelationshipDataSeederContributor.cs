using System;
using System.Threading.Tasks;
using IdentityRelationship.Departments;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace IdentityRelationship;

public class IdentityRelationshipDataSeederContributor
    : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<Department, Guid> _departmentRepository;

    public IdentityRelationshipDataSeederContributor(IRepository<Department, Guid> departmentRepository)
    {
        _departmentRepository = departmentRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _departmentRepository.GetCountAsync() <= 0)
        {
            await _departmentRepository.InsertAsync(
                new Department
                {
                    Name = "Human Resources"
                },
                autoSave: true
            );

            await _departmentRepository.InsertAsync(
                new Department
                {
                    Name = "Production"
                },
                autoSave: true
            );
        }
    }
}