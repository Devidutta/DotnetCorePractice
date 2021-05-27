using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApp.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private readonly List<Employee> employeeList;

        public MockEmployeeRepository()
        {
            employeeList = new List<Employee>()
            {
                new Employee() {Id=1,Name="Devi",Email="abc@xyz.com",Department="IT" },
                new Employee() {Id=2,Name="Aruna",Email="def@xyz.com",Department="HR" },
                new Employee() {Id=3,Name="Nirmal",Email="ghi@xyz.com",Department="Finance" }
            };
        }
        public Employee GetEmployee(int Id)
        {
            return this.employeeList.FirstOrDefault(e => e.Id == Id);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return employeeList;
        }
    }
}
