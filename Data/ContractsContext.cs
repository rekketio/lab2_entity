using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EntityProj.Data
{
    class ContractsContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Contract> Contracts { get; set; }

        public ContractsContext(DbContextOptions<ContractsContext> options) : base(options)
        {

        }
    }
}
