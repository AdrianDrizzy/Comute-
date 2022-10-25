using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Co_Mute.Data;

/* This is used if database provider does't define
 * ICo_MuteDbSchemaMigrator implementation.
 */
public class NullCo_MuteDbSchemaMigrator : ICo_MuteDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
