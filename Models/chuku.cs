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
    
    public partial class chuku
    {
        public int chukuID { get; set; }
        public Nullable<int> chukuTypeID { get; set; }
        public Nullable<int> ckID { get; set; }
        public Nullable<int> kehuID { get; set; }
        public string cpID { get; set; }
        public Nullable<int> chukuSum { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<int> zt { get; set; }
        public Nullable<int> UserID { get; set; }
        public string caozuofs { get; set; }
        public Nullable<System.DateTime> createTime { get; set; }
        public string by1 { get; set; }
        public string by2 { get; set; }
        public string by3 { get; set; }
        public string by4 { get; set; }
    
        public virtual Admin Admin { get; set; }
        public virtual chukuType chukuType { get; set; }
        public virtual CKxiang CKxiang { get; set; }
        public virtual customer customer { get; set; }
        public virtual productguanli productguanli { get; set; }
    }
}