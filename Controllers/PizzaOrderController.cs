using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PizzaShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaOrderController : ControllerBase
    {
        private readonly ILogger<PizzaOrderController> _logger;

        public PizzaOrderController(ILogger<PizzaOrderController> logger, IPizzaRepo pizzaRepo) // needs an instance of pizzarepo
        {
            _logger = logger;
            _pizzaRepo = pizzaRepo;
        }

        [HttpGet] // [HttpGet("pizzaorders")] doesn't work btw
        public IEnumerable<PizzaOrder> Get()
        {

            PizzaOrder pizzaOrder = new PizzaOrder{
                OrderId = 1,
                PizzaName = "Buffalo",
            };

            PizzaOrder pizzaOrder2 = new PizzaOrder{
                OrderId = 2,
                PizzaName = "Vegano",
            };

            return new[] {pizzaOrder, pizzaOrder2};
        }
    }
}
