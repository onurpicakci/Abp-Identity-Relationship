using System;
using Volo.Abp.Domain.Entities;

namespace IdentityRelationship.Departments;

public class Department : AggregateRoot<Guid>
{
    public string Name { get; set; }
}