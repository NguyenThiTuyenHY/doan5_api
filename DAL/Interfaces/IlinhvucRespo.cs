using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IlinhvucRespo
    {
        public bool create_linh_vuc(linhvuc lv);
        public bool edit_linh_vuc(int id, linhvuc lv);
        public bool delete_linh_vuc(int id);
        public List<linhvuc> get_linh_vuc_all();
        public linhvuc get_linh_vuc_by_id(int id);
    }
}
