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
    public partial class Event
    {
               [Key]
            public int Event_ID { get; set; }
    
        public string Event_name { get; set; }
    
        public System.TimeSpan Event_start_time { get; set; }
    
        public System.TimeSpan Event_end_time { get; set; }
    
        public int Event_employee_rep_ID { get; set; }
    
    
        public virtual Employee Employee { get; set; }
    }
}
