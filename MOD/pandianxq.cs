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
    
    public partial class pandianxq
    {
        public int pandianxqID { get; set; }
        public string chanpinID { get; set; }
        public string chanpinName { get; set; }
        public string chanpintiaoma { get; set; }
        public Nullable<int> chanpinPrice { get; set; }
        public Nullable<int> pandiansum { get; set; }
        public string chanpinpici { get; set; }
        public string pandianType { get; set; }
        public Nullable<int> pandianTypeID { get; set; }
        public Nullable<int> kehuID { get; set; }
    
        public virtual customer customer { get; set; }
        public virtual pandianType pandianType1 { get; set; }
    }
}
