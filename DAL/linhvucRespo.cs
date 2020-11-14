using DAL.Helper;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class linhvucRespo : IlinhvucRespo
    {
        private readonly IDatabaseHelper _Helper;
        public linhvucRespo(IDatabaseHelper helper)
        {
            _Helper = helper;
        }
        public bool create_linh_vuc(linhvuc lv)
        {
            string msgError = "";
            try
            {
                var result = _Helper.ExecuteScalarSProcedureWithTransaction(out msgError, "create_linh_vuc", "@ten_lv", lv.tenlinhvuc);
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || (!string.IsNullOrEmpty(msgError))){
                    throw new Exception(msgError);
                }
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool delete_linh_vuc(int id)
        {
            string msgError = "";
            try
            {
                var result = _Helper.ExecuteScalarSProcedureWithTransaction(out msgError, "delete_linh_vuc", "@id", id);
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || (!string.IsNullOrEmpty(msgError))){
                    throw new Exception(msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool edit_linh_vuc(int id, linhvuc lv)
        {
            string msgError = "";
            try
            {
                var result = _Helper.ExecuteScalarSProcedureWithTransaction(out msgError, "update_linh_vuc", "@id", id, "@ten_lv ",lv.tenlinhvuc);
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || (!string.IsNullOrEmpty(msgError)))
                {
                    throw new Exception(msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<linhvuc> get_linh_vuc_all()
        {
            string msgError = "";
            try
            {
                var result = _Helper.ExecuteSProcedureReturnDataTable(out msgError, "get_all_linh_vuc");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return result.ConvertTo<linhvuc>().ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public linhvuc get_linh_vuc_by_id(int id)
        {
            string msgError = "";
            try
            {
                var result = _Helper.ExecuteSProcedureReturnDataTable(out msgError, "get_linh_vuc_by_id", "@id_linhvuc", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return result.ConvertTo<linhvuc>().SingleOrDefault();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
