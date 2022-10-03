// Copyright (c) CGI France. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace AzureIoTHub.Portal.Infrastructure.Repositories
{
    using AzureIoTHub.Portal.Domain.Repositories;
    using Domain.Entities;
    using Microsoft.EntityFrameworkCore;

    public class DeviceRepository : GenericRepository<Device>, IDeviceRepository
    {
        public DeviceRepository(PortalDbContext context) : base(context)
        {
        }

        public override Task<Device?> GetByIdAsync(object id)
        {
            return this.context.Set<Device>()
                .Include(device => device.Tags)
                .Where(device => device.Id.Equals(id.ToString()))
                .FirstOrDefaultAsync();
        }
    }
}
