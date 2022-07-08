using FieldAssistWebApi.Models;

namespace FieldAssistWebApi.Services.Interface
{
    public interface IEmployeeService
    {
        //Create
        void CreateEmployee(Employee employee);

        //Read
        Employee GetEmployeeById(int id);
        List<Employee> GetEmployees();

        //Update
        void UpdateEmployee(Employee employee);

        //Delete
        bool DeleteEmployee(int id);
    }
}
