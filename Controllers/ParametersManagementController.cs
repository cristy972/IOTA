using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;

namespace IOTA.Controllers
{
    public class ParametersManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}