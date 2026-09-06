namespace EmployeeManagement.API
{
    public class EmployeeModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Designation { get; set; } 

        public string? Adresss { get; set; }

        public int ServiceYears { get; set; }    
    }
}
