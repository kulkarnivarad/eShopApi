using eShopApi.Interfaces;
using eShopApi.Models;

namespace eShopApi.Services
{
    public class ProductService
    {
        private readonly IProduct _productRepo;

        public ProductService(IProduct productRepo)
        {
            _productRepo = productRepo;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _productRepo.GetAllProductsAsync();
        }

        public async Task<Product> GetProductAsync(int ProductId)
        {
            return await _productRepo.GetProductAsync(ProductId);
        }

        public async Task<string> SaveProductAsync(Product product)
        {
            return await _productRepo.SaveProductAsync(product);
        }

        //public async Task<string> UpdateProductAsync(Product product)
        //{
        //    return await _productRepo.UpdateProductAsync(product);
        //}

        public string UpdateProduct(Product Product)
        {
            return _productRepo.UpdateProduct(Product);
        }

        public async Task<string> DeleteProductAsync(int ProductId)
        {
            return await _productRepo.DeleteProductAsync(ProductId);
        }

        public async Task<List<Product>> GetProductsByCategoryAsync(string category)
        {
            return await _productRepo.GetProductsByCategoryAsync(category);
        }
    }
}
