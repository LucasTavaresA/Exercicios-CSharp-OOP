namespace _32_contratos_com_services.Services
{
    interface IOnlinePaymentService
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
