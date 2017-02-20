using Microsoft.AspNet.Mvc;
namespace prac2WebAPI.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
