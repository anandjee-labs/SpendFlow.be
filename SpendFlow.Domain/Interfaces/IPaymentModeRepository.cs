using SpendFlow.Domain.Entities;

namespace SpendFlow.Domain.Interfaces;

public interface IPaymentModeRepository
{
    Task<IEnumerable<PaymentMode>> GetAllAsync();
    Task AddAsync(PaymentMode paymentMode);
}