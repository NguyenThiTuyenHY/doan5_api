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
    
    public partial class congvan
    {
        public int id { get; set; }
        public string sohieu { get; set; }
        public string tencv { get; set; }
        public Nullable<System.DateTime> ngaybanhanh { get; set; }
        public Nullable<int> loaicongvan { get; set; }
        public string lienket { get; set; }
    
        public virtual loaicongvan loaicongvan1 { get; set; }
    }
}
