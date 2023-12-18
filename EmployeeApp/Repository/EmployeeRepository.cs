using EmployeeApp.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApp.Repository
{
    public class EmployeeRepository
    {
        private readonly EmployeeDbContext _employeeDbContext;
        public EmployeeRepository(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }

        public async Task<List<Employee>> Get()
        {
            return await _employeeDbContext.Employees.FromSql($"EXEC GETALLEMPLOYEES").ToListAsync();
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
