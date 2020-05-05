using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WhichCloud.Web.Bus;

namespace WhichCloud.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IVMService _vmService;

        public HomeController(ILogger<HomeController> logger, IVMService vmService)
        {
            _logger = logger;
            _vmService = vmService;
        }

        public async Task<IActionResult> Index()
        {
            var vms = await _vmService.GetAllVms();
            
            
            return View(vms);
        }
    }
}