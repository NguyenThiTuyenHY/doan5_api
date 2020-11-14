using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class linhvucBuss : IlinhvucBuss
    {
        private readonly IlinhvucRespo _Buss;
        public linhvucBuss(IlinhvucRespo buss)
        {
            _Buss = buss;
        }

        public bool create_linh_vuc(linhvuc lv)
        {
            return _Buss.create_linh_vuc(lv);
        }

        public bool delete_linh_vuc(int id)
        {
            return _Buss.delete_linh_vuc(id);
        }

        public bool edit_linh_vuc(int id, linhvuc lv)
        {
            return _Buss.edit_linh_vuc(id, lv);
        }

        public List<linhvuc> get_linh_vuc_all()
        {
            return _Buss.get_linh_vuc_all();
        }

        public linhvuc get_linh_vuc_by_id(int id)
        {
            return _Buss.get_linh_vuc_by_id(id);
        }
    }
}
