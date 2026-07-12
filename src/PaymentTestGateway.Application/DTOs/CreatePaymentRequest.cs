namespace PaymentTestGateway.Application.DTOs;

public class CreatePaymentRequest
{
    public decimal Amount { get; set; }

    public string Description { get; set; } = string.Empty;

    public string CallbackUrl { get; set; } = string.Empty;
}