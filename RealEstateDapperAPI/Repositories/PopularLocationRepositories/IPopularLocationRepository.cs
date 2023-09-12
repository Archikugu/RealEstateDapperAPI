using RealEstateDapperAPI.Dtos.PopularLocationDtos;

namespace RealEstateDapperAPI.Repositories.PopularLocationRepositories
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync();
    }
}
