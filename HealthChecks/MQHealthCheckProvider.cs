using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace ServicingAPI.HealthChecks
{
    public static class MQHealthCheckProvider
    {
        public static HealthCheckResult Check(string url)
        {
            //Code to check if MQ is running.
            return HealthCheckResult. Healthy("MQ is Healthy!");
        }
    }
}

