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
    public class chucvuController : ControllerBase
    {
        private readonly IchucvuBuss _Buss;
        public chucvuController(IchucvuBuss buss)
        {
            _Buss = buss;
        }
        [Route("get_chuc_vu_all")]
        [HttpGet]
        public List<chucvu> get_chuc_vu_all()
        {
            return _Buss.get_chuc_vu_all();
        }
        [Route("get_chuc_vu_by_id")]
        [HttpGet]
        public chucvu get_chuc_vu_by_id(int id)
        {
            return _Buss.get_chuc_vu_by_id(id);
        }
        [Route("create_chuc_vu")]
        [HttpPost]
        public bool create_don_vi([FromBody] chucvu cv)
        {
            return _Buss.create_chuc_vu(cv);
        }
        [Route("edit_chuc_vu")]
        [HttpPut]
        public bool edit_chuc_vu(int id, [FromBody] chucvu cv)
        {
            return _Buss.edit_chuc_vu(id, cv);
        }
        [Route("delete_chuc_vu")]
        [HttpDelete]
        public bool delete_chuc_vu(int id)
        {
            return _Buss.delete_chuc_vu(id);
        }
    }
}
