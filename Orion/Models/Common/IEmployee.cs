namespace Orion.Models.Common
{
    public interface IEmployee
    {
        string EmployeePension { get; set; }
        int EmployeeInsurance { get; set; }
        string EmployeeRole { get; set; }
        int EmployeeSalary { get; set; }
        DateTime EmployeeDateOfJoin { get; set; }
        string EmployeeStatus { get; set; }
        string EmployeeQualifications { get; set; }
    }
}
