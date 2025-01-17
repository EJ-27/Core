//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public partial class Enclosure
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Enclosure()
        {
            this.Animals = new HashSet<Animal>();
            this.Closings = new HashSet<Closing>();
        }
    
               [Key]
            public int? Enclosure_ID { get; set; }
    
        public string Enclosure_Name { get; set; }
    
        public string Enclosure_Department { get; set; }
    
        public System.TimeSpan Enclosure_Open_time { get; set; }
    
        public System.TimeSpan Enclosure_Close_time { get; set; }
    
        public System.TimeSpan Enclosure_Cleaning_time { get; set; }
    
        public System.TimeSpan Enclosure_Feeding_time { get; set; }
    
        public int? Zookeeper_ID { get; set; }
    
        public string Occupancy_Status { get; set; }
    
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Animal> Animals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Closing> Closings { get; set; }
        public virtual Zookeeper Zookeeper { get; set; }
    }
}
