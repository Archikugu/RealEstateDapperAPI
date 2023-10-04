namespace RealEstateDapperUI.Dtos.EmployeeDtos
{
    public class CreateEmployeeDto
    {
        public string EmployeeName { get; set; }
        public string EmployeeTitle { get; set; }
        public string EmployeeMail { get; set; }
        public string EmployeePhoneNumber { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
    }
}
