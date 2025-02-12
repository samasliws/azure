using AzureFundamentals.Services;
using Microsoft.AspNetCore.Mvc;

namespace AzureFundamentals.Controllers
{
    public class ContainerController : Controller
    {
        private readonly IContainerService _containerService;
        public ContainerController(IContainerService containerService)
        {
            _containerService = containerService;
        }


        public async Task<IActionResult> Index()
        {
            var allContainer = await _containerService.GetAllContainer();
            return View(allContainer);
        }
    }
}
