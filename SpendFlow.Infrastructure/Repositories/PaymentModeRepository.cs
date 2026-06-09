using Microsoft.EntityFrameworkCore;
using SpendFlow.Domain.Interfaces;
using SpendFlow.Infrastructure.Data;
using SpendFlow.Domain.Entities;

namespace SpendFlow.Infrastructure.Repositories;

public class PaymentModeRepository : IPaymentModeRepository
{
    private readonly AppDbContext _context;

    public PaymentModeRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<PaymentMode>> GetAllAsync()
    {
        return await _context.PaymentMode.ToListAsync();
    }

    public async Task AddAsync(PaymentMode paymentMode)
    {
        await _context.PaymentMode.AddAsync(paymentMode);
    }
}