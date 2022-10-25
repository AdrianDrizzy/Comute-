using System.Threading.Tasks;

namespace Co_Mute.Data;

public interface ICo_MuteDbSchemaMigrator
{
    Task MigrateAsync();
}
