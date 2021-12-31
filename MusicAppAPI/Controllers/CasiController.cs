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
    public class CasiController : ControllerBase
    {
        MusicAppContext context = new MusicAppContext();

        [Route("getCasiList")]
        [HttpGet]
        public IActionResult getCasiList()
        {
            var listcasi = context.Casis.ToList();

            return Ok(new { status = true, data = listcasi });
        }

        [Route("getCasiById/{id}")]
        [HttpGet]
        public IActionResult getCasiList(int id)
        {
            var casi = context.Casis.FirstOrDefault(cs => cs.IdCasi == id);

            return Ok(new { status = true, data = casi });
        }

    }
}
