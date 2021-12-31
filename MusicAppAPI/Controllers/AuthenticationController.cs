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
    public class AuthenticationController : ControllerBase
    {
        MusicAppContext context = new MusicAppContext();

        [Route("login")]
        [HttpGet]
        public IActionResult login([FromBody] Taikhoan taikhoan)
        {
            var result = context.Taikhoans.FirstOrDefault(rs => rs.IdTaikhoan == taikhoan.IdTaikhoan && rs.Matkhau == taikhoan.Matkhau);
            if (result != null)
            {
                return Ok(new { status = true, data = "Login successfully" });
            }

            return NotFound(new { status = false, data = "Login unsuccessfully" });
        }

        [Route("register")]
        [HttpPost]
        public IActionResult register([FromBody] Taikhoan taikhoan)
        {
            //var result = context.Taikhoans.FirstOrDefault(rs => rs.IdTaikhoan == taikhoan.IdTaikhoan && rs.Matkhau == taikhoan.Matkhau);
            //if (result != null)
            //{
            //    return Ok(new { status = true, data = "Login successfully" });
            //}

            //return NotFound(new { status = false, data = "Login unsuccessfully" });
            return Ok();
        }
    }
}
