using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Model;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class linhvucController : ControllerBase
    {
        private readonly IlinhvucBuss _Buss;
        public linhvucController(IlinhvucBuss buss)
        {
            _Buss = buss;
        }
        [Route("get_linh_vuc_all")]
        [HttpGet]
        public List<linhvuc> get_linh_vuc_all()
        {
            return _Buss.get_linh_vuc_all();
        }
        [Route("get_linh_vuc_by_id")]
        [HttpGet]
        public linhvuc get_linh_vuc_by_id(int id)
        {
            return _Buss.get_linh_vuc_by_id(id);
        }
        [Route("create_linh_vuc")]
        [HttpPost]
        public bool create_linh_vuc([FromBody] linhvuc lv)
        {
            return _Buss.create_linh_vuc(lv);
        }
        [Route("edit_linh_vuc")]
        [HttpPut]
        public bool edit_linh_vuc(int id,[FromBody] linhvuc lv)
        {
            return _Buss.edit_linh_vuc(id, lv);
        }
        [Route("delete_linh_vuc")]
        [HttpDelete]
        public bool delete_linh_vuc(int id)
        {
            return _Buss.delete_linh_vuc(id);
        }
    }
}
