using DAL.Helper;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class loainhiemvuRespo : IloainhiemvuRespo
    {
        private readonly IDatabaseHelper _Helper;
        public loainhiemvuRespo(IDatabaseHelper helper)
        {
            _Helper = helper;
        }
        public bool create_loai_nhiem_vu(loainhiemvu lnv)
        {
            string msgError = "";
            try
            {
                var result = _Helper.ExecuteScalarSProcedureWithTransaction(out msgError, "create_loai_nhiem_vu", "@ten_lnv", lnv.tenloainhiemvu);
                if ((!string.IsNullOrEmpty(msgError)) || (!string.IsNullOrEmpty(result.ToString()) && result != null))
                    throw new Exception(msgError);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool delete_loai_nhiem_vu(int id)
        {
            string msgError = "";
            try
            {
                var result = _Helper.ExecuteScalarSProcedureWithTransaction(out msgError, "delete_loai_nhiem_vu", "@id_lnv ", id);
                if ((!string.IsNullOrEmpty(msgError)) || (!string.IsNullOrEmpty(result.ToString()) && result != null))
                    throw new Exception(msgError);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool edit_loai_nhiem_vu(int id, loainhiemvu lnv)
        {
            string msgError = "";
            try
            {
                var result = _Helper.ExecuteScalarSProcedureWithTransaction(out msgError, "update_loai_nhiem_vu", "@id_lnv ", id, "@ten_lnv ",lnv.tenloainhiemvu);
                if ((!string.IsNullOrEmpty(msgError)) || (!string.IsNullOrEmpty(result.ToString()) && result != null))
                    throw new Exception(msgError);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<loainhiemvu> get_loai_nhiem_vu_all()
        {
            string msgError = "";
            try
            {
                var result = _Helper.ExecuteSProcedureReturnDataTable(out msgError, "get_all_loai_nhiem_vu");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return result.ConvertTo<loainhiemvu>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public loainhiemvu get_loai_nhiem_vu_by_id(int id)
        {
            string msgError = "";
            try
            {
                var result = _Helper.ExecuteSProcedureReturnDataTable(out msgError, "get_loai_nhiem_vu_by_id", "@id_lnv", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return result.ConvertTo<loainhiemvu>().SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
