using SoloModalAdmin.Areas.Admin.Models.Enum;

namespace SoloModalAdmin.Areas.Admin.Models
{
    public class PageContent
    {
        public PageType PageType { get; set; }
        public string Title { get; set; }
        public bool HasOpenModal { get; set; }
    }
}
