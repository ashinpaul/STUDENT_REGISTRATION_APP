using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using machine_test.Data;
using machine_test.Model;

namespace machine_test.Pages.Student
{
    public class IndexModel : PageModel
    {
        private readonly machine_test.Data.machine_testContext _context;

        public IndexModel(machine_test.Data.machine_testContext context)
        {
            _context = context;
        }

        public IList<Students> Students { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Students != null)
            {
                Students = await _context.Students.ToListAsync();
            }
        }
    }
}
