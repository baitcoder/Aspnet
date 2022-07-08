using FieldAssistWebApi.Models;
using FieldAssistWebApi.Services.Interface;
using System.Collections.Generic;
using System.Linq;

namespace FieldAssistWebApi.Services
{
    public class EmployeeService: IEmployeeService
    {
        private List<Employee> _employees;
        public EmployeeService()
        {
            _employees=new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,Name="Cat",City="Hyderabad",
                },
                new Employee()
                {
                    Id = 2,Name="Dog",City="Banglore",
                },
                new Employee()
                {
                    Id = 3,Name="human",City="Chennai",
                },
                new Employee()
                {
                    Id = 4,Name="Monkey",City="Pune",
                }

            };
        }


        //Create
        public void CreateEmployee(Employee employee)
        {
            _employees.Add(employee);
        }


        //Read

        public Employee GetEmployeeById(int id)
        {
            return _employees.FirstOrDefault(x => x.Id.Equals(id));
        }
        



        public List<Employee> GetEmployees()
        {
            return _employees;
        }


        //Update
        public void UpdateEmployee(Employee employee)
        {
            var originalEmployee = GetEmployeeById(employee.Id);
            if (originalEmployee != null)
            {
                _employees.ForEach(item =>
                {
                    if (item.Id == employee.Id)
                    {
                        item.Name = employee.Name;
                        item.City = employee.City;
                    }
                }
                );
            }
            else
            {
                _employees.Add(employee);
            }
        }


        //Delete
        public bool DeleteEmployee(int id)
        {
            _employees = _employees.Where(x => x.Id!=id).ToList();
            return true;
        }

        
    }

}
