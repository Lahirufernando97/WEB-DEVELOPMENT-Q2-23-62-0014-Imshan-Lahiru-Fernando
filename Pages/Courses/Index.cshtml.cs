using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentInfoSysterm.Data;
using StudentInfoSysterm.Model;

namespace StudentInfoSysterm.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly StudentInfoSysterm.Data.StudentInfoSystermContext _context;

        public IndexModel(StudentInfoSysterm.Data.StudentInfoSystermContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Course != null)
            {
                Course = await _context.Course.ToListAsync();
            }
        }
    }
}
