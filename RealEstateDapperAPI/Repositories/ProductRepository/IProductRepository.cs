using RealEstateDapperAPI.Dtos.ProductDtos;

namespace RealEstateDapperAPI.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoriesAsync();
    }
}
