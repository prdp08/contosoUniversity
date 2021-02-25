using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Models;
using contosoUniversity.Data;

namespace contosoUniversity.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly contosoUniversity.Data.contosoUniversityContext _context;

        public IndexModel(contosoUniversity.Data.contosoUniversityContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; }

        public async Task OnGetAsync()
        {
            Course = await _context.Course.ToListAsync();
        }
    }
}
