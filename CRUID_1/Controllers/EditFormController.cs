using Microsoft.AspNetCore.Mvc;
using CRUID_1.Models;

namespace CRUID_1.Controllers
{
    public class EditFormController : Controller
    {
        public IActionResult Index()
        {

            OrderModel model = new OrderModel()
            {

            };

            return View(model);
        }
    }
}
