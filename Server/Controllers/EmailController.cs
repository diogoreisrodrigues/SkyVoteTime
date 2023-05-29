using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;
using SkyVoteTime.Server.Models;
using SkyVoteTime.Server.Service;
using System.Net;
using System.Net.Mail;

namespace SkyVoteTime.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        public IActionResult SendEmail([FromBody]Email request) 
        {
            _emailService.SendEmail(request);
            return Ok();
        }
    }
}
