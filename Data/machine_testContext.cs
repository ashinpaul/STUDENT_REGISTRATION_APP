using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using machine_test.Model;

namespace machine_test.Data
{
    public class machine_testContext : DbContext
    {
        public machine_testContext (DbContextOptions<machine_testContext> options)
            : base(options)
        {
        }

        public DbSet<machine_test.Model.Students> Students { get; set; } = default!;
    }
}
