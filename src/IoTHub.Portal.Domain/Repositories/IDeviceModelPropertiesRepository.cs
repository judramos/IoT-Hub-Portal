// Copyright (c) CGI France. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace IoTHub.Portal.Domain.Repositories
{
    public interface IDeviceModelPropertiesRepository : IRepository<DeviceModelProperty>
    {
        Task<IEnumerable<DeviceModelProperty>> GetModelProperties(string modelId);
        Task SavePropertiesForModel(string modelId, IEnumerable<DeviceModelProperty> items);
    }
}
