using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace _0509
{
    public class TestDB:DbContext
    {
        public TestDB(DbContextOptions<TestDB> options)
            :base(options)
        {
            
        }

        public DbSet<TodoItem> TodoItems { get; set; }

    }
}
