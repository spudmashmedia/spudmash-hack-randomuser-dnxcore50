using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Spudmash.Api.Models
{
    /// <summary>
    ///
    /// </summary>
    public partial class AddressType :  IEquatable<AddressType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressType" /> class.
        /// </summary>
        /// <param name="Street">Street.</param>
        /// <param name="City">City.</param>
        /// <param name="State">State.</param>
        /// <param name="Zip">Zip.</param>
        public AddressType(string Street = null, string City = null, string State = null, string Zip = null)
        {
            this.Street = Street;
            this.City = City;
            this.State = State;
            this.Zip = Zip;

        }


        /// <summary>
        /// Gets or Sets Street
        /// </summary>
        public string Street { get; set; }


        /// <summary>
        /// Gets or Sets City
        /// </summary>
        public string City { get; set; }


        /// <summary>
        /// Gets or Sets State
        /// </summary>
        public string State { get; set; }


        /// <summary>
        /// Gets or Sets Zip
        /// </summary>
        public string Zip { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddressType {\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");

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
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((AddressType)obj);
        }

        /// <summary>
        /// Returns true if AddressType instances are equal
        /// </summary>
        /// <param name="other">Instance of AddressType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressType other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    this.Street == other.Street ||
                    this.Street != null &&
                    this.Street.Equals(other.Street)
                ) &&
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.Zip == other.Zip ||
                    this.Zip != null &&
                    this.Zip.Equals(other.Zip)
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

                    if (this.Street != null)
                    hash = hash * 59 + this.Street.GetHashCode();

                    if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();

                    if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                    if (this.Zip != null)
                    hash = hash * 59 + this.Zip.GetHashCode();

                return hash;
            }
        }

        #region Operators

        public static bool operator ==(AddressType left, AddressType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AddressType left, AddressType right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
