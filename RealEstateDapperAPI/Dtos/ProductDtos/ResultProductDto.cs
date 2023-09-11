namespace RealEstateDapperAPI.Dtos.ProductDtos
{
    public class ResultProductDto
    {
        public int ProductID { get; set; }
        public string ProductTitle { get; set; }
        public decimal ProductPrice { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public int ProductCategory { get; set; }
    }
}
