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
    
    public partial class baocaohoahoc
    {    
        public int mabckhoahoc { get; set; }
        public string tenbckhoahoc { get; set; }
        public string manvdexuat { get; set; }
        public string coquanchutri { get; set; }
        public Nullable<System.DateTime> thoigianbd { get; set; }
        public Nullable<System.DateTime> thoigianketthuc { get; set; }
        public string tongquan { get; set; }
        public string tinhcapthiet { get; set; }
        public string muctieu { get; set; }
        public string noidung { get; set; }
        public string ppnghiencu { get; set; }
        public string hqktxh { get; set; }
        public string donvisd { get; set; }
        public Nullable<int> tinhtrang { get; set; }
        public string matroly { get; set; }
        public Nullable<int> malinhvuc { get; set; }
        public string mavanbang { get; set; }
        public Nullable<int> maloainhiemvu { get; set; }
        public Nullable<int> mahdnckh { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<baocaodetaikhoahoc> baocaodetaikhoahocs { get; set; }
        public virtual linhvuc linhvuc { get; set; }
        public virtual loainhiemvu loainhiemvu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ketquanghiencuu> ketquanghiencuus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nhiemvu> nhiemvus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<phanhoi> phanhois { get; set; }
    }
}