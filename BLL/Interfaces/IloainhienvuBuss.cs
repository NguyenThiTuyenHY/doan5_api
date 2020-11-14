using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public interface IloainhienvuBuss
    {
        public bool create_loai_nhiem_vu(loainhiemvu lnv);
        public bool edit_loai_nhiem_vu(int id, loainhiemvu lnv);
        public bool delete_loai_nhiem_vu(int id);
        public List<loainhiemvu> get_loai_nhiem_vu_all();
        public loainhiemvu get_loai_nhiem_vu_by_id(int id);
    }
}
