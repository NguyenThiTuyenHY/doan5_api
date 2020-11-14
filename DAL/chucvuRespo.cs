using DAL.Helper;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class chucvuRespo : IchucvuRespo
    {
        private readonly IDatabaseHelper _Helper;
        public chucvuRespo (IDatabaseHelper helper)
        {
            _Helper = helper;
        }

        public bool create_chuc_vu(chucvu cv)
        {
            string msgError = "";
            try
            {
                var result = _Helper.ExecuteScalarSProcedureWithTransaction(out msgError, "create_don_vi", "@ten_cv",cv.tenchucvu, "@dieu_kien", cv.dieukien,"@dinh_muc", cv.dinhmuc, "@ghi_chu", cv.ghichu);
                if ((!string.IsNullOrEmpty(msgError)) || (!string.IsNullOrEmpty(result.ToString()) && result != null))
                    throw new Exception(msgError);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool delete_chuc_vu(int id)
        {
            string msgError = "";
            try
            {
                var result = _Helper.ExecuteScalarSProcedureWithTransaction(out msgError, "delete_chuc_vu", "@id", id);
                if ((!string.IsNullOrEmpty(msgError)) || (!string.IsNullOrEmpty(result.ToString()) && result != null))
                    throw new Exception(msgError);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool edit_chuc_vu(int id, chucvu cv)
        {
            string msgError = "";
            try
            {
                var result = _Helper.ExecuteScalarSProcedureWithTransaction(out msgError, "edit_chuc_vu", "@id", id, "@ten_cv", cv.tenchucvu, "@dieu_kien", cv.dieukien, "@dinh_muc", cv.dinhmuc, "@ghi_chu", cv.ghichu);
                if ((!string.IsNullOrEmpty(msgError)) || (!string.IsNullOrEmpty(result.ToString()) && result != null))
                    throw new Exception(msgError);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<chucvu> get_chuc_vu_all()
        {
            string msgError = "";
            try
            {
                var result = _Helper.ExecuteSProcedureReturnDataTable(out msgError, "get_chuc_vu_all");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return result.ConvertTo<chucvu>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public chucvu get_chuc_vu_by_id(int id)
        {
            string msgError = "";
            try
            {
                var result = _Helper.ExecuteSProcedureReturnDataTable(out msgError, "get_chuc_vu_by_id", "@id", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return result.ConvertTo<chucvu>().SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
