using DAL.Helper;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class donviRespo:IdonviRespo
    {
        private readonly IDatabaseHelper _Helper;
        public donviRespo(IDatabaseHelper helper)
        {
            _Helper = helper;
        }

        public bool create_don_vi(donvi dv)
        {
            string msgError = "";
            try
            {
                var result = _Helper.ExecuteScalarSProcedureWithTransaction(out msgError, "create_don_vi", "@tendonvi", dv.tendonvi, "@tyle", dv.tyle, "@ghichu", dv.ghichu);
                //if ((!string.IsNullOrEmpty(msgError)) || (!string.IsNullOrEmpty(result.ToString()) && result != null))
                //    throw new Exception(msgError);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool delete_don_vi(int id)
        {
            string msgError = "";
            try
            {
                var result = _Helper.ExecuteScalarSProcedureWithTransaction(out msgError, "delete_don_vi", "@id_dv", id);
                //if ((!string.IsNullOrEmpty(msgError)) || (!string.IsNullOrEmpty(result.ToString()) && result != null))
                //    throw new Exception(msgError);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool edit_don_vi(int id, donvi dv)
        {
            string msgError = "";
            try
            {
                var result = _Helper.ExecuteScalarSProcedureWithTransaction(out msgError, "update_don_vi", "@madv", id, "@tendonvi",dv.tendonvi, "@tyle",dv.tyle, "@ghichu", dv.ghichu);
                //if ((!string.IsNullOrEmpty(msgError)) || (!string.IsNullOrEmpty(result.ToString()) && result != null))
                //    throw new Exception(msgError);
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<donvi> get_don_vi_all()
        {
            string msgError = "";
            try
            {
                var result = _Helper.ExecuteSProcedureReturnDataTable(out msgError, "get_all_don_vi");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return result.ConvertTo<donvi>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public donvi get_don_vi_by_id(int id)
        {
            string msgError = "";
            try
            {
                var result = _Helper.ExecuteSProcedureReturnDataTable(out msgError, "get_don_vi_by_id", "@id_dv", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return result.ConvertTo<donvi>().SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
