//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VallarTamilSchool
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sechedule
    {
        public int SecheduleId { get; set; }
        public Nullable<int> StudnetId { get; set; }
        public Nullable<int> ClassId { get; set; }
        public string PrefferedSchedule { get; set; }
    
        public virtual Class Class { get; set; }
        public virtual Student Student { get; set; }
    }
}
