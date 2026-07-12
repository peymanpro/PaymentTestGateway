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

        if (status == PaymentStatus.Successful)
        {
            payment.PaidAt ??= DateTime.UtcNow;

            payment.ReferenceNumber ??= GenerateReferenceNumber();
        }

        return true;
    }

    public VerifyPaymentResponse? Verify(VerifyPaymentRequest request)
    {
        var payment = GetById(request.PaymentId);

        if (payment is null)
            return null;

        return new VerifyPaymentResponse
        {
            PaymentId = payment.Id,
            Status = payment.Status,
            Amount = payment.Amount,
            ReferenceNumber = payment.ReferenceNumber,
            PaidAt = payment.PaidAt
        };
    }

    private static string GenerateReferenceNumber()
    {
        return Random.Shared
            .NextInt64(100_000_000_000, 999_999_999_999)
            .ToString();
    }
}