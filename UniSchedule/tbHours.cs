//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UniSchedule
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbHours
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbHours()
        {
            this.tbDays = new HashSet<tbDays>();
        }
    
        public int id { get; set; }
        public System.DateTime Hour_ { get; set; }
        public int IdSubInst { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDays> tbDays { get; set; }
        public virtual tbSubjectsInstructors tbSubjectsInstructors { get; set; }
    }
}