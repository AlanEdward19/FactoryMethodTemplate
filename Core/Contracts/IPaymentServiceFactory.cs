using Core.Enums;

namespace Core.Contracts;

public interface IPaymentServiceFactory
{
    IPaymentService GetService(EPaymentMethod paymentMethod);
}