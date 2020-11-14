using DAL.Helper;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class tintucRespo : ItintucRespo
    {
        private readonly IDatabaseHelper _Helper;
        public tintucRespo(IDatabaseHelper helper)
        {
            _Helper = helper;
        }
        public bool create_tin_tuc(tintuc tt)
        {
            string msgError = "";
            try
            {
                var result = _Helper.ExecuteScalarSProcedureWithTransaction(out msgError, "create_tin_tuc", "@ten_lnv", tt.tieude, "@tomtat", tt.tomtat, "@hinhanh", tt.hinhanh, "@maloaitt", tt.maloaitt, "@noidung", tt.noidung);
                if ((!string.IsNullOrEmpty(msgError)) || (!string.IsNullOrEmpty(result.ToString()) && result != null))
                    throw new Exception(msgError);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool delete_tin_tuc(int id)
        {
            string msgError = "";
            try
            {
                var result = _Helper.ExecuteScalarSProcedureWithTransaction(out msgError, "delete_tin_tuc", "@matt", id);
                if ((!string.IsNullOrEmpty(msgError)) || (!string.IsNullOrEmpty(result.ToString()) && result != null))
                    throw new Exception(msgError);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool edit_tin_tuc(int id, tintuc tt)
        {
            string msgError = "";
            try
            {
                var result = _Helper.ExecuteScalarSProcedureWithTransaction(out msgError, "update_tin_tuc", "@matt", tt.matt, "@ten_lnv", tt.tieude, "@tomtat", tt.tomtat, "@hinhanh", tt.hinhanh, "@maloaitt", tt.maloaitt, "@noidung", tt.noidung);
                if ((!string.IsNullOrEmpty(msgError)) || (!string.IsNullOrEmpty(result.ToString()) && result != null))
                    throw new Exception(msgError);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<tintuc> get_tin_tuc_all(int pageSize, int pageIndex, string search)
        {
            string msgError = "";
            try
            {
                var result = _Helper.ExecuteSProcedureReturnDataTable(out msgError, "get_tin_tuc_page_index", "@page_index", pageIndex, "@page_size", pageSize, "@search",search);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return result.ConvertTo<tintuc>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public tintuc get_tin_tuc_by_id(int id)
        {
            string msgError = "";
            try
            {
                var result = _Helper.ExecuteSProcedureReturnDataTable(out msgError, "get_tin_tuc_by_ma_tin_tuc", "@matt", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return result.ConvertTo<tintuc>().SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
