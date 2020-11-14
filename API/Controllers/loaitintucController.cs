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
    public class loaitintucController : ControllerBase
    {
        private readonly IloaitintucBuss _Buss;
        public loaitintucController(IloaitintucBuss buss)
        {
            _Buss = buss;
        }
        [Route("get_loai_tin_tuc_all")]
        [HttpGet]
        public List<loaitintuc> get_loai_tin_tuc_all()
        {
            return _Buss.get_loai_tin_tuc_all();
        }
        [Route("get_loai_tin_tuc_by_id/{id}")]
        [HttpGet]
        public loaitintuc get_loai_tin_tuc_by_id(int id)
        {
            return _Buss.get_loai_tin_tuc_by_id(id);
        }
        [Route("create_loai_tin_tuc")]
        [HttpPost]
        public bool create_loai_tin_tuc([FromBody] loaitintuc ltt)
        {
            return _Buss.create_loai_tin_tuc(ltt);
        }
        [Route("edit_loai_tin_tuc/{id}")]
        [HttpPut]
        public bool edit_loai_tin_tuc(int id, [FromBody] loaitintuc ltt)
        {
            return _Buss.edit_loai_tin_tuc(id, ltt);
        }
        [Route("delete_loai_tin_tuc/{id}")]
        [HttpDelete]
        public bool delete_loai_tin_tuc(int id)
        {
            return _Buss.delete_loai_tin_tuc(id);
        }
    }
}
