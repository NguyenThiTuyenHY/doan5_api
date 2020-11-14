using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public interface IchucvuBuss
    {
        public bool create_chuc_vu(chucvu cv);
        public bool edit_chuc_vu(int id, chucvu cv);
        public bool delete_chuc_vu(int id);
        public List<chucvu> get_chuc_vu_all();
        public chucvu get_chuc_vu_by_id(int id);
    }
}
