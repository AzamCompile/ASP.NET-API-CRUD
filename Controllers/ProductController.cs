using Microsoft.AspNetCore.Mvc;
using MyApi.Models;

namespace MyApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private static List<Product> products =
    [
        new Product { Id = 1, Name = "Laptop", Price = 1000 },
        new Product { Id = 2, Name = "Phone", Price = 500 },
        new Product { Id = 3, Name = "Samsung", Price = 5000 },
        new Product { Id = 4, Name = "Headphones", Price = 1500 },
        new Product { Id = 5, Name = "Victus", Price = 500 },
        new Product { Id = 6, Name = "Phone", Price = 500 },
        new Product { Id = 7, Name = "Phone", Price = 500 },
        new Product { Id = 8, Name = "Phone", Price = 500 },
        new Product { Id = 9, Name = "Phone", Price = 500 },
    ];

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(products);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var product = products.FirstOrDefault(p => p.Id == id);

        if (product == null)
            return NotFound();

        return Ok(product);
    }

    [HttpPost]
    public IActionResult Create(Product product)
    {
        products.Add(product);

        return Ok(product);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Product updatedProduct)
    {
        var product = products.FirstOrDefault(p => p.Id == id);

        if (product == null)
            return NotFound();

        product.Name = updatedProduct.Name;
        product.Price = updatedProduct.Price;

        return Ok(product);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var product = products.FirstOrDefault(p => p.Id == id);

        if (product == null)
            return NotFound();

        products.Remove(product);

        return Ok("Deleted");
    }
}