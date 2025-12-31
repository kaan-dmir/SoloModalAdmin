using Microsoft.AspNetCore.Mvc;
using SoloModalAdmin.Areas.Admin.Models.Enum;

namespace SoloModalAdmin.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OpenModalController : Controller
    {
        public IActionResult Open(PageType page)
        {
            // Modal içeriğini dinamik hale getirmek için page parametresini ViewComponent’e yönlendiriyorum.
            return ViewComponent("Modal", new { page });
        }
    }
}
