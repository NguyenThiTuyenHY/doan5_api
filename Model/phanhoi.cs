//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class phanhoi
    {
        public int maphanhoi { get; set; }
        public Nullable<int> mabaocao { get; set; }
        public string manv { get; set; }
        public string noidung { get; set; }
        public Nullable<System.DateTime> ngayphanhoi { get; set; }
        public string ghichu { get; set; }
    
        public virtual baocaohoahoc baocaohoahoc { get; set; }
    }
}