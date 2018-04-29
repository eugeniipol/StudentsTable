using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StudentsTable.Models
{
    public class StudentsTableContext : DbContext
    {
        public StudentsTableContext (DbContextOptions<StudentsTableContext> options)
            : base(options)
        {
        }

        public DbSet<StudentsTable.Models.Student> Student { get; set; }
    }
}
