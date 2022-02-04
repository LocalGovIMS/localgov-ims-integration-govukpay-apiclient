/*
 * GOV.UK Pay API
 *
 * GOV.UK Pay API
 *
 * The version of the OpenAPI document: 1.0.3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = GovUKPayApiClient.Client.OpenAPIDateConverter;

namespace GovUKPayApiClient.Model
{
    /// <summary>
    /// links for payment
    /// </summary>
    [DataContract(Name = "PaymentLinks")]
    public partial class PaymentLinks : IEquatable<PaymentLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentLinks" /> class.
        /// </summary>
        /// <param name="cancel">cancel.</param>
        /// <param name="capture">capture.</param>
        /// <param name="events">events.</param>
        /// <param name="nextUrl">nextUrl.</param>
        /// <param name="nextUrlPost">nextUrlPost.</param>
        /// <param name="refunds">refunds.</param>
        /// <param name="self">self.</param>
        public PaymentLinks(PostLink cancel = default(PostLink), PostLink capture = default(PostLink), Link events = default(Link), Link nextUrl = default(Link), PostLink nextUrlPost = default(PostLink), Link refunds = default(Link), Link self = default(Link))
        {
            this.Cancel = cancel;
            this.Capture = capture;
            this.Events = events;
            this.NextUrl = nextUrl;
            this.NextUrlPost = nextUrlPost;
            this.Refunds = refunds;
            this.Self = self;
        }

        /// <summary>
        /// Gets or Sets Cancel
        /// </summary>
        [DataMember(Name = "cancel", EmitDefaultValue = false)]
        public PostLink Cancel { get; set; }

        /// <summary>
        /// Gets or Sets Capture
        /// </summary>
        [DataMember(Name = "capture", EmitDefaultValue = false)]
        public PostLink Capture { get; set; }

        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name = "events", EmitDefaultValue = false)]
        public Link Events { get; set; }

        /// <summary>
        /// Gets or Sets NextUrl
        /// </summary>
        [DataMember(Name = "next_url", EmitDefaultValue = false)]
        public Link NextUrl { get; set; }

        /// <summary>
        /// Gets or Sets NextUrlPost
        /// </summary>
        [DataMember(Name = "next_url_post", EmitDefaultValue = false)]
        public PostLink NextUrlPost { get; set; }

        /// <summary>
        /// Gets or Sets Refunds
        /// </summary>
        [DataMember(Name = "refunds", EmitDefaultValue = false)]
        public Link Refunds { get; set; }

        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name = "self", EmitDefaultValue = false)]
        public Link Self { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentLinks {\n");
            sb.Append("  Cancel: ").Append(Cancel).Append("\n");
            sb.Append("  Capture: ").Append(Capture).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  NextUrl: ").Append(NextUrl).Append("\n");
            sb.Append("  NextUrlPost: ").Append(NextUrlPost).Append("\n");
            sb.Append("  Refunds: ").Append(Refunds).Append("\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PaymentLinks);
        }

        /// <summary>
        /// Returns true if PaymentLinks instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentLinks input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Cancel == input.Cancel ||
                    (this.Cancel != null &&
                    this.Cancel.Equals(input.Cancel))
                ) && 
                (
                    this.Capture == input.Capture ||
                    (this.Capture != null &&
                    this.Capture.Equals(input.Capture))
                ) && 
                (
                    this.Events == input.Events ||
                    (this.Events != null &&
                    this.Events.Equals(input.Events))
                ) && 
                (
                    this.NextUrl == input.NextUrl ||
                    (this.NextUrl != null &&
                    this.NextUrl.Equals(input.NextUrl))
                ) && 
                (
                    this.NextUrlPost == input.NextUrlPost ||
                    (this.NextUrlPost != null &&
                    this.NextUrlPost.Equals(input.NextUrlPost))
                ) && 
                (
                    this.Refunds == input.Refunds ||
                    (this.Refunds != null &&
                    this.Refunds.Equals(input.Refunds))
                ) && 
                (
                    this.Self == input.Self ||
                    (this.Self != null &&
                    this.Self.Equals(input.Self))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Cancel != null)
                {
                    hashCode = (hashCode * 59) + this.Cancel.GetHashCode();
                }
                if (this.Capture != null)
                {
                    hashCode = (hashCode * 59) + this.Capture.GetHashCode();
                }
                if (this.Events != null)
                {
                    hashCode = (hashCode * 59) + this.Events.GetHashCode();
                }
                if (this.NextUrl != null)
                {
                    hashCode = (hashCode * 59) + this.NextUrl.GetHashCode();
                }
                if (this.NextUrlPost != null)
                {
                    hashCode = (hashCode * 59) + this.NextUrlPost.GetHashCode();
                }
                if (this.Refunds != null)
                {
                    hashCode = (hashCode * 59) + this.Refunds.GetHashCode();
                }
                if (this.Self != null)
                {
                    hashCode = (hashCode * 59) + this.Self.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
