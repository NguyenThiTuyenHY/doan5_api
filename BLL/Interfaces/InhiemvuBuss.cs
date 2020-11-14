using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public interface InhiemvuBuss
    {
        public bool create_nhiem_vu(nhiemvu nv);
        public bool edit_nhiem_vu(int id, nhiemvu nv);
        public bool delete_nhiem_vu(int id);
        public List<nhiemvu> get_nhiem_vu_all();
        public nhiemvu get_nhiem_vu_by_id(int id);
    }
}
