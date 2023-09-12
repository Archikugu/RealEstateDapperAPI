using RealEstateDapperAPI.Dtos.TestimonialDtos;

namespace RealEstateDapperAPI.Repositories.TestimonialRepositories
{
    public interface ITestimonialRepository
    {
        Task<List<ResultTestimonialDto>> GetAllTestimonialAsync();
    }
}
