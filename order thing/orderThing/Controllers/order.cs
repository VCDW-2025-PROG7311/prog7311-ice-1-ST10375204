using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using orderThing.Models;
using orderServ;
using orderServ.Services;


namespace orderThing.Controllers;

public class order : Controller
{
 private readonly ILogger<order> _logger;
        private readonly OrderService _orderService;  // Declare a field for OrderService

        // Inject the OrderService into the controller's constructor
        public order(ILogger<order> logger, OrderService orderService)
        {
            _logger = logger;
            _orderService = orderService;  // Initialize the OrderService
        }

     public IActionResult Privacy()
    {
        return View();
    }

     [HttpPost]
     public IActionResult Submit(string name, decimal price){

        var orderID=
        ViewBag.Message="Order: "+_orderService.CreateOrder()+" created";
        return View("Privacy");    
         }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}