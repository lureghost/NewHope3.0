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
    
    public partial class baosun
    {
        public int baosunID { get; set; }
        public Nullable<int> baosunTypeID { get; set; }
        public Nullable<int> bsID { get; set; }
        public string cpid { get; set; }
        public Nullable<int> baosunSum { get; set; }
        public Nullable<int> zt { get; set; }
        public Nullable<int> UserID { get; set; }
        public string caozuofs { get; set; }
        public string createTime { get; set; }
        public string by1 { get; set; }
        public string by2 { get; set; }
        public string by3 { get; set; }
        public string by4 { get; set; }
    
        public virtual Admin Admin { get; set; }
        public virtual baosunType baosunType { get; set; }
        public virtual BSxiang BSxiang { get; set; }
        public virtual productguanli productguanli { get; set; }
    }
}