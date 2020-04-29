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
    
    public partial class productguanli
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public productguanli()
        {
            this.baosun = new HashSet<baosun>();
            this.chuku = new HashSet<chuku>();
            this.panDian = new HashSet<panDian>();
            this.ruku = new HashSet<ruku>();
            this.tuihuo = new HashSet<tuihuo>();
            this.yiku = new HashSet<yiku>();
        }
    
        public int ID { get; set; }
        public string cpID { get; set; }
        public string cpName { get; set; }
        public Nullable<int> upper { get; set; }
        public Nullable<int> floor { get; set; }
        public Nullable<decimal> price { get; set; }
        public string specification { get; set; }
        public Nullable<int> PID { get; set; }
        public Nullable<int> MID { get; set; }
        public string remark { get; set; }
        public Nullable<int> kehuID { get; set; }
        public Nullable<int> WID { get; set; }
        public Nullable<int> XID { get; set; }
        public Nullable<int> defaultstorage { get; set; }
        public Nullable<int> state { get; set; }
        public Nullable<int> kucun { get; set; }
        public string by2 { get; set; }
        public Nullable<int> kucun { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<baosun> baosun { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chuku> chuku { get; set; }
        public virtual customer customer { get; set; }
        public virtual KuType KuType { get; set; }
        public virtual measurement measurement { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<panDian> panDian { get; set; }
        public virtual productType productType { get; set; }
        public virtual warehouse warehouse { get; set; }
        public virtual productguanli productguanli1 { get; set; }
        public virtual productguanli productguanli2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ruku> ruku { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tuihuo> tuihuo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<yiku> yiku { get; set; }
    }
}
