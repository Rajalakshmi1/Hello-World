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
    
    public partial class Teacher
    {
        public int TeacherId { get; set; }
        public string TeachersFirstName { get; set; }
        public string TeachersLastName { get; set; }
        public string TeahcersAddress { get; set; }
        public string TeachersPhoneNo { get; set; }
        public string TeachersEmailid { get; set; }
        public Nullable<int> ClassId { get; set; }
    
        public virtual Class Class { get; set; }
        public virtual Class Class1 { get; set; }
    }
}