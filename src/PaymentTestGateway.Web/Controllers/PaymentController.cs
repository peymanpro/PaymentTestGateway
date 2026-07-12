using Microsoft.AspNetCore.Mvc;
using PaymentTestGateway.Application.DTOs;
using PaymentTestGateway.Application.Interfaces;
using PaymentTestGateway.Domain.Enums;

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

    [HttpPost("{paymentId:guid}/success")]
    public IActionResult Success(Guid paymentId)
    {
        var ok = paymentService.UpdateStatus(paymentId, PaymentStatus.Successful);

        if (!ok)
            return NotFound();

        return Ok();
    }

    [HttpPost("{paymentId:guid}/failed")]
    public IActionResult Failed(Guid paymentId)
    {
        var ok = paymentService.UpdateStatus(paymentId, PaymentStatus.Failed);

        if (!ok)
            return NotFound();

        return Ok();
    }


    [HttpPost("{paymentId:guid}/cancel")]
    public IActionResult Cancel(Guid paymentId)
    {
        var ok = paymentService.UpdateStatus(paymentId, PaymentStatus.Cancelled);

        if (!ok)
            return NotFound();

        return Ok();
    }

}