//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ruku
    {
        public int rukuID { get; set; }
        public Nullable<int> rukuTypeID { get; set; }
        public Nullable<int> gysID { get; set; }
        public string cpID { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<int> zt { get; set; }
        public Nullable<int> UserID { get; set; }
        public string caozuofs { get; set; }
        public Nullable<System.DateTime> createTime { get; set; }
        public Nullable<int> rxID { get; set; }
        public string by1 { get; set; }
        public string by4 { get; set; }
        public string by3 { get; set; }
        public string by2 { get; set; }
    
        public virtual Admin Admin { get; set; }
        public virtual gysguanli gysguanli { get; set; }
        public virtual productguanli productguanli { get; set; }
        public virtual RKxiang RKxiang { get; set; }
        public virtual rukuType rukuType { get; set; }
    }
}
