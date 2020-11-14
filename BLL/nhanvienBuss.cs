using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class nhanvienBuss : InhanvienBuss
    {
        private readonly nhanvienRespo _Respo;
        public nhanvienBuss(nhanvienRespo respo)
        {
            _Respo = respo;
        }

        public bool create_nhan_vien(nhanvien nv)
        {
            return _Respo.create_nhan_vien(nv);
        }

        public bool delete_nhan_vien(string id)
        {
            return _Respo.delete_nhan_vien(id);
        }

        public bool edit_nhan_vien(string id, nhanvien nv)
        {
            return _Respo.edit_nhan_vien(id, nv);
        }

        public List<nhanvien> get_nhan_vien_all()
        {
            return _Respo.get_nhan_vien_all();
        }

        public nhanvien get_nhan_vien_by_id(string id)
        {
            return _Respo.get_nhan_vien_by_id(id);
        }
    }
}
