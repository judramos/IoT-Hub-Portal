// Copyright (c) CGI France. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace IoTHub.Portal.Client.Extensions
{
    public static class EnumerableExtension
    {
        public static int Next(this IEnumerable<int> source)
        {
            if (!source.Any())
            {
                return 0;
            }

            return source.Max() + 1;
        }
    }
}
