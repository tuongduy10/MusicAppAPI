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
        public IActionResult login([FromBody]Taikhoan taikhoan)
        {
            try
            {
                var result = context.Taikhoans.FirstOrDefault(rs => rs.IdTaikhoan == taikhoan.IdTaikhoan && rs.Matkhau == taikhoan.Matkhau);
                if (result != null)
                {
                    HttpContext.Session.SetString("IdTaikhoan", taikhoan.IdTaikhoan);
                    return Ok(new { status = true, data = "Login successfully" });
                }
                return NotFound(new { status = false, data = "Login unsuccessfully" });
            }
            catch (Exception e)
            {
                return BadRequest(new { status = false, data = e.ToString() });
            }
        }

        [Route("register")]
        [HttpPost]
        public IActionResult register([FromBody] Taikhoan taikhoan)
        {
            try
            {
                var findUser = context.Taikhoans.FirstOrDefault(tk => tk.IdTaikhoan == taikhoan.IdTaikhoan);
                if (findUser != null)
                {
                    return BadRequest(new { status = false, data = "Username is already exist" });
                }
                Taikhoan newUser = new Taikhoan();
                newUser.IdTaikhoan = taikhoan.IdTaikhoan;
                newUser.Matkhau = taikhoan.Matkhau;
                newUser.Tennguoidung = taikhoan.Tennguoidung;

                context.Taikhoans.Add(newUser);
                context.SaveChanges();

                return Ok(new { status = true, data = "Register successfully" });
            }
            catch (Exception e)
            {
                return BadRequest( new { status= false, data = e.ToString()} );
            }       
        }
    }
}
