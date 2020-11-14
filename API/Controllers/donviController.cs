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
    public class donviController : ControllerBase
    {
        private readonly IdonviBuss _Buss;
        public donviController(IdonviBuss buss)
        {
            _Buss = buss;
        }
        [Route("get_don_vi_all")]
        [HttpGet]
        public List<donvi> get_don_vi_all()
        {
            return _Buss.get_don_vi_all();
        }
        [Route("get_don_vi_by_id/{id}")]
        [HttpGet]
        public donvi get_don_vi_by_id(int id)
        {
            return _Buss.get_don_vi_by_id(id);
        }
        [Route("create_don_vi")]
        [HttpPost]
        public bool create_don_vi([FromBody] donvi dv)
        {
            return _Buss.create_don_vi(dv);
        }
        [Route("edit_don_vi/{id}")]
        [HttpPut]
        public bool edit_don_vi(int id, [FromBody] donvi dv)
        {
            return _Buss.edit_don_vi(id, dv);
        }
        [Route("delete_don_vi/{id}")]
        [HttpDelete]
        public bool delete_don_vi(int id)
        {
            return _Buss.delete_don_vi(id);
        }
    }
}
