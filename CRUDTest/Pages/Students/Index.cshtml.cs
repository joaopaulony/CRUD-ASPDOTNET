using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUDTest.Data;
using JyorTest.Models;

namespace CRUDTest.Pages_Students
{
    public class IndexModel : PageModel
    {
        private readonly CRUDTest.Data.ApplicationDbContext _context;

        public IndexModel(CRUDTest.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Student = await _context.Students.ToListAsync();
        }
    }
}
