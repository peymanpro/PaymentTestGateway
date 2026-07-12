using PaymentTestGateway.Domain.Enums;

namespace PaymentTestGateway.Application.DTOs;

public class VerifyPaymentResponse
{
    public Guid PaymentId { get; set; }

    public PaymentStatus Status { get; set; }

    public decimal Amount { get; set; }

    public string? ReferenceNumber { get; set; }

    public DateTime? PaidAt { get; set; }

    public bool IsSuccessful => Status == PaymentStatus.Successful;
}