using Dapper;
using RealEstateDapperAPI.Dtos.ChartDtos;
using RealEstateDapperAPI.Models.DapperContext;

namespace RealEstateDapperAPI.Repositories.EstateAgentRepositories.ChartRepositories
{
    public class ChartRepository : IChartRepository
    {
        private readonly Context _context;
        public ChartRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultChartDto>> Get5CityForChart()
        {
            string query = "Select top(5) City,Count(*) as 'CityCount' From Products Group By City order By CityCount Desc";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultChartDto>(query);
                return values.ToList();
            }
        }
    }
}
