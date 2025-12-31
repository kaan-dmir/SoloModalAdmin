using Microsoft.AspNetCore.Mvc;
using SoloModalAdmin.Areas.Admin.Models;
using SoloModalAdmin.Areas.Admin.Models.Enum;

namespace SoloModalAdmin.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            // Modal’ın hangi içeriği açacağını belirlemek için enum yapısındaki PageType.Product değerini ve modal için gerekli diğer bilgileri set ediyorum.
            var page = new PageContent()
            {
                PageType = PageType.Product,
                Title = "New Create Product",
                HasOpenModal = true
            };
            return View(page);
        }
    }
}
