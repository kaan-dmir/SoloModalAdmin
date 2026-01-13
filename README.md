SoloModalAdmin – Dinamik Tek Modal Yaklaşımı

Bu proje, **ASP.NET Core MVC** ile geliştirilen admin panelleri için **tek modal (single modal)** yaklaşımını örneklemektedir.

Her sayfa (**Product**, **Skill** vb.) için ayrı ayrı modal oluşturmak yerine, uygulama genelinde **tek bir modal** kullanılır.

Modal içeriği, sayfa yenilenmeden **JavaScript (fetch)** aracılığıyla backend’den alınır ve **ViewComponent** üzerinden **dinamik** olarak render edilir.

Hangi içeriğin yükleneceği, **`PageType` enum** yapısı ile belirlenir.  
Bu sayede **aynı modal**, farklı sayfalarda **farklı form ve içerikleri** gösterebilir.

## Bu yaklaşım:
- **Kod tekrarını azaltır**
- **Admin panel** yapısını sadeleştirir
- **Yeni sayfaların** kolayca eklenmesini sağlar

