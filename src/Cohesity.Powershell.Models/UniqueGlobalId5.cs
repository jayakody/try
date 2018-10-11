// Copyright 2018 Cohesity Inc.

using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Cohesity.Models
{
    /// <summary>
    /// Specifies a global Protection Job id that is unique across Cohesity Clusters.
    /// </summary>
    [DataContract]
    public partial class UniqueGlobalId5 :  IEquatable<UniqueGlobalId5>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueGlobalId5" /> class.
        /// </summary>
        /// <param name="clusterId">Specifies the Cohesity Cluster id where the object was created..</param>
        /// <param name="clusterIncarnationId">Specifies an id for the Cohesity Cluster that is generated when a Cohesity Cluster is initially created..</param>
        /// <param name="id">Specifies a unique id assigned to an object (such as a Job) by the Cohesity Cluster..</param>
        public UniqueGlobalId5(long? clusterId = default(long?), long? clusterIncarnationId = default(long?), long? id = default(long?))
        {
            this.ClusterId = clusterId;
            this.ClusterIncarnationId = clusterIncarnationId;
            this.Id = id;
        }
        
        /// <summary>
        /// Specifies the Cohesity Cluster id where the object was created.
        /// </summary>
        /// <value>Specifies the Cohesity Cluster id where the object was created.</value>
        [DataMember(Name="clusterId", EmitDefaultValue=false)]
        public long? ClusterId { get; set; }

        /// <summary>
        /// Specifies an id for the Cohesity Cluster that is generated when a Cohesity Cluster is initially created.
        /// </summary>
        /// <value>Specifies an id for the Cohesity Cluster that is generated when a Cohesity Cluster is initially created.</value>
        [DataMember(Name="clusterIncarnationId", EmitDefaultValue=false)]
        public long? ClusterIncarnationId { get; set; }

        /// <summary>
        /// Specifies a unique id assigned to an object (such as a Job) by the Cohesity Cluster.
        /// </summary>
        /// <value>Specifies a unique id assigned to an object (such as a Job) by the Cohesity Cluster.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        ///// <summary>
        ///// Returns the string presentation of the object
        ///// </summary>
        ///// <returns>String presentation of the object</returns>
        //public override string ToString()
        //{
        //    var sb = new StringBuilder();
        //    sb.Append("class UniqueGlobalId5 {\n");
        //    sb.Append("  ClusterId: ").Append(ClusterId).Append("\n");
        //    sb.Append("  ClusterIncarnationId: ").Append(ClusterIncarnationId).Append("\n");
        //    sb.Append("  Id: ").Append(Id).Append("\n");
        //    sb.Append("}\n");
        //    return sb.ToString();
        //}
        public override string ToString()
        {
            return ToJson();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UniqueGlobalId5);
        }

        /// <summary>
        /// Returns true if UniqueGlobalId5 instances are equal
        /// </summary>
        /// <param name="input">Instance of UniqueGlobalId5 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UniqueGlobalId5 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterId == input.ClusterId ||
                    (this.ClusterId != null &&
                    this.ClusterId.Equals(input.ClusterId))
                ) && 
                (
                    this.ClusterIncarnationId == input.ClusterIncarnationId ||
                    (this.ClusterIncarnationId != null &&
                    this.ClusterIncarnationId.Equals(input.ClusterIncarnationId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.ClusterId != null)
                    hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.ClusterIncarnationId != null)
                    hashCode = hashCode * 59 + this.ClusterIncarnationId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                return hashCode;
            }
        }

        
    }

}

