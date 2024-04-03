using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HrmSolutions.Models;

namespace HrmSolutions.Data
{
    public class HrmSolutionsContext : DbContext
    {
        public HrmSolutionsContext (DbContextOptions<HrmSolutionsContext> options)
            : base(options)
        {
        }

        public DbSet<HrmSolutions.Models.Employees> Employees { get; set; } = default!;
    }
}
