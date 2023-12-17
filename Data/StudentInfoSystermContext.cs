using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentInfoSysterm.Model;

namespace StudentInfoSysterm.Data
{
    public class StudentInfoSystermContext : DbContext
    {
        public StudentInfoSystermContext (DbContextOptions<StudentInfoSystermContext> options)
            : base(options)
        {
        }

        public DbSet<StudentInfoSysterm.Model.Student> Student { get; set; } = default!;

        public DbSet<StudentInfoSysterm.Model.Course>? Course { get; set; }
    }
}
