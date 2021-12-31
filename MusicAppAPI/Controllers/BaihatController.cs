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

        [Route("getBaihatByName/{name}")]
        [HttpGet]
        public IActionResult getTheloaiList(string name)
        {
            var result = from baihat in context.Baihats where baihat.Tenbaihat.Contains(name) select baihat;
            return Ok(new { status = true, data = result.ToList() });
        }
    }
}