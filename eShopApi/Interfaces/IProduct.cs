using eShopApi.Models;

namespace eShopApi.Interfaces
{
    public interface IProduct
    {
        Task<List<Product>> GetAllProductsAsync();
        Task<Product> GetProductAsync(int ProductId);
        Task<string> SaveProductAsync(Product product);
       //string UpdateProductAsync(Product product);

        string UpdateProduct(Product Product);
        Task<string> DeleteProductAsync(int ProductId);
        Task<List<Product>> GetProductsByCategoryAsync(string category);
    }
}
