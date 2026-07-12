namespace PaymentTestGateway.Application.DTOs;

public class CreatePaymentResponse
{
    public Guid PaymentId { get; set; }

    public string PaymentUrl { get; set; } = string.Empty;
}