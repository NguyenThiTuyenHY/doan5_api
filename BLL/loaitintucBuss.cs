using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class loaitintucBuss : IloaitintucBuss
    {
        private readonly IloaitintucRespo _Respo;
        public loaitintucBuss(IloaitintucRespo respo)
        {
            _Respo = respo;
        }

        public bool create_loai_tin_tuc(loaitintuc ltt)
        {
            return _Respo.create_loai_tin_tuc(ltt);
        }

        public bool delete_loai_tin_tuc(int id)
        {
            return _Respo.delete_loai_tin_tuc(id);
        }

        public bool edit_loai_tin_tuc(int id, loaitintuc ltt)
        {
            return _Respo.edit_loai_tin_tuc(id, ltt);
        }

        public List<loaitintuc> get_loai_tin_tuc_all()
        {
            return _Respo.get_loai_tin_tuc_all();
        }

        public loaitintuc get_loai_tin_tuc_by_id(int id)
        {
            return _Respo.get_loai_tin_tuc_by_id(id);
        }
    }
}
