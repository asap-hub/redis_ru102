namespace Human.Details.api;

public class Employee
{ 
        public int EmployeeId { get; set; }
        public string Name { get; set; }
       public List<Sale> Sales { get; } = new();
    
}