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
    /// A structure representing information about a settlement
    /// </summary>
    [DataContract(Name = "PaymentSettlementSummary")]
    public partial class PaymentSettlementSummary : IEquatable<PaymentSettlementSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentSettlementSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentSettlementSummary()
        {
        }

        /// <summary>
        /// Date and time capture request has been submitted. May be null if capture request was not immediately acknowledged by payment gateway.
        /// </summary>
        /// <value>Date and time capture request has been submitted. May be null if capture request was not immediately acknowledged by payment gateway.</value>
        [DataMember(Name = "capture_submit_time", EmitDefaultValue = false)]
        public string CaptureSubmitTime { get; private set; }

        /// <summary>
        /// Returns false as CaptureSubmitTime should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCaptureSubmitTime()
        {
            return false;
        }
        /// <summary>
        /// Date of the capture event.
        /// </summary>
        /// <value>Date of the capture event.</value>
        [DataMember(Name = "captured_date", EmitDefaultValue = false)]
        public string CapturedDate { get; private set; }

        /// <summary>
        /// Returns false as CapturedDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCapturedDate()
        {
            return false;
        }
        /// <summary>
        /// The date that the transaction was paid into the service&#39;s account.
        /// </summary>
        /// <value>The date that the transaction was paid into the service&#39;s account.</value>
        [DataMember(Name = "settled_date", EmitDefaultValue = false)]
        public string SettledDate { get; private set; }

        /// <summary>
        /// Returns false as SettledDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSettledDate()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentSettlementSummary {\n");
            sb.Append("  CaptureSubmitTime: ").Append(CaptureSubmitTime).Append("\n");
            sb.Append("  CapturedDate: ").Append(CapturedDate).Append("\n");
            sb.Append("  SettledDate: ").Append(SettledDate).Append("\n");
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
            return this.Equals(input as PaymentSettlementSummary);
        }

        /// <summary>
        /// Returns true if PaymentSettlementSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentSettlementSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentSettlementSummary input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CaptureSubmitTime == input.CaptureSubmitTime ||
                    (this.CaptureSubmitTime != null &&
                    this.CaptureSubmitTime.Equals(input.CaptureSubmitTime))
                ) && 
                (
                    this.CapturedDate == input.CapturedDate ||
                    (this.CapturedDate != null &&
                    this.CapturedDate.Equals(input.CapturedDate))
                ) && 
                (
                    this.SettledDate == input.SettledDate ||
                    (this.SettledDate != null &&
                    this.SettledDate.Equals(input.SettledDate))
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
                if (this.CaptureSubmitTime != null)
                {
                    hashCode = (hashCode * 59) + this.CaptureSubmitTime.GetHashCode();
                }
                if (this.CapturedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CapturedDate.GetHashCode();
                }
                if (this.SettledDate != null)
                {
                    hashCode = (hashCode * 59) + this.SettledDate.GetHashCode();
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
