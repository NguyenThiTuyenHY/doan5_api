using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class chucvuBuss : IchucvuBuss
    {
        private readonly IchucvuRespo _Respo;
        public chucvuBuss(IchucvuRespo respo)
        {
            _Respo = respo;
        }
        public bool create_chuc_vu(chucvu cv)
        {
            return _Respo.create_chuc_vu(cv);
        }

        public bool delete_chuc_vu(int id)
        {
            return _Respo.delete_chuc_vu(id);
        }

        public bool edit_chuc_vu(int id, chucvu cv)
        {
            return _Respo.edit_chuc_vu(id, cv);
        }

        public List<chucvu> get_chuc_vu_all()
        {
            return _Respo.get_chuc_vu_all();
        }

        public chucvu get_chuc_vu_by_id(int id)
        {
            return _Respo.get_chuc_vu_by_id(id);
        }
    }
}
