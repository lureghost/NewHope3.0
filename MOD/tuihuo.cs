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
    
    public partial class tuihuo
    {
        public int tuihuoID { get; set; }
        public Nullable<int> tuihuoTypeID { get; set; }
        public Nullable<int> sum { get; set; }
        public string chanpinID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<int> state { get; set; }
    
        public virtual Admin Admin { get; set; }
        public virtual productguanli productguanli { get; set; }
        public virtual tuihuoType tuihuoType { get; set; }
    }
}