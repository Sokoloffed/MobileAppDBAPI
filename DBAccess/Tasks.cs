//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tasks
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tasks()
        {
            this.TaskBranch = new HashSet<TaskBranch>();
            this.UserTask = new HashSet<UserTask>();
        }
    
        public int id { get; set; }
        public string taskname { get; set; }
        public string description { get; set; }
        public System.DateTime date_begin { get; set; }
        public Nullable<System.DateTime> date_end { get; set; }
        public string status { get; set; }
        public int creator_id { get; set; }
        public Nullable<int> executor_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskBranch> TaskBranch { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserTask> UserTask { get; set; }
    }
}
