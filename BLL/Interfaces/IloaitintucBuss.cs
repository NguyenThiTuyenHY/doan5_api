using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public interface IloaitintucBuss
    {
        public bool create_loai_tin_tuc(loaitintuc ltt);
        public bool edit_loai_tin_tuc(int id, loaitintuc ltt);
        public bool delete_loai_tin_tuc(int id);
        public List<loaitintuc> get_loai_tin_tuc_all();
        public loaitintuc get_loai_tin_tuc_by_id(int id);
    }
}
