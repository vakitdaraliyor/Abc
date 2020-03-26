using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Abc.Northwind.Business.Abstract;
using Abc.Northwind.Entities.Concreate;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Asp.Northwind.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            List<Product> products = new List<Product>();
            products = _productService.GetAll();

            ProductListViewModel model = new ProductListViewModel
            {
                Products = products
            };
            return View(model);
        }

        public IActionResult KendoGrid()
        {
            return View();
        }

        public IActionResult KendoGridCrud()
        {
            return View();
        }

        public async Task<IActionResult> GridData()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync("http://localhost:60966/api/product");
            string apiResponse = await response.Content.ReadAsStringAsync();
            // var productList = JsonConvert.DeserializeObject<Product>(apiResponse);

            return Json(apiResponse);
        }

    }
}