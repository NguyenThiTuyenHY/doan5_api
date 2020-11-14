using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class tintucBuss:ItintucBuss
    {
        private readonly ItintucRespo _Respo;
        public tintucBuss(ItintucRespo respo)
        {
            _Respo = respo;
        }

        public bool create_tin_tuc(tintuc tt)
        {
            return _Respo.create_tin_tuc(tt);
        }

        public bool delete_tin_tuc(int id)
        {
            return _Respo.delete_tin_tuc(id);
        }

        public bool edit_tin_tuc(int id, tintuc tt)
        {
            return _Respo.edit_tin_tuc(id, tt);
        }

        public List<tintuc> get_tin_tuc_all(int pageSize, int pageIndex, string search)
        {
            return _Respo.get_tin_tuc_all(pageSize, pageIndex, search);
        }

        public tintuc get_tin_tuc_by_id(int id)
        {
            return _Respo.get_tin_tuc_by_id(id);
        }
    }
}
