using Core.Contracts;
using Core.ValueObjects;

namespace Application.Services;

public class CreditCardService : IPaymentService
{
    public object Process(OrderValueObject model)
    {
        return "Transação aprovada";
    }
}