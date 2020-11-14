using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class nhanvienController : ControllerBase
    {
        private readonly InhanvienBuss _Buss;
        public nhanvienController(InhanvienBuss buss)
        {
            _Buss = buss;
        }
        [Route("get_nhan_vien_all")]
        [HttpGet]
        public List<nhanvien> get_don_vi_all()
        {
            return _Buss.get_nhan_vien_all();
        }
        [Route("get_nhan_vien_by_id")]
        [HttpGet]
        public nhanvien get_nhan_vien_by_id(string id)
        {
            return _Buss.get_nhan_vien_by_id(id);
        }
        [Route("create_nhan_vien")]
        [HttpPost]
        public bool create_nhan_vien([FromBody] nhanvien nv)
        {
            return _Buss.create_nhan_vien(nv);
        }
        [Route("edit_nhan_vien")]
        [HttpPut]
        public bool edit_nhan_vien(string id, [FromBody] nhanvien nv)
        {
            return _Buss.edit_nhan_vien(id, nv);
        }
        [Route("delete_nhan_vien")]
        [HttpDelete]
        public bool delete_nhan_vien(string id)
        {
            return _Buss.delete_nhan_vien(id);
        }
    }
}
