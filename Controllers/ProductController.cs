using Microsoft.AspNetCore.Mvc;
using MyApi.Models;

namespace MyApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var product = new Product
        {
            Id = 1,
            Name = "Laptop",
            Price = 1000
        };
        var product2 = new Product 
        {
            Id = 2,
            Name = "Smartphone",
            Price = 500
        };

        return Ok(new[] { product, product2 });
    }
}