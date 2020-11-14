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
    public class loainhiemvuController : ControllerBase
    {
        private readonly IloainhienvuBuss _Buss;
        public loainhiemvuController(IloainhienvuBuss buss)
        {
            _Buss = buss;
        }
        [Route("get_loai_nhiem_vu_all")]
        [HttpGet]
        public List<loainhiemvu> get_loai_nhiem_vu_all()
        {
            return _Buss.get_loai_nhiem_vu_all();
        }
        [Route("get_loai_nhiem_vu_by_id")]
        [HttpGet]
        public loainhiemvu get_loai_nhiem_vu_by_id(int id)
        {
            return _Buss.get_loai_nhiem_vu_by_id(id);
        }
        [Route("create_loai_nhiem_vu")]
        [HttpPost]
        public bool create_don_vi([FromBody] loainhiemvu lnv)
        {
            return _Buss.create_loai_nhiem_vu(lnv);
        }
        [Route("edit_loai_nhiem_vu")]
        [HttpPut]
        public bool edit_linh_vuc(int id, [FromBody] loainhiemvu lnv)
        {
            return _Buss.edit_loai_nhiem_vu(id, lnv);
        }
        [Route("delete_loai_nhiem_vu")]
        [HttpDelete]
        public bool delete_loai_nhiem_vu(int id)
        {
            return _Buss.delete_loai_nhiem_vu(id);
        }
    }
}
