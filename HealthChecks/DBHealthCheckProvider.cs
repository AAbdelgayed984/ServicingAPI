using System.Data.SqlClient;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace ServicingAPI.HealthChecks
{
    public static class DBHealthCheckProvider
    {
        public static HealthCheckResult Check(string connectionString)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                }
                catch (SqlException)
                {
                    return HealthCheckResult.Unhealthy();
                }
            }

            return HealthCheckResult.Healthy("DB is Healthy!");
        }
    }
}