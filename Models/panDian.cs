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
    
    public partial class panDian
    {
        public int pandianID { get; set; }
        public Nullable<int> pandianTypeID { get; set; }
        public string chanpinID { get; set; }
        public Nullable<int> UserID { get; set; }
        public string caozuofs { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<int> state { get; set; }
    
        public virtual Admin Admin { get; set; }
        public virtual pandianType pandianType { get; set; }
        public virtual productguanli productguanli { get; set; }
    }
}
