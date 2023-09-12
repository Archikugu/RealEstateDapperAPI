namespace RealEstateDapperAPI.Dtos.TestimonialDtos
{
    public class ResultTestimonialDto
    {
        public int TestimonialID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public String FullName => $"{Name} {Surname.ToUpper()}";
        public string Title { get; set; }
        public string Comment { get; set; }
        public bool Status { get; set; }
    }
}
