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
    /// CustomResourceSubresourceScale defines how to serve the scale
    /// subresource for CustomResources.
    /// </summary>
    public partial class V1beta1CustomResourceSubresourceScale
    {
        /// <summary>
        /// Initializes a new instance of the
        /// V1beta1CustomResourceSubresourceScale class.
        /// </summary>
        public V1beta1CustomResourceSubresourceScale()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// V1beta1CustomResourceSubresourceScale class.
        /// </summary>
        /// <param name="specReplicasPath">SpecReplicasPath defines the JSON
        /// path inside of a CustomResource that corresponds to
        /// Scale.Spec.Replicas. Only JSON paths without the array notation are
        /// allowed. Must be a JSON Path under .spec. If there is no value
        /// under the given path in the CustomResource, the /scale subresource
        /// will return an error on GET.</param>
        /// <param name="statusReplicasPath">StatusReplicasPath defines the
        /// JSON path inside of a CustomResource that corresponds to
        /// Scale.Status.Replicas. Only JSON paths without the array notation
        /// are allowed. Must be a JSON Path under .status. If there is no
        /// value under the given path in the CustomResource, the status
        /// replica value in the /scale subresource will default to 0.</param>
        /// <param name="labelSelectorPath">LabelSelectorPath defines the JSON
        /// path inside of a CustomResource that corresponds to
        /// Scale.Status.Selector. Only JSON paths without the array notation
        /// are allowed. Must be a JSON Path under .status. Must be set to work
        /// with HPA. If there is no value under the given path in the
        /// CustomResource, the status label selector value in the /scale
        /// subresource will default to the empty string.</param>
        public V1beta1CustomResourceSubresourceScale(string specReplicasPath, string statusReplicasPath, string labelSelectorPath = default(string))
        {
            LabelSelectorPath = labelSelectorPath;
            SpecReplicasPath = specReplicasPath;
            StatusReplicasPath = statusReplicasPath;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets labelSelectorPath defines the JSON path inside of a
        /// CustomResource that corresponds to Scale.Status.Selector. Only JSON
        /// paths without the array notation are allowed. Must be a JSON Path
        /// under .status. Must be set to work with HPA. If there is no value
        /// under the given path in the CustomResource, the status label
        /// selector value in the /scale subresource will default to the empty
        /// string.
        /// </summary>
        [JsonProperty(PropertyName = "labelSelectorPath")]
        public string LabelSelectorPath { get; set; }

        /// <summary>
        /// Gets or sets specReplicasPath defines the JSON path inside of a
        /// CustomResource that corresponds to Scale.Spec.Replicas. Only JSON
        /// paths without the array notation are allowed. Must be a JSON Path
        /// under .spec. If there is no value under the given path in the
        /// CustomResource, the /scale subresource will return an error on GET.
        /// </summary>
        [JsonProperty(PropertyName = "specReplicasPath")]
        public string SpecReplicasPath { get; set; }

        /// <summary>
        /// Gets or sets statusReplicasPath defines the JSON path inside of a
        /// CustomResource that corresponds to Scale.Status.Replicas. Only JSON
        /// paths without the array notation are allowed. Must be a JSON Path
        /// under .status. If there is no value under the given path in the
        /// CustomResource, the status replica value in the /scale subresource
        /// will default to 0.
        /// </summary>
        [JsonProperty(PropertyName = "statusReplicasPath")]
        public string StatusReplicasPath { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SpecReplicasPath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SpecReplicasPath");
            }
            if (StatusReplicasPath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StatusReplicasPath");
            }
        }
    }
}
