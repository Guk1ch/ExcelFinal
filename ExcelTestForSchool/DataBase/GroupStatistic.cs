//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExcelTestForSchool.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class GroupStatistic
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GroupStatistic()
        {
            this.GroupTime = new HashSet<GroupTime>();
        }
    
        public int ID { get; set; }
        public Nullable<int> IDStudent { get; set; }
        public Nullable<int> IDLesson { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GroupTime> GroupTime { get; set; }
        public virtual Lesson Lesson { get; set; }
        public virtual Student Student { get; set; }
    }
}
