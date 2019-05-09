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

        public IActionResult CategoryBreakdown() => View();

        [HttpGet, Route("reports/report")]
        public IEnumerable<CategoryRevenue> GetRevenue()
        {

            return repository.OrderDetails.GroupBy(od => od.Product.ProductName).Select(grp => new CategoryRevenue
            {
                ProductName = grp.Key,
                Revenue = grp.Sum(s => s.Quantity * s.UnitPrice * (1 - s.Discount))
            });
        }

        //TEST
        [HttpGet, Route("api/pro")]
        // returns all products
        public IEnumerable<OrderDetail> Get() => repository.OrderDetails.OrderBy(p => p.OrderID);




    }
}
