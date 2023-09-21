using Core.Contracts;
using Core.ValueObjects;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IPaymentServiceFactory _paymentServiceFactory;

        public OrderController(IPaymentServiceFactory paymentServiceFactory)
        {
            _paymentServiceFactory = paymentServiceFactory;
        }

        [HttpPost]
        public async Task<IActionResult> Post(OrderValueObject model)
        {
            var service = _paymentServiceFactory.GetService(model.PaymentInfo.PaymentMethod);

            return Ok(service.Process(model));
        }
    }
}
