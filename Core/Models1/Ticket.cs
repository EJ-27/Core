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
    public partial class Ticket
    {
               [Key]
            public int Ticket_ID { get; set; }
    
        public string Ticket_Type { get; set; }
    
        public int Ticket_Price { get; set; }
    
        public Nullable<System.DateTime> Ticket_Purchase_date { get; set; }
    
        public Nullable<System.TimeSpan> Ticket_Entry_time { get; set; }
    
        public int Purchase_ID { get; set; }
    
    
        public virtual Purchase Purchase { get; set; }
    }
}
