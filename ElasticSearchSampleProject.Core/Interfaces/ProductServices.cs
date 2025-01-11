using ElasticSearchSampleProject.Core.Entities;
using ElasticSearchSampleProject.Core.Models;

namespace ElasticSearchSampleProject.Core.Interfaces
{
    public interface IProductService
    {
        Task<List<Products>> GetPaginatedProductsAsync(int pageNumber, int pageSize,
            CancellationToken cancellationToken);

        Task<Products> GetProductByIdAsync(int productId, CancellationToken cancellationToken);
        Task AddproductAsync(Products product, CancellationToken cancellationToken);
        Task UpdateProductPricesAsync(int categoryId, decimal price, CancellationToken cancellationToken);
        Task<List<ProductSearchResult>> IndexProductsAsync(string searchTerm);
    }
}