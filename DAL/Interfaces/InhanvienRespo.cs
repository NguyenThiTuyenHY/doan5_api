using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface InhanvienRespo
    {
        public bool create_nhan_vien(nhanvien nv);
        public bool edit_nhan_vien(string id, nhanvien nv);
        public bool delete_nhan_vien(string id);
        public List<nhanvien> get_nhan_vien_all();
        public nhanvien get_nhan_vien_by_id(string id);
    }
}
