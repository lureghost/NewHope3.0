//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MOD
{
    using System;
    using System.Collections.Generic;
    
    public partial class CKxiang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CKxiang()
        {
            this.chuku = new HashSet<chuku>();
        }
    
        public int ckID { get; set; }
        public Nullable<int> Pid { get; set; }
        public string Ptiaoma { get; set; }
        public string Pguige { get; set; }
        public Nullable<decimal> Pprice { get; set; }
        public Nullable<int> ckpici { get; set; }
        public Nullable<int> Tid { get; set; }
        public Nullable<int> chuSum { get; set; }
        public string by2 { get; set; }
        public string by3 { get; set; }
        public string by4 { get; set; }
        public Nullable<int> zt { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chuku> chuku { get; set; }
        public virtual chukuType chukuType { get; set; }
    }
}
