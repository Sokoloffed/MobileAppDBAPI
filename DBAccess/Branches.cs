//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Branches
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Branches()
        {
            this.TaskBranch = new HashSet<TaskBranch>();
            this.UserBranch = new HashSet<UserBranch>();
        }
    
        public int id { get; set; }
        public string branchname { get; set; }
        public string description { get; set; }
        public int creator_id { get; set; }
        public System.DateTime created_date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskBranch> TaskBranch { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserBranch> UserBranch { get; set; }
    }
}
