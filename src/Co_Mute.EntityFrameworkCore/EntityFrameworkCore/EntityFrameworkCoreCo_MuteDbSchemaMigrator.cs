using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Co_Mute.Data;
using Volo.Abp.DependencyInjection;

namespace Co_Mute.EntityFrameworkCore;

public class EntityFrameworkCoreCo_MuteDbSchemaMigrator
    : ICo_MuteDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreCo_MuteDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the Co_MuteDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<Co_MuteDbContext>()
            .Database
            .MigrateAsync();
    }
}
