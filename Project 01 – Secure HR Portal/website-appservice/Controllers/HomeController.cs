using Microsoft.AspNetCore.Mvc;

namespace HRPortalApp.Controllers
{
    public class HomeController : Controller
    {
        private string storageAccount = "hrportalstrg";
        private string container = "hr-documents";

        // SAS token placeholder
        private string sasToken = "sp=r&st=2026-07-06T18:13:21Z&se=2026-07-07T02:28:21Z&spr=https&sv=2026-02-06&sr=c&sig=Eep0AUwVXHcVr3SZZt9jMiyhKOuAsnXpdWwjwGFnV9s%3D";

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DownloadFile(string fileName)
        {
            string url =
                $"https://{storageAccount}.blob.core.windows.net/{container}/{fileName}?{sasToken}";

            return Redirect(url);
        }
    }
}
