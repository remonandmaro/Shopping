using ERPSystem.Models;
using ERPSystem.Tools;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;

namespace ERPSystem.Controllers
{
    public class BaseController : Controller
    {
        private readonly MyDBContext db;

        public BaseController(MyDBContext db)
        {
            this.db = db;
            var Name = "Remon";
            General ? G = db.Generals.FirstOrDefault();
            if (G != null)
            {
                MainData.MainTitle = G.MainTitle;
                MainData.Address = G.Address;
                MainData.Mobile = G.Mobile;
                MainData.StoreName = G.StoreName;
                MainData.Mail = G.Mail;
                MainData.DesignBy = G.DesignBy;
            }
        }
    }
}
