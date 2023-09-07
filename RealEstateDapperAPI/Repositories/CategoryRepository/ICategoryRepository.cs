using RealEstateDapperAPI.Dtos.CategoryDtos;

namespace RealEstateDapperAPI.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
    }
}
