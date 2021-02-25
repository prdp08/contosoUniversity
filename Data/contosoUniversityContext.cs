using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Models;

namespace contosoUniversity.Data
{
    public class contosoUniversityContext : DbContext
    {
        public contosoUniversityContext (DbContextOptions<contosoUniversityContext> options)
            : base(options)
        {
        }

        public DbSet<ContosoUniversity.Models.Student> Student { get; set; }

        public DbSet<ContosoUniversity.Models.Course> Course { get; set; }

        public DbSet<ContosoUniversity.Models.Enrollment> Enrollment { get; set; }
    }
}
