using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class nhiemvuBuss : InhiemvuBuss
    {
        private readonly InhiemvuRespo _Respo;
        public nhiemvuBuss(InhiemvuRespo respo)
        {
            _Respo = respo;
        }
        public bool create_nhiem_vu(nhiemvu nv)
        {
            return _Respo.create_nhiem_vu(nv);
        }

        public bool delete_nhiem_vu(int id)
        {
            return _Respo.delete_nhiem_vu(id);
        }

        public bool edit_nhiem_vu(int id, nhiemvu nv)
        {
            return _Respo.edit_nhiem_vu(id,nv);
        }

        public List<nhiemvu> get_nhiem_vu_all()
        {
            return _Respo.get_nhiem_vu_all();
        }

        public nhiemvu get_nhiem_vu_by_id(int id)
        {
            return _Respo.get_nhiem_vu_by_id(id);
        }
    }
}
