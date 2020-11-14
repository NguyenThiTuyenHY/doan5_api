using System;
namespace Model
{
    
    
    public partial class baocaodetaikhoahoc
    {
        public int matlbckhoahoc { get; set; }
        public Nullable<int> mabdkh { get; set; }
        public Nullable<int> matulieu { get; set; }
        public string lienket { get; set; }
        public Nullable<System.DateTime> ngaydang { get; set; }
        public Nullable<System.DateTime> ngaychinhsua { get; set; }
        public Nullable<int> manvchinhsua { get; set; }    
        public virtual baocaohoahoc baocaohoahoc { get; set; }
        public virtual tulieu tulieu { get; set; }
    }
}
