using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemoEmployee.Model;
using WebApiDemoEmployee.Repositories;

namespace WebApiDemoEmployee.Services
{
    public class EmployeeServices:IEmployeeServices
    {

        private readonly IEmployeeRepositories _iEmpRepo;
        // Injecition of Dependancy using constructor
        public EmployeeServices(IEmployeeRepositories iEmpRepo)
        {
            _iEmpRepo = iEmpRepo;
        }
        public int AddEmployee(Employee emp)
        {
            return _iEmpRepo.AddEmployee(emp);
        }
        public int DeleteEmployee(int id)
        {
            return _iEmpRepo.DeleteEmployee(id);
        }
        public IEnumerable<Employee> GetAllEmployee()
        {
            return _iEmpRepo.GetAllEmployee();
        }
        public int ModifyEmployee(Employee emp)
        {
            return _iEmpRepo.ModifyEmployee(emp);
        }
    }
}
