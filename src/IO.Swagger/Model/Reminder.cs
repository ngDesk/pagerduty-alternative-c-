/* 
 * ngDesk_Operations
 *
 * ngDesk_Operations
 *
 * OpenAPI spec version: 2.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Reminder
    /// </summary>
    [DataContract]
    public partial class Reminder :  IEquatable<Reminder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Reminder" /> class.
        /// </summary>
        /// <param name="TICKET_REMINDER_ID">TICKET_REMINDER_ID.</param>
        /// <param name="TICKET_ID">TICKET_ID.</param>
        /// <param name="INTERVAL">INTERVAL.</param>
        /// <param name="RECURRENCE">RECURRENCE.</param>
        /// <param name="TYPE">TYPE.</param>
        /// <param name="DATE_CREATED">DATE_CREATED.</param>
        public Reminder(int? TICKET_REMINDER_ID = default(int?), int? TICKET_ID = default(int?), int? INTERVAL = default(int?), int? RECURRENCE = default(int?), string TYPE = default(string), string DATE_CREATED = default(string))
        {
            this.TICKET_REMINDER_ID = TICKET_REMINDER_ID;
            this.TICKET_ID = TICKET_ID;
            this.INTERVAL = INTERVAL;
            this.RECURRENCE = RECURRENCE;
            this.TYPE = TYPE;
            this.DATE_CREATED = DATE_CREATED;
        }
        
        /// <summary>
        /// Gets or Sets TICKET_REMINDER_ID
        /// </summary>
        [DataMember(Name="TICKET_REMINDER_ID", EmitDefaultValue=false)]
        public int? TICKET_REMINDER_ID { get; set; }

        /// <summary>
        /// Gets or Sets TICKET_ID
        /// </summary>
        [DataMember(Name="TICKET_ID", EmitDefaultValue=false)]
        public int? TICKET_ID { get; set; }

        /// <summary>
        /// Gets or Sets INTERVAL
        /// </summary>
        [DataMember(Name="INTERVAL", EmitDefaultValue=false)]
        public int? INTERVAL { get; set; }

        /// <summary>
        /// Gets or Sets RECURRENCE
        /// </summary>
        [DataMember(Name="RECURRENCE", EmitDefaultValue=false)]
        public int? RECURRENCE { get; set; }

        /// <summary>
        /// Gets or Sets TYPE
        /// </summary>
        [DataMember(Name="TYPE", EmitDefaultValue=false)]
        public string TYPE { get; set; }

        /// <summary>
        /// Gets or Sets DATE_CREATED
        /// </summary>
        [DataMember(Name="DATE_CREATED", EmitDefaultValue=false)]
        public string DATE_CREATED { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Reminder {\n");
            sb.Append("  TICKET_REMINDER_ID: ").Append(TICKET_REMINDER_ID).Append("\n");
            sb.Append("  TICKET_ID: ").Append(TICKET_ID).Append("\n");
            sb.Append("  INTERVAL: ").Append(INTERVAL).Append("\n");
            sb.Append("  RECURRENCE: ").Append(RECURRENCE).Append("\n");
            sb.Append("  TYPE: ").Append(TYPE).Append("\n");
            sb.Append("  DATE_CREATED: ").Append(DATE_CREATED).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Reminder);
        }

        /// <summary>
        /// Returns true if Reminder instances are equal
        /// </summary>
        /// <param name="other">Instance of Reminder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Reminder other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TICKET_REMINDER_ID == other.TICKET_REMINDER_ID ||
                    this.TICKET_REMINDER_ID != null &&
                    this.TICKET_REMINDER_ID.Equals(other.TICKET_REMINDER_ID)
                ) && 
                (
                    this.TICKET_ID == other.TICKET_ID ||
                    this.TICKET_ID != null &&
                    this.TICKET_ID.Equals(other.TICKET_ID)
                ) && 
                (
                    this.INTERVAL == other.INTERVAL ||
                    this.INTERVAL != null &&
                    this.INTERVAL.Equals(other.INTERVAL)
                ) && 
                (
                    this.RECURRENCE == other.RECURRENCE ||
                    this.RECURRENCE != null &&
                    this.RECURRENCE.Equals(other.RECURRENCE)
                ) && 
                (
                    this.TYPE == other.TYPE ||
                    this.TYPE != null &&
                    this.TYPE.Equals(other.TYPE)
                ) && 
                (
                    this.DATE_CREATED == other.DATE_CREATED ||
                    this.DATE_CREATED != null &&
                    this.DATE_CREATED.Equals(other.DATE_CREATED)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.TICKET_REMINDER_ID != null)
                    hash = hash * 59 + this.TICKET_REMINDER_ID.GetHashCode();
                if (this.TICKET_ID != null)
                    hash = hash * 59 + this.TICKET_ID.GetHashCode();
                if (this.INTERVAL != null)
                    hash = hash * 59 + this.INTERVAL.GetHashCode();
                if (this.RECURRENCE != null)
                    hash = hash * 59 + this.RECURRENCE.GetHashCode();
                if (this.TYPE != null)
                    hash = hash * 59 + this.TYPE.GetHashCode();
                if (this.DATE_CREATED != null)
                    hash = hash * 59 + this.DATE_CREATED.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
