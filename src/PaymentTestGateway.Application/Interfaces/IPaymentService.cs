using PaymentTestGateway.Application.DTOs;
using PaymentTestGateway.Domain.Entities;

namespace PaymentTestGateway.Application.Interfaces;

public interface IPaymentService
{
    CreatePaymentResponse Create(CreatePaymentRequest request);
    PaymentTransaction? GetById(Guid paymentId);
}