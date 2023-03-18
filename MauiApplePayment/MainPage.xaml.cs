namespace MauiApplePayment;

public partial class MainPage : ContentPage
{
    private readonly IApplePayAuthorizer _applePayAuthorizer;

    public MainPage(IApplePayAuthorizer applePayAuthorizer)
    {
        InitializeComponent();
        _applePayAuthorizer = applePayAuthorizer;

    }

    private void OnApplePayClicked(object sender, EventArgs e)
    {
        _applePayAuthorizer.AuthorizePayment(2);
        _applePayAuthorizer.PaymentSuccess +=  (arg) =>
        {
            System.Diagnostics.Debug.WriteLine(arg);
        };
        _applePayAuthorizer.PaymentFailed += async () =>
        {
            await DisplayAlert("Alert", "Payment Failed", "OK");
        };
    }
}


