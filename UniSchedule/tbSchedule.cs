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
    
    public partial class tbSchedule
    {
        public int id { get; set; }
        public int SubjectsId { get; set; }
        public int ClassroomId { get; set; }
        public int GroupsId { get; set; }
        public int InstructorsId { get; set; }
    
        public virtual tbClassroom tbClassroom { get; set; }
        public virtual tbGroups tbGroups { get; set; }
        public virtual tbInstructors tbInstructors { get; set; }
        public virtual tbSubjects tbSubjects { get; set; }
    }
}
