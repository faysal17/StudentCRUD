using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentCRUD.Data;
using StudentCRUD.Models;

namespace StudentCRUD.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly StudentCRUD.Data.SchoolContext _context;

        public IndexModel(StudentCRUD.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Student != null)
            {
                Student = await _context.Students.ToListAsync();
            }
        }
    }
}
