namespace RealEstateDapperUI.Dtos.ProductDtos
{
    public class CreateProductDto
    {
        public string productTitle { get; set; }
        public decimal productPrice { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string district { get; set; }
        public string categoryid { get; set; }
        public string coverimage { get; set; }
        public string type { get; set; }
    }
}