using CRUID_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

using System.Diagnostics;

namespace CRUID_1.Controllers
{
    public class HomeController: Controller
    {
        private readonly ApplicationContext db;

        public List<SelectListItem> ProviderListDate;
        public HomeController(ApplicationContext context)
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
        public async Task<IActionResult> Index()
        {
           
            var OrderList = await db.Order.ToListAsync();
          
           
                var OrderListDate = new List<OrderModel>();
                foreach (var item in OrderList)
                {
                    OrderListDate.Add(new OrderModel
                    {
                        Id = item.Id,
                        Number = item.Number,
                        Date = item.Date,
                        ProviderId = item.ProviderId
                    });

                }
                
            
            MainViewModel model = new MainViewModel()
            {
                Orders = OrderListDate,
                Providers = ProviderListDate               
            };            
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index([Bind("Date_Start,Date_End,SelectedValues")] MainViewModel mvm)
        {
            try
            {
                
                    var listProviderId = db.Order.Select(s => s.ProviderId);
                    var OrderList = await db.Order.Where(w => w.Date > mvm.Date_Start && w.Date < mvm.Date_End && listProviderId.Contains(w.ProviderId)).ToListAsync();
                    var OrderListDate = new List<OrderModel>();
                    foreach (var item in OrderList)
                    {
                        OrderListDate.Add(new OrderModel
                        {
                            Number = item.Number,
                            Date = item.Date,
                            ProviderId = item.ProviderId
                        });
                    }                    
                    mvm.Providers = ProviderListDate;
                    mvm.Orders = OrderListDate;
                
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error
                ModelState.AddModelError("", "Unable to save changes. " +
                "Try again, and if the problem persists, " +
                "see your system administrator.");
            }
            return View(mvm);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}