using DAL.Helper;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class nhanvienRespo : InhanvienRespo
    {
        private readonly IDatabaseHelper _Helper;
        public nhanvienRespo(IDatabaseHelper helper)
        {
            _Helper = helper;
        }
        public bool create_nhan_vien(nhanvien nv)
        {
            string msgError = "";
            nv.manv = Guid.NewGuid().ToString();
            try
            {
                var result = _Helper.ExecuteScalarSProcedureWithTransaction(out msgError, "create_nhan_vien", "@manv", nv.manv, "@hoten", nv.hoten, "@bidanh", nv.bidanh, "@hinhanh", nv.hinhanh, "@gioitinh", nv.gioitinh, "@ngaysinh", nv.ngaysinh, "@noisinh", nv.noisinh, "@cmnd", nv.cmnd, "@ncapcmnd", nv.ncapcmnd, "@noicapcmnd", nv.noicapcmnd, "@dantoc", nv.dantoc, "@tongiao", nv.tongiao, "@quoctich", nv.quoctich, "@tthonnhan", nv.tthonnhan, "@quenquan", nv.quenquan, "@dc_ttru", nv.dc_ttru, "@noiohnay", nv.noiohnay, "@dienthoaidd", nv.dienthoaidd, "@email", nv.email, "@donvi", nv.donvi, "@chucvu", nv.chucvu, "@tdhocvan", nv.tdhocvan, "@datotnghiep", nv.datotnghiep, "@tdcaonhat", nv.tdcaonhat, "@ngdaotao", nv.ngdaotao, "@cngdaotao", nv.cngdaotao, "@noidaotao", nv.noidaotao, "@htdaotao", nv.htdaotao, "@mantn", nv.mantn, "@td_nn", nv.td_nn, "@td_tinhoc", nv.td_tinhoc, "@status", nv.status);
                if (!string.IsNullOrEmpty(msgError) || ((!string.IsNullOrEmpty(result.ToString()) && result != null)))
                    throw new Exception(msgError);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool delete_nhan_vien(string id)
        {
            string msgError = "";
            try
            {
                var result = _Helper.ExecuteScalarSProcedureWithTransaction(out msgError, "delete_nhan_vien", "@manv", id);
                if (!string.IsNullOrEmpty(msgError) || ((!string.IsNullOrEmpty(result.ToString()) && result != null)))
                    throw new Exception(msgError);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<nhanvien> get_nhan_vien_all()
        {
            string msgError = "";
            try
            {
                var result = _Helper.ExecuteSProcedureReturnDataTable(out msgError, "get_nhan_vien");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return result.ConvertTo<nhanvien>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public nhanvien get_nhan_vien_by_id(string id)
        {
            string msgError = "";
            try
            {
                var result = _Helper.ExecuteSProcedureReturnDataTable(out msgError, "get_nhan_vien_by_id", "@manv", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return result.ConvertTo<nhanvien>().SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool edit_nhan_vien(string id, nhanvien nv)
        {
            string msgError = "";
            try
            {
                var result = _Helper.ExecuteScalarSProcedureWithTransaction(out msgError, "update_nhan_vien", "@manv", id, "@hoten", nv.hoten, "@bidanh", nv.bidanh, "@hinhanh", nv.hinhanh, "@gioitinh", nv.gioitinh, "@ngaysinh", nv.ngaysinh, "@noisinh", nv.noisinh, "@cmnd", nv.cmnd, "@ncapcmnd", nv.ncapcmnd, "@noicapcmnd", nv.noicapcmnd, "@dantoc", nv.dantoc, "@tongiao", nv.tongiao, "@quoctich", nv.quoctich, "@tthonnhan", nv.tthonnhan, "@quenquan", nv.quenquan, "@dc_ttru", nv.dc_ttru, "@noiohnay", nv.noiohnay, "@dienthoaidd", nv.dienthoaidd, "@email", nv.email, "@donvi", nv.donvi, "@chucvu", nv.chucvu, "@tdhocvan", nv.tdhocvan, "@datotnghiep", nv.datotnghiep, "@tdcaonhat", nv.tdcaonhat, "@ngdaotao", nv.ngdaotao, "@cngdaotao", nv.cngdaotao, "@noidaotao", nv.noidaotao, "@htdaotao", nv.htdaotao, "@mantn", nv.mantn, "@td_nn", nv.td_nn, "@td_tinhoc", nv.td_tinhoc, "@status", nv.status);
                if (!string.IsNullOrEmpty(msgError) || ((!string.IsNullOrEmpty(result.ToString()) && result != null)))
                    throw new Exception(msgError);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
