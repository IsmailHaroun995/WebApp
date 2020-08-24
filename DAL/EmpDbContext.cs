using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class EmpDbContext :DbContext
    {
        public EmpDbContext(DbContextOptions<EmpDbContext> options)
            : base(options)
        {
        }
        public DbSet<EEmployee> Emp { get; set; }
        public DbSet<EDepartment> Dep { get; set; }
        public DbSet<EmpByModel> EBM { get; set; }
    }
}
