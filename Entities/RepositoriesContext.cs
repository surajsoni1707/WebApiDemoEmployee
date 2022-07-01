using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemoEmployee.Model;

namespace WebApiDemoEmployee.Repositories
{
    public class RepositoriesContext: DbContext
    {
        public RepositoriesContext(DbContextOptions options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
