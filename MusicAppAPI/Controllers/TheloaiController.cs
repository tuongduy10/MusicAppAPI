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
    public class TheloaiController : ControllerBase
    {
        MusicAppContext context = new MusicAppContext();

        [Route("getTheloaiList")]
        [HttpGet]
        public IActionResult getTheloaiList()
        {
            var listTheloai = context.Theloais.ToList();

            return Ok(new { status = true, data = listTheloai });
        }

        [Route("getTheloaiById/{id}")]
        [HttpGet]
        public IActionResult getTheloaiById(int id)
        {
            var theloai = context.Theloais.SingleOrDefault(tl => tl.IdTheloai == id);

            return Ok(new { status = true, data = theloai });
        }


        //[Route("addNewTheloai/{name}")]
        //[HttpPost]
        //public IActionResult addNewTheloai(string name)
        //{
        //    context = new MusicAppContext();

        //    Theloai theloai = new Theloai();

        //    theloai.TenTheloai = name;

        //    context.Theloais.Add(theloai);
        //    context.SaveChanges();

        //    return Ok();
        //}
    }
}