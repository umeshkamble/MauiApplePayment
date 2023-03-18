using System;
namespace MauiApplePayment
{
    public interface IApplePayAuthorizer
    {
        void AuthorizePayment(double amount);
        Action<string> PaymentSuccess { get; set; }
        Action PaymentFailed { get; set; }
    }
}

