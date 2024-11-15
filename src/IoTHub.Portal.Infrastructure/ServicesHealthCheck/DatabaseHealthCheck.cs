// Copyright (c) CGI France. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace IoTHub.Portal.Infrastructure.ServicesHealthCheck
{
    public class DatabaseHealthCheck : IHealthCheck
    {
        private readonly PortalDbContext portalDbContext;

        public DatabaseHealthCheck(PortalDbContext portalDbContext)
        {
            this.portalDbContext = portalDbContext;
        }

        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            if (await this.portalDbContext.Database.CanConnectAsync(cancellationToken))
            {
                return HealthCheckResult.Healthy();
            }
            return HealthCheckResult.Unhealthy("Cannot connect to database");
        }
    }
}
