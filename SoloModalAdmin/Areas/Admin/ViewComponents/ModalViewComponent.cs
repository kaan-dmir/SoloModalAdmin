using Microsoft.AspNetCore.Mvc;
using SoloModalAdmin.Areas.Admin.Models.Enum;

namespace SoloModalAdmin.Areas.Admin.ViewComponents
{
    public class ModalViewComponent : ViewComponent
    {
        private static readonly Dictionary<PageType, string> PageTypeToPartialMap = new()
        {
            {PageType.Skill, "_SkillModal" },
            { PageType.Product, "_ProductModal" }
        };
        public IViewComponentResult Invoke(PageType page)
        {
            if(!PageTypeToPartialMap.TryGetValue(page, out var pageName))
            {
                pageName = "_DefaultModal";
            }
            return View(pageName);

        }
    }
}
