using Microsoft.AspNetCore.Mvc;

using WebShopApp.Core.Contracts;
using WebShopApp.Core.Services;

using WebStoreApp.Models.Statistic;

namespace WebStoreApp.Controllers
{
    public class StatisticController : Controller
    {
        private readonly IStatisticService statisticService;
        public StatisticController(IStatisticService statisticService)
        {
            this.statisticService = statisticService;
        }

        public IActionResult Index()
        {
            StatisticVM statistics = new StatisticVM();
            statistics.CountClients = statisticService.CountClients();
            statistics.CountProducts= statisticService.CountProducts();
            statistics.CountOrders= statisticService.CountOrders();
            statistics.SumOrders= statisticService.SumOrders();
            return View(statistics);
        }
    }
}
