using Microsoft.AspNetCore.Mvc;
using PaymentTestGateway.Application.DTOs;
using PaymentTestGateway.Application.Interfaces;

namespace PaymentTestGateway.Web.Controllers;

[ApiController]
[Route("api/payment")]
public class PaymentController(IPaymentService paymentService) : ControllerBase
{
    [HttpPost("create")]
    public ActionResult<CreatePaymentResponse> Create(CreatePaymentRequest request)
    {
        var response = paymentService.Create(request);

        return Ok(response);
    }
}