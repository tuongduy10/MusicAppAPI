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
    public class PlaylistController : ControllerBase
    {
        MusicAppContext context = new MusicAppContext();

        [Route("getPlaylist")]
        [HttpGet]
        public async Task<IActionResult> getPlaylist()
        {
            try
            {
                var playlist = context.PlayLists.ToList();

                return Ok(new { status = true, data = playlist });
            }
            catch (Exception e)
            {
                return BadRequest(new { status = false, data = e.ToString() });
            }
        }

        [Route("getPlaylistById/{id}")]
        [HttpGet]
        public async Task<IActionResult> getPlaylist(int id)
        {
            try
            {
                var playlist = context.PlayLists.FirstOrDefault(pl => pl.IdPlayList == id);

                return Ok(new { status = true, data = playlist });
            }
            catch (Exception e)
            {
                return BadRequest(new { status = false, data = e.ToString() });
            }
        }

        [Route("addNewPlayList/{name}")]
        [HttpPost]
        public async Task<IActionResult> addNewPlayList(string name)
        {
            try
            {
                string id = HttpContext.Session.GetString("IdTaikhoan");

                PlayList newPlayList = new PlayList();
                newPlayList.TenPlayList = name;
                newPlayList.Idtaikhoan = id;

                context.PlayLists.Add(newPlayList);
                context.SaveChanges();

                return Ok(new { status = true, data = "Add new Playlist successfully" });
            }
            catch (Exception e)
            {
                return BadRequest(new { status = false, data = e.ToString() });
            }
        }        
    }
}
