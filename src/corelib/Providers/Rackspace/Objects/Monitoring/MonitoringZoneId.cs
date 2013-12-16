﻿namespace net.openstack.Providers.Rackspace.Objects.Monitoring
{
    using System;
    using net.openstack.Core;
    using Newtonsoft.Json;

    /// <summary>
    /// Represents the unique identifier of a monitoring zone in the <see cref="IMonitoringService"/>.
    /// </summary>
    /// <seealso cref="MonitoringZone.Id"/>
    /// <threadsafety static="true" instance="false"/>
    /// <preliminary/>
    [JsonConverter(typeof(MonitoringZoneId.Converter))]
    public sealed class MonitoringZoneId : ResourceIdentifier<MonitoringZoneId>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MonitoringZoneId"/> class
        /// with the specified identifier value.
        /// </summary>
        /// <param name="id">The monitoring zone identifier value.</param>
        /// <exception cref="ArgumentNullException">If <paramref name="id"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException">If <paramref name="id"/> is empty.</exception>
        public MonitoringZoneId(string id)
            : base(id)
        {
        }

        /// <summary>
        /// Provides support for serializing and deserializing <see cref="MonitoringZoneId"/>
        /// objects to JSON string values.
        /// </summary>
        /// <threadsafety static="true" instance="false"/>
        private sealed class Converter : ConverterBase
        {
            /// <inheritdoc/>
            protected override MonitoringZoneId FromValue(string id)
            {
                return new MonitoringZoneId(id);
            }
        }
    }
}
