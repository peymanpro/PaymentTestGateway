using PaymentTestGateway.Application.DTOs;

namespace PaymentTestGateway.Application.Interfaces;

public interface IPaymentService
{
    CreatePaymentResponse Create(CreatePaymentRequest request);
}