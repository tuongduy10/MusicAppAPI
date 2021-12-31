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
        public IActionResult getPlaylist()
        {
            var playlist = context.PlayLists.ToList();

            return Ok(new { status = true, data = playlist });
        }

        [Route("getPlaylistById/{id}")]
        [HttpGet]
        public IActionResult getPlaylist(int id)
        {
            //
            var playlist = context.PlayLists.FirstOrDefault(pl => pl.IdPlayList == id);

            return Ok(new { status = true, data = playlist }); 
        }
        
    }
}
