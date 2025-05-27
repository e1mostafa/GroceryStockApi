using GroceryStockApi.Models;
using GroceryStockApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace GroceryStockApi.Controllers
{
	[ApiController]
	[Route("api/products")]
	public class ProductsController : ControllerBase
	{
		private readonly ProductService _service;

		public ProductsController(ProductService service)
		{
			_service = service;
		}

		// POST: /api/products/add
		[HttpPost("add")]
		public IActionResult AddProduct(Product product)
		{
			try
			{
				_service.AddProduct(product);
				return Ok(product);
			}
			catch (ArgumentException ex)
			{
				return BadRequest(new { message = ex.Message });
			}
		}

		// GET: /api/products/low-stock
		[HttpGet("low-stock")]
		public IActionResult GetLowStockProducts()
		{
			var lowStock = _service.GetLowStockProducts();
			return Ok(lowStock);
		}
	}
}
