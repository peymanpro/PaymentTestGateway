using PaymentTestGateway.Application.DTOs;
using PaymentTestGateway.Application.Interfaces;
using PaymentTestGateway.Domain.Entities;
using PaymentTestGateway.Domain.Enums;

namespace PaymentTestGateway.Infrastructure.Services;

public class PaymentService : IPaymentService
{
    private static readonly List<PaymentTransaction> Payments = [];

    public CreatePaymentResponse Create(CreatePaymentRequest request)
    {
        var payment = new PaymentTransaction
        {
            Id = Guid.NewGuid(),
            Amount = request.Amount,
            Description = request.Description,
            CallbackUrl = request.CallbackUrl,
            Status = PaymentStatus.Pending,
            CreatedAt = DateTime.UtcNow
        };

        Payments.Add(payment);

        return new CreatePaymentResponse
        {
            PaymentId = payment.Id,
            PaymentUrl = $"/pay/{payment.Id}"
        };
    }

    public PaymentTransaction? GetById(Guid paymentId)
    {
        return Payments.FirstOrDefault(x => x.Id == paymentId);
    }

    public bool UpdateStatus(Guid paymentId, PaymentStatus status)
    {
        var payment = Payments.FirstOrDefault(x => x.Id == paymentId);

        if (payment is null)
            return false;

        payment.Status = status;

        return true;
    }
}