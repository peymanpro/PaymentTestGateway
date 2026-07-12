using PaymentTestGateway.Application.DTOs;
using PaymentTestGateway.Domain.Entities;
using PaymentTestGateway.Domain.Enums;

namespace PaymentTestGateway.Application.Interfaces;

public interface IPaymentService
{
    CreatePaymentResponse Create(CreatePaymentRequest request);
    PaymentTransaction? GetById(Guid paymentId);
    bool UpdateStatus(Guid paymentId, PaymentStatus status);
}