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
    public class tintucController : ControllerBase
    {
        private readonly ItintucBuss _Buss;
        public tintucController(ItintucBuss buss)
        {
            _Buss = buss;
        }
        [Route("get_tin_tuc_all")]
        [HttpGet]
        public List<tintuc> get_tin_tuc_all()
        {
            return null;
        }
        [Route("get__tin_tuc_by_id")]
        [HttpGet]
        public tintuc get_tin_tuc_by_id(int id)
        {
            return _Buss.get_tin_tuc_by_id(id);
        }
        [Route("create_linh_vuc")]
        [HttpPost]
        public bool create__tin_tuc([FromBody] tintuc tt)
        {
            return _Buss.create_tin_tuc(tt);
        }
        [Route("edit_tin_tuc")]
        [HttpPut]
        public bool edit_tin_tuc(int id, [FromBody] tintuc tt)
        {
            return _Buss.edit_tin_tuc(id, tt);
        }
        [Route("delete_tin_tuc")]
        [HttpDelete]
        public bool delete_tin_tuc(int id)
        {
            return _Buss.delete_tin_tuc(id);
        }
    }
}
