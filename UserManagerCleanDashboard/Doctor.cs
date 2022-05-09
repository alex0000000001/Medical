//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Medical
{
    using System;
    using System.Collections.Generic;
    
    public partial class Doctor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doctor()
        {
            this.Articles = new HashSet<Article>();
            this.RatingDoctors = new HashSet<RatingDoctor>();
        }
    
        public int DoctorID { get; set; }
        public int MemberID { get; set; }
        public string DoctorName { get; set; }
        public int DepartmentID { get; set; }
        public string Education { get; set; }
        public string JobTitle { get; set; }
        public int TreatmentID { get; set; }
        public byte[] Picture { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Article> Articles { get; set; }
        public virtual Department Department { get; set; }
        public virtual Member Member { get; set; }
        public virtual Treatment Treatment { get; set; }
        public virtual Experience Experience { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RatingDoctor> RatingDoctors { get; set; }
    }
}
