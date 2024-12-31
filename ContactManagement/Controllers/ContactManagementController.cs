using Microsoft.AspNetCore.Mvc;

namespace ContactManagement.Controllers
{
    public class ContactManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
