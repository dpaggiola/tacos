using Microsoft.AspNetCore.Mvc;

namespace Tacos.WebApi.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrdersControllers : ControllerBase
    {
        //api/orders
        [HttpGet()]
        public IActionResult Get()
        {
            return Ok();
        }

        //api/orders/2
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            return Ok();
        }

        //api/orders?day='2022-08-10'
        [HttpGet]
        public IActionResult Get([FromQuery] string day)
        {
            return Ok();
        }

        //api/orders
        [HttpPost]
        public IActionResult CreateOrder([FromBody] OrderModel order)
        {
            return Ok();
        }

        //api/orders/2
        // {
        //
        // }
        //
        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] OrderModel order)
        {
            return Ok();
        }

        //api/orders/2
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            return Ok();
        }

        //api/orders/
        [HttpDelete]
        public IActionResult DeleteAll()
        {
            return Ok();
        }
    }
}