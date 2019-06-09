// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Swagger.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for loginUser operation.
    /// </summary>
    public partial class LoginUserHeaders
    {
        /// <summary>
        /// Initializes a new instance of the LoginUserHeaders class.
        /// </summary>
        public LoginUserHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LoginUserHeaders class.
        /// </summary>
        /// <param name="xRateLimit">calls per hour allowed by the user</param>
        /// <param name="xExpiresAfter">date in UTC when token expires</param>
        public LoginUserHeaders(int? xRateLimit = default(int?), System.DateTime? xExpiresAfter = default(System.DateTime?))
        {
            XRateLimit = xRateLimit;
            XExpiresAfter = xExpiresAfter;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets calls per hour allowed by the user
        /// </summary>
        [JsonProperty(PropertyName = "X-Rate-Limit")]
        public int? XRateLimit { get; set; }

        /// <summary>
        /// Gets or sets date in UTC when token expires
        /// </summary>
        [JsonProperty(PropertyName = "X-Expires-After")]
        public System.DateTime? XExpiresAfter { get; set; }

    }
}
