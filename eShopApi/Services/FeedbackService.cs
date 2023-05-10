using eShopApi.Interfaces;
using eShopApi.Models;

namespace eShopApi.Services
{
    public class FeedbackService 
    {
        private readonly IFeedback _feedbackRepo;

        public FeedbackService(IFeedback feedbackRepo)
        {
            _feedbackRepo = feedbackRepo;
        }

        public async Task<bool> SaveFeedDetailsAsync(Feedback feedback)
        {
            return await _feedbackRepo.SaveFeedDetailsAsync(feedback);
        }

        public async Task<List<Feedback>> GetAllFeedDetailsAsync()
        {
            return await _feedbackRepo.GetAllFeedDetailsAsync();
        }

        public async Task<Feedback> GetFeedDetailsAsync(int UserId)
        {
            return await _feedbackRepo.GetFeedDetailsAsync(UserId);
        }

        public async Task<bool> DeleteFeedDetailsAsync(int id)
        {
            return await _feedbackRepo.DeleteFeedDetailsAsync(id);
        }
    }
}