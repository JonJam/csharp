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
    /// WebhookClientConfig contains the information to make a TLS connection
    /// with the webhook
    /// </summary>
    public partial class V1beta1WebhookClientConfig
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1WebhookClientConfig class.
        /// </summary>
        public V1beta1WebhookClientConfig()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1WebhookClientConfig class.
        /// </summary>
        /// <param name="caBundle">`caBundle` is a PEM encoded CA bundle which
        /// will be used to validate the webhook's server certificate.
        /// Required.</param>
        /// <param name="service">`service` is a reference to the service for
        /// this webhook. Either `service` or `url` must be specified.
        ///
        /// If the webhook is running within the cluster, then you should use
        /// `service`.
        ///
        /// Port 443 will be used if it is open, otherwise it is an
        /// error.</param>
        /// <param name="url">`url` gives the location of the webhook, in
        /// standard URL form (`[scheme://]host:port/path`). Exactly one of
        /// `url` or `service` must be specified.
        ///
        /// The `host` should not refer to a service running in the cluster;
        /// use the `service` field instead. The host might be resolved via
        /// external DNS in some apiservers (e.g., `kube-apiserver` cannot
        /// resolve in-cluster DNS as that would be a layering violation).
        /// `host` may also be an IP address.
        ///
        /// Please note that using `localhost` or `127.0.0.1` as a `host` is
        /// risky unless you take great care to run this webhook on all hosts
        /// which run an apiserver which might need to make calls to this
        /// webhook. Such installs are likely to be non-portable, i.e., not
        /// easy to turn up in a new cluster.
        ///
        /// The scheme must be "https"; the URL must begin with "https://".
        ///
        /// A path is optional, and if present may be any string permissible in
        /// a URL. You may use the path to pass an arbitrary string to the
        /// webhook, for example, a cluster identifier.
        ///
        /// Attempting to use a user or basic auth e.g. "user:password@" is not
        /// allowed. Fragments ("#...") and query parameters ("?...") are not
        /// allowed, either.</param>
        public V1beta1WebhookClientConfig(byte[] caBundle, Admissionregistrationv1beta1ServiceReference service = default(Admissionregistrationv1beta1ServiceReference), string url = default(string))
        {
            CaBundle = caBundle;
            Service = service;
            Url = url;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets `caBundle` is a PEM encoded CA bundle which will be
        /// used to validate the webhook's server certificate. Required.
        /// </summary>
        [JsonProperty(PropertyName = "caBundle")]
        public byte[] CaBundle { get; set; }

        /// <summary>
        /// Gets or sets `service` is a reference to the service for this
        /// webhook. Either `service` or `url` must be specified.
        ///
        /// If the webhook is running within the cluster, then you should use
        /// `service`.
        ///
        /// Port 443 will be used if it is open, otherwise it is an error.
        /// </summary>
        [JsonProperty(PropertyName = "service")]
        public Admissionregistrationv1beta1ServiceReference Service { get; set; }

        /// <summary>
        /// Gets or sets `url` gives the location of the webhook, in standard
        /// URL form (`[scheme://]host:port/path`). Exactly one of `url` or
        /// `service` must be specified.
        ///
        /// The `host` should not refer to a service running in the cluster;
        /// use the `service` field instead. The host might be resolved via
        /// external DNS in some apiservers (e.g., `kube-apiserver` cannot
        /// resolve in-cluster DNS as that would be a layering violation).
        /// `host` may also be an IP address.
        ///
        /// Please note that using `localhost` or `127.0.0.1` as a `host` is
        /// risky unless you take great care to run this webhook on all hosts
        /// which run an apiserver which might need to make calls to this
        /// webhook. Such installs are likely to be non-portable, i.e., not
        /// easy to turn up in a new cluster.
        ///
        /// The scheme must be "https"; the URL must begin with "https://".
        ///
        /// A path is optional, and if present may be any string permissible in
        /// a URL. You may use the path to pass an arbitrary string to the
        /// webhook, for example, a cluster identifier.
        ///
        /// Attempting to use a user or basic auth e.g. "user:password@" is not
        /// allowed. Fragments ("#...") and query parameters ("?...") are not
        /// allowed, either.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (CaBundle == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CaBundle");
            }
            if (Service != null)
            {
                Service.Validate();
            }
        }
    }
}
