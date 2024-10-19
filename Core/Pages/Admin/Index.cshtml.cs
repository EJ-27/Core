using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Core.DAL;
using Core.Models;

namespace Core.Pages.Admin
{
    public class IndexModel : PageModel
    {
        private readonly Core.DAL.AppDbContext _context;

        public IndexModel(Core.DAL.AppDbContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Employee = await _context.Employees
                .Include(e => e.FoodStore)
                .Include(e => e.Shop)
                .Include(e => e.Supervisor).ToListAsync();
        }
    }
}
