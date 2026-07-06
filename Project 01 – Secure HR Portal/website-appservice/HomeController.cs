using Microsoft.AspNetCore.Mvc;

namespace HRPortalApp.Controllers
{
    public class HomeController : Controller
    {
        private string storageAccount = "<your-storage-account>";
        private string container = "hr-documents";

        // SAS token placeholder
        private string sasToken = "<your-sas-token>";

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