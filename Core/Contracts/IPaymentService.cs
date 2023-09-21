using Core.ValueObjects;

namespace Core.Contracts;

public interface IPaymentService
{
    object Process(OrderValueObject model);
}