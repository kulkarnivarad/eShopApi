using eShopApi.Interfaces;
using eShopApi.Models;

namespace eShopApi.Services
{
    public class PaymentService : IPayment
    {
        private readonly IPayment _paymentRepo;

        public PaymentService(IPayment paymentRepo)
        {
            _paymentRepo = paymentRepo;
        }

        public async Task<string> DeleteTransactionAsync(int transactionId)
        {
            return await _paymentRepo.DeleteTransactionAsync(transactionId);
        }

        public async Task<List<Payment>> GetAllTransactionAsync()
        {
            return await _paymentRepo.GetAllTransactionAsync();
        }

        public async Task<Payment> GetTransactionAsync(int transactionId)
        {
            return await _paymentRepo.GetTransactionAsync(transactionId);
        }

        public async Task<string> SaveTransactionAsync(Payment payment)
        {
            return await _paymentRepo.SaveTransactionAsync(payment);
        }

        public async Task<string> UpdateTransactionAsync(Payment payment)
        {
            return await _paymentRepo.UpdateTransactionAsync(payment);
        }
    }
}