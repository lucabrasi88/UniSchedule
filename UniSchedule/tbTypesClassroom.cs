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
    
    public partial class tbTypesClassroom
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbTypesClassroom()
        {
            this.tbClassroom = new HashSet<tbClassroom>();
        }
    
        public int id { get; set; }
        public string NameTypes { get; set; }
        public int ClassroomId { get; set; }
        public string Types_ { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbClassroom> tbClassroom { get; set; }
    }
}