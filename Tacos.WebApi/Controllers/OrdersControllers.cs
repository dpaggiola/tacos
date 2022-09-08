using Microsoft.AspNetCore.Mvc;
using Tacos.WebApi.Controllers.In;
using Tacos.WebApi.Controllers.Out;

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
        public IActionResult Get([FromRoute] int id)
        {
            return Ok(new OrderBasicInfoModel()
            {
                Id = 1,
                Table = 2

            }
            );
        }

        //api/orders?day='2022-08-10'
        [HttpGet]
        public IActionResult Get([FromQuery] string day)
        {
            return Ok();
        }

        //api/orders
        [HttpPost]
        public IActionResult CreateOrder([FromBody] OrderIntentModel order)
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