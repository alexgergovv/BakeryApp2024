using BakeryApp2024.Core.Contracts;
using BakeryApp2024.Core.Models.Admin;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BakeryApp2024.Areas.Admin.Controllers
{
    public class ProductController : AdminBaseController
    {
        private readonly IProductService productService;
        private readonly IBakerService bakerService;

        public ProductController(IProductService _productService,
            IBakerService _bakerService)
        {
            productService = _productService;
            bakerService = _bakerService;
        }

        public async Task<IActionResult> Mine()
        {
            var userId = User.Id();
            var bakerId = await bakerService.GetBakerIdAsync(userId) ?? 0;
            var myProducts = new MyProductsViewModel()
            {
                AddedProducts = await productService.AllProductsByBakerIdAsync(bakerId)
            };

            return View(myProducts);
        }

        [HttpGet]
        public async Task<IActionResult> Approve()
        {
            var model = await productService.GetUnApprovedAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Approve(int houseId)
        {
            await productService.ApproveProductAsync(houseId);

            return RedirectToAction(nameof(Approve));
        }
    }
}
