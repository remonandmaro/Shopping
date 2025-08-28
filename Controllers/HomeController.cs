using System.Diagnostics;
using ERPSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ERPSystem.Controllers
{
    public class HomeController : BaseController
    {
        private readonly MyDBContext db;

        public HomeController(MyDBContext db):base(db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
