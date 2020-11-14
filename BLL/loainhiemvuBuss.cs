using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class loainhiemvuBuss : IloainhienvuBuss
    {
        private IloainhiemvuRespo _Respo;
        public loainhiemvuBuss(IloainhiemvuRespo respo)
        {
            _Respo = respo;
        }
        public bool create_loai_nhiem_vu(loainhiemvu lnv)
        {
            return _Respo.create_loai_nhiem_vu(lnv);
        }

        public bool delete_loai_nhiem_vu(int id)
        {
            return _Respo.delete_loai_nhiem_vu(id);
        }

        public bool edit_loai_nhiem_vu(int id, loainhiemvu lnv)
        {
            return _Respo.edit_loai_nhiem_vu(id, lnv);
        }

        public List<loainhiemvu> get_loai_nhiem_vu_all()
        {
            return _Respo.get_loai_nhiem_vu_all();
        }

        public loainhiemvu get_loai_nhiem_vu_by_id(int id)
        {
            return _Respo.get_loai_nhiem_vu_by_id(id);
        }
    }
}
