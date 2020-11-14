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
    public class nhiemvuController : ControllerBase
    {
        private readonly InhiemvuBuss _Buss;
        public nhiemvuController(InhiemvuBuss buss)
        {
            _Buss = buss;
        }
        [Route("get_nhiem_vu_all")]
        [HttpGet]
        public List<nhiemvu> get_linh_vuc_all()
        {
            return _Buss.get_nhiem_vu_all();
        }
        [Route("get_v_by_id")]
        [HttpGet]
        public nhiemvu get_linh_vuc_by_id(int id)
        {
            return _Buss.get_nhiem_vu_by_id(id);
        }
        [Route("create_nhiem_vu")]
        [HttpPost]
        public bool create_linh_vuc([FromBody] nhiemvu nv)
        {
            return _Buss.create_nhiem_vu(nv);
        }
        [Route("edit_nhiem_vu")]
        [HttpPut]
        public bool edit_linh_vuc(int id, [FromBody] nhiemvu nv)
        {
            return _Buss.edit_nhiem_vu(id, nv);
        }
        [Route("delete_nhiem_vu")]
        [HttpDelete]
        public bool delete_nhiem_vu(int id)
        {
            return _Buss.delete_nhiem_vu(id);
        }
    }
}
