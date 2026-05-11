using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PearlPineproject.Model;
using PearlPineproject.DTOs;

namespace PearlPineproject.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class NotifyController : ControllerBase
    {
            private readonly AppDbContext _context;

            public NotifyController(AppDbContext context)
            {
                _context = context;
            }

            [HttpPost]
            public async Task<IActionResult> SaveNotification(notifyModel data)
            {
                await _context.Notifications.AddAsync(data);
                await _context.SaveChangesAsync();
                return Ok(new {message = "Notification Saved"});
            }
        }

    }

