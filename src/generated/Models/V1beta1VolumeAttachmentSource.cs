// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// VolumeAttachmentSource represents a volume that should be attached.
    /// Right now only PersistenVolumes can be attached via external attacher,
    /// in future we may allow also inline volumes in pods. Exactly one member
    /// can be set.
    /// </summary>
    public partial class V1beta1VolumeAttachmentSource
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1VolumeAttachmentSource
        /// class.
        /// </summary>
        public V1beta1VolumeAttachmentSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1VolumeAttachmentSource
        /// class.
        /// </summary>
        /// <param name="persistentVolumeName">Name of the persistent volume to
        /// attach.</param>
        public V1beta1VolumeAttachmentSource(string persistentVolumeName = default(string))
        {
            PersistentVolumeName = persistentVolumeName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the persistent volume to attach.
        /// </summary>
        [JsonProperty(PropertyName = "persistentVolumeName")]
        public string PersistentVolumeName { get; set; }

    }
}
