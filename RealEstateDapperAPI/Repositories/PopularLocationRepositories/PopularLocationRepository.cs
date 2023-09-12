using Dapper;
using RealEstateDapperAPI.Dtos.PopularLocationDtos;
using RealEstateDapperAPI.Models.DapperContext;

namespace RealEstateDapperAPI.Repositories.PopularLocationRepositories
{
    public class PopularLocationRepository : IPopularLocationRepository
    {
        private readonly Context _context;
        public PopularLocationRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync()
        {
            string query = "Select * From PopularLocation";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultPopularLocationDto>(query);
                return values.ToList();
            }
        }
    }
}
