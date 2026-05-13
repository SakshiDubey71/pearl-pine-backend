/* using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using PearlPineproject.Model;
using PearlPineproject.Service;
using PearlPineproject.DTOs;

namespace PearlPineproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;
        public UserController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("Signup")]
        public async Task<IActionResult> AddUser(UserModel userVar)
        {
            await _context.Users.AddAsync(userVar);
            await _context.SaveChangesAsync();
            return Ok(new { message = "User Created" });
        }

        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginDto dto)
        {
            var user = _context.Users
                .FirstOrDefault(x => x.Email == dto.Email && x.Password == dto.Password);

            if (user == null)
                return Unauthorized(new { message = "Invalid email or password" });

            return Ok(new { message = "Login Success", user });
        }



        static Dictionary<string, string> otpStorage = new();

        [HttpPost("SendOtp")]
        public IActionResult SendOtp([FromBody] EmailDto dto)
        {
            if (string.IsNullOrEmpty(dto.Email))
                return BadRequest(new { message = "Email required" });

            string otp = new Random().Next(100000, 999999).ToString();

            otpStorage[dto.Email] = otp;

            EmailService service = new EmailService();
            service.SendOtpEmail(dto.Email, otp);

            return Ok(new { message = "OTP sent to email" });
        }



        [HttpPost("VerifyOtp")]
        public IActionResult VerifyOtp([FromBody] VerifyOtpDto dto)
        {
            if (otpStorage.ContainsKey(dto.Email) && otpStorage[dto.Email] == dto.Otp)
            {
                otpStorage.Remove(dto.Email);
                return Ok(new { message = "OTP Verified" });
            }

            return BadRequest(new { message = "Invalid OTP" });
        }

    }
}
*/