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
    
    public partial class tbSubjectsInstructors
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbSubjectsInstructors()
        {
            this.tbDays = new HashSet<tbDays>();
            this.tbHours = new HashSet<tbHours>();
        }
    
        public int id { get; set; }
        public int IdSub { get; set; }
        public int IdInst { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDays> tbDays { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHours> tbHours { get; set; }
        public virtual tbInstructors tbInstructors { get; set; }
        public virtual tbSubjects tbSubjects { get; set; }
    }
}
