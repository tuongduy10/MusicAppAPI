using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicAppAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BaihatController : ControllerBase
    {
        MusicAppContext context = new MusicAppContext();

        [Route("getBaihatList")]
        [HttpGet]
        public IActionResult getTheloaiList()
        {
            var listBaihat = context.Baihats.ToList();

            return Ok(new { status = true, data = listBaihat });
        }

        [Route("getBaihatById/{id}")]
        [HttpGet]
        public IActionResult getTheloaiList(int id)
        {
            var baihat = context.Baihats.FirstOrDefault(bh => bh.IdBaihat == id);

            return Ok(new { status = true, data = baihat });
        }
    }
}