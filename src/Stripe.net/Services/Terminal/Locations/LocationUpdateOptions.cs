namespace Stripe.Terminal
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class LocationUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("address")]
        public AddressOptions Address { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
