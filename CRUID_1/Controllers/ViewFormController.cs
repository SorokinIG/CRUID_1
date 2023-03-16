using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using CRUID_1.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUID_1.Controllers
{
    public class ViewFormController : Controller
    {
        private readonly ApplicationContext db;

        public List<SelectListItem> ProviderListDate;
        public ViewFormController(ApplicationContext context)
        {
            db = context;

            var ProviderList = db.Provider.ToList();
            ProviderListDate = new List<SelectListItem>();
            foreach (var item in ProviderList)
            {
                ProviderListDate.Add(new SelectListItem
                {
                    Text = item.Name,
                    Value = item.Id.ToString()
                }
                );
            }
        }

        public async Task<IActionResult> Index(int? Id)
        {
            if(Id == null)
            {
                return NotFound();
            }
            var orderItem = await db.OrderItem.FirstOrDefaultAsync(d => d.OrderId == Id);

            if(orderItem == null)
            {
                return NotFound();
            }
            return View(orderItem);
        }
    }
}
