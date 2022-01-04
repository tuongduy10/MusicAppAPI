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
        public async Task<IActionResult> getTheloaiList()
        {
            var listBaihat = context.Baihats.ToList();

            return Ok(new { status = "success", data = listBaihat });
        }

        [Route("getBaihatByName/{name}")]
        [HttpGet]
        public async Task<IActionResult> getBaihatByName(string name)
        {
            try
            {
                var result = from baihat in context.Baihats where baihat.Tenbaihat.Contains(name) select baihat;
                return Ok(new { status = "success", data = result.ToList() });
            }
            catch (Exception e)
            {
                return BadRequest(new { status = "fail", data = "Fail to get" });
            }
        }

        [Route("getBaihatByCasi/{id}")]
        [HttpGet]
        public async Task<IActionResult> getBaihatByCasi(int id)
        {
            try
            {
                var result = from baihat in context.Baihats
                             from chitiet in context.ChitietBaihats
                             where baihat.IdBaihat == chitiet.IdBaihat && chitiet.IdCasi == id
                             select baihat;

                return Ok(new { status = "success", data = result.ToList() });
            }
            catch (Exception e)
            {
                return BadRequest(new { status = "fail", data = "Fail to get" });
            }
        }

        [Route("addBaihatToPlaylist")]
        [HttpPost]
        public async Task<IActionResult> addBaihatToPlaylist([FromBody] ChitietPlayList chitiet)
        {
            try
            {
                ChitietPlayList chitietPlaylist = new ChitietPlayList();
                chitietPlaylist.IdPlayList = chitiet.IdBaihat;
                chitietPlaylist.IdBaihat = chitiet.IdBaihat;
                context.ChitietPlayLists.Add(chitietPlaylist);
                context.SaveChanges();

                return Ok(new { status = "success", data = "Add successfully" });
            }
            catch (Exception e)
            {
                return BadRequest(new { status = "fail", data = "Fail to add this song to your playlist"});
            }
        }
    }
}