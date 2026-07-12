using PaymentTestGateway.Domain.Enums;

namespace PaymentTestGateway.Domain.Entities;

public class PaymentTransaction
{
    public Guid Id { get; set; }

    public decimal Amount { get; set; }

    public string Description { get; set; } = string.Empty;

    public string CallbackUrl { get; set; } = string.Empty;

    public PaymentStatus Status { get; set; }

    public string? ReferenceNumber { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? PaidAt { get; set; }
}