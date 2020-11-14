using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IdonviRespo
    {
        public bool create_don_vi(donvi dv);
        public bool edit_don_vi(int id, donvi dv);
        public bool delete_don_vi(int id);
        public List<donvi> get_don_vi_all();
        public donvi get_don_vi_by_id(int id);
    }
}
