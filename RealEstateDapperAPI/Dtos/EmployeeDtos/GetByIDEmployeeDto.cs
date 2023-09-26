namespace RealEstateDapperAPI.Dtos.EmployeeDtos
{
    public class GetByIDEmployeeDto
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeTitle { get; set; }
        public string EmployeeMail { get; set; }
        public string EmployeePhoneNumber { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
    }
}
