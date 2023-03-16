using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace IdentityRelationship.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class IdentityRelationshipDbContextFactory : IDesignTimeDbContextFactory<IdentityRelationshipDbContext>
{
    public IdentityRelationshipDbContext CreateDbContext(string[] args)
    {
        IdentityRelationshipEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<IdentityRelationshipDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new IdentityRelationshipDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../IdentityRelationship.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
