using Core.Contracts;
using Core.ValueObjects;

namespace Application.Services;

public class PaymentSlipService : IPaymentService
{
    public object Process(OrderValueObject model)
    {
        return "Dados do Boleto";
    }
}