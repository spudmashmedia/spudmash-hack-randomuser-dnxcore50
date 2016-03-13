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
    public partial class PictureType :  IEquatable<PictureType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PictureType" /> class.
        /// </summary>
        /// <param name="Large">large image url.</param>
        /// <param name="Medium">medium image url.</param>
        /// <param name="Thumbnail">thumbnail.</param>
        public PictureType(string Large = null, string Medium = null, string Thumbnail = null)
        {
            this.Large = Large;
            this.Medium = Medium;
            this.Thumbnail = Thumbnail;

        }


        /// <summary>
        /// large image url
        /// </summary>
        /// <value>large image url</value>
        public string Large { get; set; }


        /// <summary>
        /// medium image url
        /// </summary>
        /// <value>medium image url</value>
        public string Medium { get; set; }


        /// <summary>
        /// thumbnail
        /// </summary>
        /// <value>thumbnail</value>
        public string Thumbnail { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PictureType {\n");
            sb.Append("  Large: ").Append(Large).Append("\n");
            sb.Append("  Medium: ").Append(Medium).Append("\n");
            sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");

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
            return Equals((PictureType)obj);
        }

        /// <summary>
        /// Returns true if PictureType instances are equal
        /// </summary>
        /// <param name="other">Instance of PictureType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PictureType other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    this.Large == other.Large ||
                    this.Large != null &&
                    this.Large.Equals(other.Large)
                ) &&
                (
                    this.Medium == other.Medium ||
                    this.Medium != null &&
                    this.Medium.Equals(other.Medium)
                ) &&
                (
                    this.Thumbnail == other.Thumbnail ||
                    this.Thumbnail != null &&
                    this.Thumbnail.Equals(other.Thumbnail)
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

                    if (this.Large != null)
                    hash = hash * 59 + this.Large.GetHashCode();

                    if (this.Medium != null)
                    hash = hash * 59 + this.Medium.GetHashCode();

                    if (this.Thumbnail != null)
                    hash = hash * 59 + this.Thumbnail.GetHashCode();

                return hash;
            }
        }

        #region Operators

        public static bool operator ==(PictureType left, PictureType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PictureType left, PictureType right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
