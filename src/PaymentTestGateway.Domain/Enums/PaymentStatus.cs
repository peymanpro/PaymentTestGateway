namespace PaymentTestGateway.Domain.Enums;

public enum PaymentStatus
{
    Pending = 0,
    Successful = 1,
    Failed = 2,
    Cancelled = 3,
    TimedOut = 4
}