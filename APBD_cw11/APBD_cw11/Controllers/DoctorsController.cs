using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APBD_cw11.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APBD_cw11.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly ClinicDbContext _context;
        public DoctorsController(ClinicDbContext context)
        {
            _context = context;
        }
        public IActionResult GetDoctors()
        {
            return Ok();
        }
    }
}