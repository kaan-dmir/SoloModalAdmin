using Microsoft.AspNetCore.Mvc;
using SoloModalAdmin.Areas.Admin.Models;
using SoloModalAdmin.Areas.Admin.Models.Enum;

namespace SoloModalAdmin.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class SkillController : Controller
    {
        public IActionResult Index()
        {
            // Sayfanın modal davranışını yönetmek için enum olan PageType.Skill değerini ve gerekli sayfa bilgilerini set ediyorum.
            var page = new PageContent()
            {
                PageType = PageType.Skill,
                Title = "New Create Skill",
                HasOpenModal = true
            };
            return View(page);
        }
    }
}
