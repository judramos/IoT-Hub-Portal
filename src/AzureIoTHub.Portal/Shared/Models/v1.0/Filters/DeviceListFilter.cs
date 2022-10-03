// Copyright (c) CGI France. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace AzureIoTHub.Portal.Shared.Models.v1._0.Filters
{
    using System.Collections.Generic;

    public class DeviceListFilter : PaginationFilter
    {
        public string Keyword { get; set; }

        public bool? IsEnabled { get; set; }

        public bool? IsConnected { get; set; }

        public Dictionary<string, string> Tags { get; set; }
    }
}
