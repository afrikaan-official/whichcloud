using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WhichCloud.Web.Bus;
using WhichCloud.Web.Models;

namespace WhichCloud.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IVMService _vmService;
        private readonly ISourceService _sourceService;

        public HomeController(ILogger<HomeController> logger,
            IVMService vmService,
            ISourceService sourceService)
        {
            _logger = logger;
            _vmService = vmService;
            _sourceService = sourceService;
        }

        public async Task<IActionResult> Index()
        {
            var vms = await _vmService.GetAllVms();
            var model = new HomeVmModel
            {
                Vms = vms
            };


            return View(model);
        }
        
        [HttpPost]
        public async Task<IActionResult> AddSource([FromForm] SourceModel model)
        {
            if (ModelState.IsValid)
            {
                var result= await _sourceService.InsertSource(model);

                if (result > 0)
                {
                    return RedirectToAction("Index");
                }

                return BadRequest();
            }

            return BadRequest();
        }
        
    }
}