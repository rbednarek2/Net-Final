using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Northwind.Models;

namespace Northwind.Controllers
{
    public class ReportController : Controller
    {
        // this controller depends on the NorthwindRepository
        private INorthwindRepository repository;
        public ReportController(INorthwindRepository repo) => repository = repo;

        public IActionResult CategoryBreakdown() => View(repository.Categories.OrderBy(c => c.CategoryId));

        [HttpGet, Route("reports/report")]
        public IEnumerable<CategoryRevenue> GetRevenue()
        {

            return repository.OrderDetails.GroupBy(od => od.Product.ProductName).Select(grp => new CategoryRevenue
            {
                ProductName = grp.Key,
                Revenue = grp.Sum(s => s.Quantity * s.UnitPrice * (1 - s.Discount))
            });
        }

        // returns all products
        [HttpGet, Route("reports/allProducts")]
        public IEnumerable<Product> Get() => repository.Products.OrderBy(p => p.ProductId);


        //[HttpGet, Route("api/Test")]
        // returns all products
        // public IEnumerable<Product> Get() => repository.Products.Select(Product.);

    }
}
