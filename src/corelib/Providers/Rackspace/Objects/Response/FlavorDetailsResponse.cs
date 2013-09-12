namespace net.openstack.Providers.Rackspace.Objects.Response
{
    using net.openstack.Core.Domain;
    using Newtonsoft.Json;

    [JsonObject(MemberSerialization.OptIn)]
    internal class FlavorDetailsResponse
    {
        [JsonProperty("flavor")]
        public FlavorDetails Flavor { get; private set; }
    }
}
