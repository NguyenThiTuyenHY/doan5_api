using DAL.Helper;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class loaitintucRespo : IloaitintucRespo
    {
        private readonly IDatabaseHelper _Helper;
        public loaitintucRespo(IDatabaseHelper helper)
        {
            _Helper = helper;
        }
        public bool create_loai_tin_tuc(loaitintuc ltt)
        {
            string msgError = "";
            try
            {
                var result = _Helper.ExecuteScalarSProcedureWithTransaction(out msgError, "create_loai_tintuc", "@tenloaitt", ltt.tenloaitt);
                //if ((!string.IsNullOrEmpty(msgError)) || (!string.IsNullOrEmpty(result.ToString()) && result != null))
                //    throw new Exception(msgError);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool delete_loai_tin_tuc(int id)
        {
            string msgError = "";
            try
            {
                var result = _Helper.ExecuteScalarSProcedureWithTransaction(out msgError, "delete_loai_tin_tuc", "@maloaitt", id);
                //if ((!string.IsNullOrEmpty(msgError)) || (!string.IsNullOrEmpty(result.ToString()) && result != null))
                //    throw new Exception(msgError);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool edit_loai_tin_tuc(int id, loaitintuc ltt)
        {
            string msgError = "";
            try
            {
                var result = _Helper.ExecuteScalarSProcedureWithTransaction(out msgError, "update_loai_tin_tuc", "@maloaitt", id, "@tenloaitt", ltt.tenloaitt);
                //if ((!string.IsNullOrEmpty(msgError)) || (!string.IsNullOrEmpty(result.ToString()) && result != null))
                //    throw new Exception(msgError);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<loaitintuc> get_loai_tin_tuc_all()
        {
            string msgError = "";
            try
            {
                var result = _Helper.ExecuteSProcedureReturnDataTable(out msgError, "get_all_loai_tin_tuc");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return result.ConvertTo<loaitintuc>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public loaitintuc get_loai_tin_tuc_by_id(int id)
        {
            string msgError = "";
            try
            {
                var result = _Helper.ExecuteSProcedureReturnDataTable(out msgError, "get_loai_tin_tuc_by_ma_loai_tin_tuc", "@maloaitt", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return result.ConvertTo<loaitintuc>().SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
