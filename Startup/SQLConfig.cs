using System.Data;
using Microsoft.Data.SqlClient;

namespace AbhaApi.Startup
{
    public static class SQLConfig
    {
        public static void AddSqlConnection(this WebApplicationBuilder builder, string connectionString)
        {
            builder.Services.AddTransient<IDbConnection>((serviceProvider) => new SqlConnection(connectionString));
        }
    }
}
