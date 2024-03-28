namespace RealEstateDapperAPI.Repositories.EstateAgentRepositories.DashboardRepositories.StatisticsRepositories
{
    public interface IStatisticsRepository
    {
        int ProductCountByEmployeeId(int id);
        int ProductCountByStatusTrue(int id);
        int ProductCountByStatusFalse(int id);
        int AllProductCount();

    }
}
