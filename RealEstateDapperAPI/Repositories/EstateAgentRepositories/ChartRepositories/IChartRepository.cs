using RealEstateDapperAPI.Dtos.ChartDtos;

namespace RealEstateDapperAPI.Repositories.EstateAgentRepositories.ChartRepositories
{
    public interface IChartRepository
    {
        Task<List<ResultChartDto>> Get5CityForChart();
    }
}
