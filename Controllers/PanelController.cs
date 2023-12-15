using BLL;
using BusinessEntity;
using Kavenegar;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmsPanel.Models;
using SmsPanel.Models.Dto;
using SmsPanel.Services;
using System.Text;

namespace SmsPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SMSController : ControllerBase
    {
        DatabaseContext _db;
        public SMSController(DatabaseContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult GetInvoice(string code)
        {
            StoreService service = new StoreService();
            StoreDto data = service.GetData(code);
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }
    }
}
