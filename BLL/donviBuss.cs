using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class donviBuss : IdonviBuss
    {
        private readonly IdonviRespo _Respo;
        public donviBuss(IdonviRespo respo)
        {
            _Respo = respo;
        }
        public bool create_don_vi(donvi dv)
        {
            return _Respo.create_don_vi(dv);
        }

        public bool delete_don_vi(int id)
        {
            return _Respo.delete_don_vi(id);
        }

        public bool edit_don_vi(int id, donvi dv)
        {
            return _Respo.edit_don_vi(id, dv);
        }

        public List<donvi> get_don_vi_all()
        {
            return _Respo.get_don_vi_all();
        }

        public donvi get_don_vi_by_id(int id)
        {
            return _Respo.get_don_vi_by_id(id);
        }
    }
}
