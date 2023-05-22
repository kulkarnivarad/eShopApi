using eShopApi.Data;
using eShopApi.Interfaces;
using eShopApi.Models;
using Microsoft.EntityFrameworkCore;

namespace eShopApi.Repository
{
    public class FeedbackRepo : IFeedback
    {
        private readonly eShopDbContext _context;

        public FeedbackRepo(eShopDbContext context)
        {
            _context = context;
        }

        // Method to save feedback details 
        public async Task<bool> SaveFeedDetailsAsync(Feedback feedback)
        {
            var user = await _context.UserDetails.FirstOrDefaultAsync(u => u.EmailId == feedback.Email);
            if (user == null)
            {
                // User not found, do something...
                return false;
            }

            // User found, save feedback and return true
            _context.Feedbacks.Add(feedback);
            await _context.SaveChangesAsync();
            return true;
        }

        // Method to get all feedback details
        public async Task<List<Feedback>> GetAllFeedDetailsAsync()
        {
            return await _context.Feedbacks.ToListAsync();
        }

        // Method to get a specific feedback record 
        public async Task<Feedback> GetFeedDetailsAsync(int UserId)
        {
            Feedback feed = await _context.Feedbacks.FindAsync(UserId);
            return feed;
        }

        // Method to delete a feedback record 
        public async Task<bool> DeleteFeedDetailsAsync(int id)
        {
            var feedback = await _context.Feedbacks.FindAsync(id);
            if (feedback != null)
            {
                _context.Feedbacks.Remove(feedback);
                await _context.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
