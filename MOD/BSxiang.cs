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
    
    public partial class BSxiang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BSxiang()
        {
            this.baosun = new HashSet<baosun>();
        }
    
        public int bsID { get; set; }
        public Nullable<int> Pid { get; set; }
        public string Ptiaoma { get; set; }
        public string Pguige { get; set; }
        public Nullable<decimal> Pprice { get; set; }
        public Nullable<int> bsSum { get; set; }
        public Nullable<int> bspici { get; set; }
        public string by1 { get; set; }
        public string by2 { get; set; }
        public string by3 { get; set; }
        public string by4 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<baosun> baosun { get; set; }
    }
}
