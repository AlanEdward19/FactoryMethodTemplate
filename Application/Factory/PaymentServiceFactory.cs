﻿using Application.Services;
using Core.Contracts;
using Core.Enums;

namespace Application.Factory;

public class PaymentServiceFactory : IPaymentServiceFactory
{
    private readonly CreditCardService _creditCardService;
    private readonly PaymentSlipService _paymentSlipService;

    public PaymentServiceFactory(CreditCardService creditCardService, PaymentSlipService paymentSlipService)
    {
        _creditCardService = creditCardService;
        _paymentSlipService = paymentSlipService;
    }

    public IPaymentService GetService(EPaymentMethod paymentMethod) => paymentMethod switch
    {
        EPaymentMethod.CreditCard => _creditCardService,
        EPaymentMethod.PaymentSlip => _paymentSlipService,
    };
}