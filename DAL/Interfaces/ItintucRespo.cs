using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface ItintucRespo
    {
        public bool create_tin_tuc(tintuc tt);
        public bool edit_tin_tuc(int id, tintuc tt);
        public bool delete_tin_tuc(int id);
        public List<tintuc> get_tin_tuc_all(int pageSize, int pageIndex, string search);
        public tintuc get_tin_tuc_by_id(int id);
    }
}
