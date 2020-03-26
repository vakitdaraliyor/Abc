using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Abc.Northwind.Business.Abstract;
using Abc.Northwind.Entities.Concreate;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Abc.Northwind.WebApi.Controllers
{
    [EnableCors("AllowAll")]
    [Route("api/[controller]")]
    [ApiController]    
    public class ProductController : ControllerBase
    {
        IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Get()
        {
            var products = _productService.GetAll();
            return Ok(products);
        }

        [HttpPost]
        public IActionResult Post(Product product)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest();                
            //}
            _productService.Add(product);
            return Ok();
        }
                
        [HttpDelete]
        public IActionResult Delete(Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _productService.Delete(product.ProductId);
            return Ok();
        }
    }
}