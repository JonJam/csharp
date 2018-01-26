// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// DaemonSetCondition describes the state of a DaemonSet at a certain
    /// point.
    /// </summary>
    public partial class V1beta1DaemonSetCondition
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1DaemonSetCondition class.
        /// </summary>
        public V1beta1DaemonSetCondition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1DaemonSetCondition class.
        /// </summary>
        /// <param name="status">Status of the condition, one of True, False,
        /// Unknown.</param>
        /// <param name="type">Type of DaemonSet condition.</param>
        /// <param name="lastTransitionTime">Last time the condition
        /// transitioned from one status to another.</param>
        /// <param name="message">A human readable message indicating details
        /// about the transition.</param>
        /// <param name="reason">The reason for the condition's last
        /// transition.</param>
        public V1beta1DaemonSetCondition(string status, string type, System.DateTime? lastTransitionTime = default(System.DateTime?), string message = default(string), string reason = default(string))
        {
            LastTransitionTime = lastTransitionTime;
            Message = message;
            Reason = reason;
            Status = status;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets last time the condition transitioned from one status
        /// to another.
        /// </summary>
        [JsonProperty(PropertyName = "lastTransitionTime")]
        public System.DateTime? LastTransitionTime { get; set; }

        /// <summary>
        /// Gets or sets a human readable message indicating details about the
        /// transition.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the reason for the condition's last transition.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets status of the condition, one of True, False, Unknown.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets type of DaemonSet condition.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Status == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Status");
            }
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
        }
    }
}
