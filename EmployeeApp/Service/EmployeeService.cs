using EmployeeApp.Model;
using EmployeeApp.Repository;

namespace EmployeeApp.Service
{
    public class EmployeeService
    {
        private readonly EmployeeRepository _employeeRepository;

        public EmployeeService(EmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<List<Employee>> Get()
        {
            return await _employeeRepository.Get();
        }


        //public async Task<Employee> Create()
        //{
           
        //}
        //public async Task<Employee> Update()
        //{
            
        //}
        //public async Task<Employee> Delete()
        //{
           
        //}
    }
}
